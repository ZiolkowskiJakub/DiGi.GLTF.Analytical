using System.ComponentModel;

namespace DiGi.GLTF.Analytical.Enums
{
    /// <summary>
    /// Defines how a building model is grouped into GLTF node instances.
    /// </summary>
    [Description("BuildingDisplayMode")]
    public enum BuildingDisplayMode
    {
        /// <summary>
        /// Each component (wall, roof, floor, window) becomes a separate selectable node.
        /// </summary>
        [Description("Component")] Component,

        /// <summary>
        /// All components are merged into a single node per building, making the building selectable as a whole.
        /// </summary>
        [Description("Envelope")] Envelope,
    }
}
