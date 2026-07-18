using DiGi.Analytical.Building;
using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Urban.Classes;
using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Analytical.Building.Enums;
using DiGi.GLTF.Classes;
using System.Collections.Generic;
using DiGi.Core.Classes;

namespace DiGi.GLTF.Analytical
{
    public static partial class Convert
    {
        // Domain-to-glTF conversion for the DiGi.Analytical object model. The generic
        // ISerializableObject dispatch lives in the DiGi.GLTF engine (DiGi.GLTF.Convert.ToGLTF_GLTFNodes):
        // the converter classes under /Classes/Converter plug the typed methods below into the engine
        // registry (see Modify.Register).

        /// <summary>
        /// Converts all components of the specified <see cref="BuildingModel"/> (walls, roofs, floors and other components with surface geometry) into <see cref="GLTFNode"/> instances.
        /// </summary>
        /// <param name="buildingModel">The <see cref="BuildingModel"/> to be converted. This value can be null.</param>
        /// <param name="reference">The optional root <see cref="IReference"/> of the building model (for example a county + building <see cref="ComplexReference"/>). Node references extend it (component step appended per node) and node names are derived from its last step (see <see cref="Query.Name(IReference?)"/>).</param>
        /// <param name="tolerance">The distance tolerance used during triangulation.</param>
        /// <param name="buildingModelDetailLevel">The <see cref="BuildingModelDetailLevel"/> that determines whether components become individual nodes or are merged into a single envelope node per building.</param>
        /// <returns>A list of <see cref="GLTFNode"/> instances for all convertible components, or null if the building model is null or has no components.</returns>
        public static List<GLTFNode>? ToGLTF_GLTFNodes(this BuildingModel? buildingModel, IReference? reference = null,double tolerance = Core.Constants.Tolerance.Distance, BuildingModelDetailLevel buildingModelDetailLevel = BuildingModelDetailLevel.Component)
        {
            if (buildingModel is null)
            {
                return null;
            }

            if (buildingModelDetailLevel == BuildingModelDetailLevel.Envelope)
            {
                List<IComponent>? components_Envelope = buildingModel.GetComponents<IComponent>();
                if (components_Envelope is null || components_Envelope.Count == 0)
                {
                    return null;
                }

                List<Triangle3D> triangle3Ds = [];
                foreach (IComponent component in components_Envelope)
                {
                    List<ISpace>? spaces = buildingModel.GetSpaces(component);
                    if(spaces is not null && spaces.Count > 1)
                    {
                        continue;
                    }

                    IReference? reference_Component = null;
                    if (reference is not null)
                    {
                        reference_Component = Core.Create.Reference(reference, Core.Create.UniqueReference(component));
                    }

                    List<GLTFNode>? gLTFNodes_Component = ToGLTF_GLTFNodes(component, reference_Component, tolerance);
                    if (gLTFNodes_Component is null)
                    {
                        continue;
                    }

                    foreach (GLTFNode gLTFNode_Component in gLTFNodes_Component)
                    {
                        Mesh3D? mesh3D_Component = gLTFNode_Component.Mesh3D;
                        if (mesh3D_Component is null)
                        {
                            continue;
                        }

                        List<Triangle3D>? triangle3Ds_Component = mesh3D_Component.GetTriangles();
                        if (triangle3Ds_Component is not null)
                        {
                            triangle3Ds.AddRange(triangle3Ds_Component);
                        }
                    }
                }

                if (triangle3Ds.Count == 0)
                {
                    return null;
                }

                Mesh3D? mesh3D_Envelope = Geometry.Spatial.Create.Mesh3D(triangle3Ds, tolerance);
                if (mesh3D_Envelope is null)
                {
                    return null;
                }

                IReference? reference_Envelope = reference ?? Core.Create.UniqueReference(buildingModel);

                string? reference_Temp = reference_Envelope?.ToString();
                if(string.IsNullOrWhiteSpace(reference_Temp))
                {
                    reference_Temp = buildingModel.UniqueId;
                }

                string? name = Query.Name(reference_Envelope);
                if (string.IsNullOrWhiteSpace(name))
                {
                    name = $"BuildingModel {reference_Temp}";
                }

                GLTFNode? gLTFNode = Create.GLTFNode(mesh3D_Envelope, name, reference_Temp, Query.Color(buildingModel), 1, buildingModel.ToSystem_String(), tolerance);
                if (gLTFNode is null)
                {
                    return null;
                }

                return [gLTFNode];
            }

            List<IComponent>? components = buildingModel?.GetComponents<IComponent>();
            if (components is null)
            {
                return null;
            }

            List<GLTFNode> result = [];
            foreach (IComponent component in components)
            {
                IReference? reference_Component = null;
                if (reference is not null)
                {
                    reference_Component = Core.Create.Reference(reference, Core.Create.UniqueReference(component));
                }

                List<GLTFNode>? gLTFNodes = ToGLTF_GLTFNodes(component, reference_Component, tolerance);
                if (gLTFNodes is not null)
                {
                    result.AddRange(gLTFNodes);
                }
            }

            return result;
        }

        /// <summary>
        /// Converts the specified building <see cref="IComponent"/> (for example a wall, a floor or a roof) into <see cref="GLTFNode"/> instances using its surface representation (see <see cref="DiGi.Analytical.Building.Query.Surface3D(IComponent?)"/>) and default component styling.
        /// </summary>
        /// <param name="component">The building component to be converted. This value can be null.</param>
        /// <param name="reference">The optional <see cref="IReference"/> identifying the component (for example a county + building + component <see cref="ComplexReference"/>). Its string form becomes the node reference and its last step becomes the node name (see <see cref="Query.Name(IReference?)"/>).</param>
        /// <param name="tolerance">The distance tolerance used during triangulation.</param>
        /// <returns>A list with a single <see cref="GLTFNode"/> representing the component, or null if the component has no supported surface geometry.</returns>
        public static List<GLTFNode>? ToGLTF_GLTFNodes(this IComponent? component, IReference? reference = null, double tolerance = Core.Constants.Tolerance.Distance)
        {
            ISurface3D? surface3D = component?.Surface3D();
            if (component is null || surface3D is null)
            {
                return null;
            }

            double opacity = component is IWindow ? 0.5 : 1;

            string? properties = (component as ISerializableObject)?.ToSystem_String();

            IReference? reference_Component = reference ?? Core.Create.UniqueReference(component);

            string? reference_Temp = reference_Component?.ToString();

            string? name = Query.Name(reference_Component);
            if (string.IsNullOrWhiteSpace(name))
            {
                name = component.GetType().Name;
            }

            GLTFNode? gLTFNode = Create.GLTFNode(surface3D, name, reference_Temp, Query.Color(component), opacity, properties, tolerance);
            if (gLTFNode is null)
            {
                return null;
            }

            return [gLTFNode];
        }
    }
}
