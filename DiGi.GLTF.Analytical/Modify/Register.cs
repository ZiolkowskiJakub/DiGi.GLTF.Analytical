namespace DiGi.GLTF.Analytical
{
    public static partial class Modify
    {
        /// <summary>
        /// Registers all <see cref="GLTF.Interfaces.IGLTFNodeConverter"/> implementations of this assembly (the DiGi.Analytical converters under /Classes/Converter) with the generic DiGi.GLTF engine.
        /// <para>Consuming applications call this method once at startup to enable the conversion of DiGi.Analytical objects by the generic DiGi.GLTF endpoints and scene factories.</para>
        /// </summary>
        public static void Register()
        {
            GLTF.Modify.Register(typeof(Modify).Assembly);
        }
    }
}
