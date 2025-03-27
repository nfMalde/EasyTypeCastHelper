using EasyTypeCastHelper;
using Shouldly;

namespace EasyTypeCastHelperTests
{
    public class DecimalExtensionsTests
    {
        [Theory]
        [InlineData(1.0, true)]
        [InlineData(0.0, false)]
        public void ToBool_ShouldConvertDecimalToBool(decimal value, bool expected)
        {
            value.ToBool().ShouldBe(expected);
        }

        [Theory]
        [InlineData(1.0, true)]
        [InlineData(0.0, false)]
        [InlineData(null, null)]
        public void ToNullableBool_ShouldConvertNullableDecimalToNullableBool(double? value, bool? expected)
        {
            decimal? d = null;

            if (value.HasValue)
            {
                d = (decimal)value.Value;
            }

            d.ToNullableBool().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123.0, 123U)]
        [InlineData(0.0, 0U)]
        public void ToUInt_ShouldConvertDecimalToUInt(decimal value, uint expected)
        {
            value.ToUInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123.0, 123U)]
        [InlineData(null, null)]
        public void ToUInt_Nullable_ShouldConvertNullableDecimalToNullableUInt(double? value, uint? expected)
        {
            decimal? d = null;

            if (value.HasValue)
            {
                d = (decimal)value.Value;
            }

            d.ToUInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123.0, (ushort)123)]
        [InlineData(0.0, (ushort)0)]
        public void ToUShort_ShouldConvertDecimalToUShort(decimal value, ushort expected)
        {
            value.ToUShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123.0, (ushort)123)]
        [InlineData(null, null)]
        public void ToUShort_Nullable_ShouldConvertNullableDecimalToNullableUShort(double? value, ushort? expected)
        {
            decimal? d = null;

            if (value.HasValue)
            {
                d = (decimal)value.Value;
            }

            d.ToUShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123.0, (short)123)]
        [InlineData(0.0, (short)0)]
        public void ToShort_ShouldConvertDecimalToShort(decimal value, short expected)
        {
            value.ToShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123.0, (short)123)]
        [InlineData(null, null)]
        public void ToShort_Nullable_ShouldConvertNullableDecimalToNullableShort(double? value, short? expected)
        {
            decimal? d = null;

            if (value.HasValue)
            {
                d = (decimal)value.Value;
            }

            d.ToShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123.0, 123UL)]
        [InlineData(0.0, 0UL)]
        public void ToULong_ShouldConvertDecimalToULong(decimal value, ulong expected)
        {
            value.ToULong().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123.0, 123UL)]
        [InlineData(null, null)]
        public void ToULong_Nullable_ShouldConvertNullableDecimalToNullableULong(double? value, ulong? expected)
        {
            decimal? d = null;

            if (value.HasValue)
            {
                d = (decimal)value.Value;
            }

            d.ToULong().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123.0, 123)]
        [InlineData(0.0, 0)]
        public void ToInt_ShouldConvertDecimalToInt(decimal value, int expected)
        {
            value.ToInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123.0, 123)]
        [InlineData(null, null)]
        public void ToInt_Nullable_ShouldConvertNullableDecimalToNullableInt(double? value, int? expected)
        {
            decimal? d = null;

            if (value.HasValue)
            {
                d = (decimal)value.Value;
            }

            d.ToInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123.0, 123L)]
        [InlineData(0.0, 0L)]
        public void ToLong_ShouldConvertDecimalToLong(decimal value, long expected)
        { 
            value.ToLong().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123.0, 123L)]
        [InlineData(null, null)]
        public void ToLong_Nullable_ShouldConvertNullableDecimalToNullableLong(double? value, long? expected)
        {
            decimal? d = null;

            if (value.HasValue)
            {
                d = (decimal)value.Value;
            }

            d.ToLong().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123.0, 123.0f)]
        [InlineData(0.0, 0.0f)]
        public void ToFloat_ShouldConvertDecimalToFloat(decimal value, float expected)
        {
            value.ToFloat().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123.0, 123.0f)]
        [InlineData(null, null)]
        public void ToFloat_Nullable_ShouldConvertNullableDecimalToNullableFloat(double? value, float? expected)
        {
            decimal? d = null;

            if (value.HasValue)
            {
                d = (decimal)value.Value;
            }

            d.ToFloat().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123.0, 123.0)]
        [InlineData(0.0, 0.0)]
        public void ToDouble_ShouldConvertDecimalToDouble(decimal value, double expected)
        {
            value.ToDouble().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123.0, 123.0)]
        [InlineData(null, null)]
        public void ToDouble_Nullable_ShouldConvertNullableDecimalToNullableDouble(double? value, double? expected)
        {
            decimal? d = null;

            if (value.HasValue)
            {
                d = (decimal)value.Value;
            }

            d.ToDouble().ShouldBe(expected);
        }
    }
}

