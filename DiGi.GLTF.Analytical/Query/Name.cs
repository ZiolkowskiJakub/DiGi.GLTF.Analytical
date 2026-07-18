using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.GLTF.Analytical
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the display name for the specified <see cref="IReference"/>: the last step of a <see cref="ComplexReference"/> chain (or the reference itself) rendered as FullTypeName::UniqueId.
        /// </summary>
        /// <param name="reference">The reference to be named. This value can be null.</param>
        /// <returns>The display name in the FullTypeName::UniqueId format, or null if the reference does not resolve to an <see cref="IUniqueReference"/> with a type and a unique identifier.</returns>
        public static string? Name(this IReference? reference)
        {
            IReference? reference_Temp = reference;
            if (reference_Temp is ComplexReference complexReference)
            {
                reference_Temp = complexReference.Count > 0 ? complexReference[complexReference.Count - 1] : null;
            }

            if (reference_Temp is not IUniqueReference uniqueReference)
            {
                return null;
            }

            string? fullTypeName = uniqueReference.TypeReference?.FullTypeName;
            string? uniqueId = uniqueReference.UniqueId;

            if (string.IsNullOrWhiteSpace(fullTypeName) || string.IsNullOrWhiteSpace(uniqueId))
            {
                return null;
            }

            return $"{fullTypeName}::{uniqueId}";
        }
    }
}
