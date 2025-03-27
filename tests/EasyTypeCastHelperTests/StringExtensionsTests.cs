using System;
using System.Globalization;
using Xunit;
using Shouldly;
using EasyTypeCastHelper;
using System.Text.Json;

namespace EasyTypeCastHelperTests
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData("123", 123)]
        [InlineData("abc", 0)]
        [InlineData(null, 0)]
        public void ToInt_ShouldConvertStringToInt(string? value, int expected)
        {
            value.ToInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData("123", 123)]
        [InlineData("abc", null)]
        [InlineData(null, null)]
        public void ToNullableInt_ShouldConvertStringToNullableInt(string? value, int? expected)
        {
            value.ToNullableInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData("123.45", 123.45)]
        [InlineData("abc", 0.0)]
        [InlineData(null, 0.0)]
        public void ToDouble_ShouldConvertStringToDouble(string? value, double expected)
        {
            value.ToDouble().ShouldBe(expected);
        }

        [Theory]
        [InlineData("123.45", 123.45)]
        [InlineData("abc", null)]
        [InlineData(null, null)]
        public void ToNullableDouble_ShouldConvertStringToNullableDouble(string? value, double? expected)
        {
            value.ToNullableDouble().ShouldBe(expected);
        }

        [Theory]
        [InlineData("true", true)]
        [InlineData("false", false)]
        [InlineData("abc", false)]
        [InlineData(null, false)]
        public void ToBool_ShouldConvertStringToBool(string? value, bool expected)
        {
            value.ToBool().ShouldBe(expected);
        }

        [Theory]
        [InlineData("true", true)]
        [InlineData("false", false)]
        [InlineData("abc", null)]
        [InlineData(null, null)]
        public void ToNullableBool_ShouldConvertStringToNullableBool(string? value, bool? expected)
        {
            value.ToNullableBool().ShouldBe(expected);
        }

        [Theory]
        [InlineData("2021-01-01", "2021-01-01T00:00:00")]
        [InlineData("abc", "2000-01-01T00:00:00")]
        [InlineData(null, "2000-01-01T00:00:00")]
        public void ToDateTime_ShouldConvertStringToDateTime(string? value, string expected)
        {
            var defaultValue = new DateTime(2000, 1, 1);
            value.ToDateTime(defaultValue).ShouldBe(DateTime.Parse(expected));
        }

        [Theory]
        [InlineData("2021-01-01", "2021-01-01T00:00:00")]
        [InlineData("abc", null)]
        [InlineData(null, null)]
        public void ToNullableDateTime_ShouldConvertStringToNullableDateTime(string? value, string? expected)
        {
            DateTime? expectedDate = expected != null ? DateTime.Parse(expected) : (DateTime?)null;
            value.ToNullableDateTime().ShouldBe(expectedDate);
        }

        [Theory]
        [InlineData("d2719b1e-1d3b-4b5e-9b1e-1d3b4b5e9b1e", "d2719b1e-1d3b-4b5e-9b1e-1d3b4b5e9b1e")]
        [InlineData("abc", "00000000-0000-0000-0000-000000000000")]
        [InlineData(null, "00000000-0000-0000-0000-000000000000")]
        public void ToGuid_ShouldConvertStringToGuid(string? value, string expected)
        {
            var defaultValue = Guid.Empty;
            value.ToGuid(defaultValue).ShouldBe(Guid.Parse(expected));
        }

        [Theory]
        [InlineData("d2719b1e-1d3b-4b5e-9b1e-1d3b4b5e9b1e", "d2719b1e-1d3b-4b5e-9b1e-1d3b4b5e9b1e")]
        [InlineData("abc", null)]
        [InlineData(null, null)]
        public void ToNullableGuid_ShouldConvertStringToNullableGuid(string? value, string? expected)
        {
            Guid? expectedGuid = expected != null ? Guid.Parse(expected) : (Guid?)null;
            value.ToNullableGuid().ShouldBe(expectedGuid);
        }

        [Theory]
        [InlineData("Monday", DayOfWeek.Monday)]
        [InlineData("abc", DayOfWeek.Sunday)]
        [InlineData(null, DayOfWeek.Sunday)]
        public void ToEnum_ShouldConvertStringToEnum(string? value, DayOfWeek expected)
        {
            value.ToEnum(DayOfWeek.Sunday).ShouldBe(expected);
        }

        [Theory]
        [InlineData("Monday", DayOfWeek.Monday)]
        [InlineData("abc", null)]
        [InlineData(null, null)]
        public void ToNullableEnum_ShouldConvertStringToNullableEnum(string? value, DayOfWeek? expected)
        {
            value.ToNullableEnum<DayOfWeek>().ShouldBe(expected);
        }

        [Fact]
        public void DeserializeFromJson_ShouldDeserializeValidJson()
        {
            string json = "{\"Name\":\"John\",\"Age\":30}";
            var result = json.DeserializeFromJson<TestClass>();
            result.ShouldNotBeNull();
            result.Name.ShouldBe("John");
            result.Age.ShouldBe(30);
        }

        [Fact]
        public void DeserializeFromJson_ShouldReturnNullForInvalidJson()
        {
            string json = "invalid json"; 

            Should.Throw<JsonException>(() => json.DeserializeFromJson<TestClass>());   
        }

        [Fact]
        public void DeserializeFromNullableJson_ShouldDeserializeValidJson()
        {
            string json = "{\"Name\":\"John\",\"Age\":30}";
            var result = json.DeserializeFromNullableJson<TestClass>();
            result.ShouldNotBeNull();
            result.Name.ShouldBe("John");
            result.Age.ShouldBe(30);
        }

        [Fact]
        public void DeserializeFromNullableJson_ShouldReturnNullForNullInput()
        {
            string? json = null;
            var result = json.DeserializeFromNullableJson<TestClass>();
            result.ShouldBeNull();
        }

        [Fact]
        public void DeserializeFromNullableJson_ShouldReturnNullForInvalidJson()
        {
            string json = "invalid json";
            Should.Throw<JsonException>(() => json.DeserializeFromNullableJson<TestClass>());
        }

        private class TestClass
        {
            public string? Name { get; set; }
            public int Age { get; set; }
        }
    }
}
