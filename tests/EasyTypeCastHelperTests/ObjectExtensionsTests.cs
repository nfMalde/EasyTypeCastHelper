using EasyTypeCastHelper;
using Shouldly;
using System.Text.Json;

namespace EasyTypeCastHelperTests
{
    public class ObjectExtensionsTests
    {
        [Fact]
        public void ToNullableJson_ShouldSerializeObjectToJson()
        {
            var obj = new { Name = "Test", Value = 123 };
            var json = obj.ToNullableJson();
            json.ShouldBe("{\"Name\":\"Test\",\"Value\":123}");
        }

        [Fact]
        public void ToNullableJson_ShouldSerializeObjectToJson_WithOptions()
        {
            var obj = new { Name = "Test", Value = 123 };
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var json = obj.ToNullableJson(options);
            json.ShouldBe("{\"name\":\"Test\",\"value\":123}");
        }

        [Fact]
        public void ToJson_ShouldSerializeObjectToJson()
        {
            var obj = new { Name = "Test", Value = 123 };
            var json = obj.ToJson();
            json.ShouldBe("{\"Name\":\"Test\",\"Value\":123}");
        }

        [Fact]
        public void ToJson_ShouldSerializeObjectToJson_WithOptions()
        {
            var obj = new { Name = "Test", Value = 123 };
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var json = obj.ToJson(options);
            json.ShouldBe("{\"name\":\"Test\",\"value\":123}");
        }

        [Fact]
        public void ToJson_ShouldReturnNull_WhenObjectIsNull()
        {
            object? obj = null;
            var json = obj.ToJson();
            json.ShouldBeNull();
        }
    }
}
