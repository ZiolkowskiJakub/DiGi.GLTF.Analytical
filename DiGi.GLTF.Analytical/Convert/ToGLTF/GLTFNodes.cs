using DiGi.Analytical.Building;
using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Urban.Classes;
using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.GLTF.Classes;
using System.Collections.Generic;

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
        /// <param name="tolerance">The distance tolerance used during triangulation.</param>
        /// <returns>A list of <see cref="GLTFNode"/> instances for all convertible components, or null if the building model is null or has no components.</returns>
        public static List<GLTFNode>? ToGLTF_GLTFNodes(this BuildingModel? buildingModel, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            List<IComponent>? components = buildingModel?.GetComponents<IComponent>();
            if (components is null)
            {
                return null;
            }

            List<GLTFNode> result = [];
            foreach (IComponent component in components)
            {
                List<GLTFNode>? gLTFNodes = ToGLTF_GLTFNodes(component, tolerance);
                if (gLTFNodes is not null)
                {
                    result.AddRange(gLTFNodes);
                }
            }

            return result;
        }

        /// <summary>
        /// Converts the specified <see cref="UrbanModel"/> into <see cref="GLTFNode"/> instances by converting all contained <see cref="BuildingModel"/> instances.
        /// </summary>
        /// <param name="urbanModel">The <see cref="UrbanModel"/> to be converted. This value can be null.</param>
        /// <param name="tolerance">The distance tolerance used during triangulation.</param>
        /// <returns>A list of <see cref="GLTFNode"/> instances for all contained building models, or null if the urban model is null or empty.</returns>
        public static List<GLTFNode>? ToGLTF_GLTFNodes(this UrbanModel? urbanModel, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            List<BuildingModel>? buildingModels = urbanModel?.GetBuildingModels();
            if (buildingModels is null)
            {
                return null;
            }

            List<GLTFNode> result = [];
            foreach (BuildingModel buildingModel in buildingModels)
            {
                List<GLTFNode>? gLTFNodes = ToGLTF_GLTFNodes(buildingModel, tolerance);
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
        /// <param name="tolerance">The distance tolerance used during triangulation.</param>
        /// <returns>A list with a single <see cref="GLTFNode"/> representing the component, or null if the component has no supported surface geometry.</returns>
        public static List<GLTFNode>? ToGLTF_GLTFNodes(this IComponent? component, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            ISurface3D? surface3D = component?.Surface3D();
            if (component is null || surface3D is null)
            {
                return null;
            }

            double opacity = component is IWindow ? 0.5 : 1;

            string? properties = (component as ISerializableObject)?.ToSystem_String();

            GLTFNode? gLTFNode = Create.GLTFNode(surface3D, component.GetType().Name, Core.Create.UniqueReference(component)?.ToString(), Query.Color(component as ISerializableObject), opacity, properties, tolerance);
            if (gLTFNode is null)
            {
                return null;
            }

            return [gLTFNode];
        }
    }
}
