using EasyTypeCastHelper;
using Shouldly;

namespace EasyTypeCastHelperTests
{
    public class UintExtensionsTests
    {
        [Theory]
        [InlineData(123U, 123)]
        [InlineData(0U, 0)]
        public void ToInt_ShouldConvertUintToInt(uint value, int expected)
        {
            value.ToInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123U, 123)]
        [InlineData(null, null)]
        public void ToInt_Nullable_ShouldConvertNullableUintToNullableInt(uint? value, int? expected)
        {
            value.ToInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123U, (short)123)]
        [InlineData(0U, (short)0)]
        public void ToShort_ShouldConvertUintToShort(uint value, short expected)
        {
            value.ToShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123U, (short)123)]
        [InlineData(null, null)]
        public void ToShort_Nullable_ShouldConvertNullableUintToNullableShort(uint? value, short? expected)
        {
            value.ToShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123U, 123L)]
        [InlineData(0U, 0L)]
        public void ToLong_ShouldConvertUintToLong(uint value, long expected)
        {
            value.ToLong().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123U, 123L)]
        [InlineData(null, null)]
        public void ToLong_Nullable_ShouldConvertNullableUintToNullableLong(uint? value, long? expected)
        {
            value.ToLong().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123U, 123.0)]
        [InlineData(0U, 0.0)]
        public void ToDouble_ShouldConvertUintToDouble(uint value, double expected)
        {
            value.ToDouble().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123U, 123.0)]
        [InlineData(null, null)]
        public void ToDouble_Nullable_ShouldConvertNullableUintToNullableDouble(uint? value, double? expected)
        {
            value.ToDouble().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123U, 123.0)]
        [InlineData(0U, 0.0)]
        public void ToDecimal_ShouldConvertUintToDecimal(uint value, decimal expected)
        {
            value.ToDecimal().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123U, 123.0)]
        [InlineData(null, null)]
        public void ToDecimal_Nullable_ShouldConvertNullableUintToNullableDecimal(uint? value, double? expected)
        {
            decimal? d = null;

            if (expected.HasValue)
            {
                d = (decimal)expected.Value;
            }

            value.ToDecimal().ShouldBe(d);
        }

        [Theory]
        [InlineData(123U, 123UL)]
        [InlineData(0U, 0UL)]
        public void ToULong_ShouldConvertUintToULong(uint value, ulong expected)
        {
            value.ToULong().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123U, 123UL)]
        [InlineData(null, null)]
        public void ToULong_Nullable_ShouldConvertNullableUintToNullableULong(uint? value, ulong? expected)
        {
            value.ToULong().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123U, (ushort)123)]
        [InlineData(0U, (ushort)0)]
        public void ToUShort_ShouldConvertUintToUShort(uint value, ushort expected)
        {
            value.ToUShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123U, (ushort)123)]
        [InlineData(null, null)]
        public void ToUShort_Nullable_ShouldConvertNullableUintToNullableUShort(uint? value, ushort? expected)
        {
            value.ToUShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(1U, true)]
        [InlineData(0U, false)]
        public void ToBool_ShouldConvertUintToBool(uint value, bool expected)
        {
            value.ToBool().ShouldBe(expected);
        }

        [Theory]
        [InlineData(1U, true)]
        [InlineData(0U, false)]
        [InlineData(null, null)]
        public void ToBool_Nullable_ShouldConvertNullableUintToNullableBool(uint? value, bool? expected)
        {
            value.ToBool().ShouldBe(expected);
        }
    }
}
