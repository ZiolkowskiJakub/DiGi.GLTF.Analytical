using DiGi.Analytical.Building.Interfaces;
using DiGi.Core.Interfaces;

namespace DiGi.GLTF.Analytical
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the default display <see cref="Core.Classes.Color"/> for the specified building component (for example a wall, a floor or a roof).
        /// </summary>
        /// <param name="serializableObject">The building component to be styled. This value can be null.</param>
        /// <returns>A <see cref="Core.Classes.Color"/> representing the default styling of the component, or null if no default styling is defined.</returns>
        public static Core.Classes.Color? Color(this ISerializableObject? serializableObject)
        {
            return serializableObject switch
            {
                IWindow => new Core.Classes.Color(byte.MaxValue, 135, 206, 235),
                IDoor => new Core.Classes.Color(byte.MaxValue, 139, 90, 43),
                IRoof => new Core.Classes.Color(byte.MaxValue, 178, 34, 34),
                IWall => new Core.Classes.Color(byte.MaxValue, 235, 230, 220),
                IFloor => new Core.Classes.Color(byte.MaxValue, 128, 128, 128),
                IShade => new Core.Classes.Color(byte.MaxValue, 105, 105, 105),
                _ => null,
            };
        }
    }
}
