using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EasyTypeCastHelper
{
    /// <summary>
    /// Provides extension methods for object serialization.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Serializes the specified object to a JSON string.
        /// </summary>
        /// <param name="value">The object to serialize.</param>
        /// <param name="options">Optional JSON serializer options.</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string? ToNullableJson(this object value, JsonSerializerOptions? options = null) => JsonSerializer.Serialize(value, options);

        /// <summary>
        /// Serializes the specified object to a JSON string if it is not null.
        /// </summary>
        /// <param name="value">The object to serialize, or null.</param>
        /// <param name="options">Optional JSON serializer options.</param>
        /// <returns>A JSON string representation of the object, or null if the object is null.</returns>
        public static string? ToJson(this object? value, JsonSerializerOptions? options = null) => value == null ? null : JsonSerializer.Serialize(value, options);
    }

    
}
