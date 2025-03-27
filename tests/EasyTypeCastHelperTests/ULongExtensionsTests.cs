using EasyTypeCastHelper;
using Shouldly;

namespace EasyTypeCastHelperTests
{
    public class ULongExtensionsTests
    {
        [Theory]
        [InlineData(123UL, 123L)]
        [InlineData(0UL, 0L)]
        public void ToLong_ShouldConvertULongToLong(ulong value, long expected)
        {
            value.ToLong().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123UL, 123L)]
        [InlineData(null, null)]
        public void ToLong_Nullable_ShouldConvertNullableULongToNullableLong(ulong? value, long? expected)
        {
            value.ToLong().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123UL, 123.0)]
        [InlineData(0UL, 0.0)]
        public void ToDouble_ShouldConvertULongToDouble(ulong value, double expected)
        {
            value.ToDouble().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123UL, 123.0)]
        [InlineData(null, null)]
        public void ToDouble_Nullable_ShouldConvertNullableULongToNullableDouble(ulong? value, double? expected)
        {
            value.ToDouble().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123UL, 123.0)]
        [InlineData(0UL, 0.0)]
        public void ToDecimal_ShouldConvertULongToDecimal(ulong value, decimal expected)
        {
            value.ToDecimal().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123UL, 123.0)]
        [InlineData(null, null)]
        public void ToDecimal_Nullable_ShouldConvertNullableULongToNullableDecimal(ulong? value, double? expected)
        {
            value.ToDecimal().ShouldBe(expected.HasValue ? Convert.ToDecimal(expected) : null);
        }

        [Theory]
        [InlineData(123UL, 123)]
        [InlineData(0UL, 0)]
        public void ToInt_ShouldConvertULongToInt(ulong value, int expected)
        {
            value.ToInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123UL, 123)]
        [InlineData(null, null)]
        public void ToInt_Nullable_ShouldConvertNullableULongToNullableInt(ulong? value, int? expected)
        {
            value.ToInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123UL, (short)123)]
        [InlineData(0UL, (short)0)]
        public void ToShort_ShouldConvertULongToShort(ulong value, short expected)
        {
            value.ToShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123UL, (short)123)]
        [InlineData(null, null)]
        public void ToShort_Nullable_ShouldConvertNullableULongToNullableShort(ulong? value, short? expected)
        {
            value.ToShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123UL, 123UL)]
        [InlineData(0UL, 0UL)]
        public void ToULong_ShouldConvertULongToULong(ulong value, ulong expected)
        {
            value.ToULong().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123UL, 123UL)]
        [InlineData(null, null)]
        public void ToULong_Nullable_ShouldConvertNullableULongToNullableULong(ulong? value, ulong? expected)
        {
            value.ToULong().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123UL, (ushort)123)]
        [InlineData(0UL, (ushort)0)]
        public void ToUShort_ShouldConvertULongToUShort(ulong value, ushort expected)
        {
            value.ToUShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123UL, (ushort)123)]
        [InlineData(null, null)]
        public void ToUShort_Nullable_ShouldConvertNullableULongToNullableUShort(ulong? value, ushort? expected)
        {
            value.ToUShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(1UL, true)]
        [InlineData(0UL, false)]
        public void ToBool_ShouldConvertULongToBool(ulong value, bool expected)
        {
            value.ToBool().ShouldBe(expected);
        }

        [Theory]
        [InlineData(1UL, true)]
        [InlineData(0UL, false)]
        [InlineData(null, null)]
        public void ToBool_Nullable_ShouldConvertNullableULongToNullableBool(ulong? value, bool? expected)
        {
            value.ToBool().ShouldBe(expected);
        }
    }
}
