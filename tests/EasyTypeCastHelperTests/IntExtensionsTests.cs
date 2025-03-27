using System;
using Xunit;
using Shouldly;
using EasyTypeCastHelper;

namespace EasyTypeCastHelperTests
{
    public class IntExtensionsTests
    {

        [Theory]
        [InlineData(123, (ushort)123)]
        [InlineData(0, (ushort)0)]
        public void ToUShort_ShouldConvertIntToUShort(int value, ushort expected)
        {
            value.ToUShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123, (ushort)123)]
        [InlineData(null, null)]
        public void ToUShort_Nullable_ShouldConvertNullableIntToNullableUShort(int? value, ushort? expected)
        {
            value.ToUShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123, 123U)]
        [InlineData(0L, 0U)]
        public void ToUInt_ShouldConvertLongToUInt(int value, uint expected)
        {
            value.ToUInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123, 123U)]
        [InlineData(null, null)]
        public void ToUInt_Nullable_ShouldConvertNullableLongToNullableUInt(int? value, uint? expected)
        {
            value.ToUInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123, 123UL)]
        [InlineData(0, 0UL)]
        public void ToULong_ShouldConvertLongToULong(int value, ulong expected)
        {
            value.ToULong().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123, 123UL)]
        [InlineData(null, null)]
        public void ToULong_Nullable_ShouldConvertNullableLongToNullableULong(int? value, ulong? expected)
        {
            value.ToULong().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123, (short)123)]
        [InlineData(0, (short)0)]
        public void ToShort_ShouldConvertLongToShort(int value, short expected)
        {
            value.ToShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123, (short)123)]
        [InlineData(null, null)]
        public void ToShort_Nullable_ShouldConvertNullableLongToNullableShort(int? value, short? expected)
        {
            value.ToShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123, 123.0)]
        [InlineData(0, 0.0)]
        public void ToDouble_ShouldConvertIntToDouble(int value, double expected)
        {
            value.ToDouble().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123, 123.0)]
        [InlineData(null, null)]
        public void ToDouble_Nullable_ShouldConvertNullableIntToNullableDouble(int? value, double? expected)
        {
            value.ToDouble().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123, 123.0)]
        [InlineData(0, 0.0)]
        public void ToDecimal_ShouldConvertIntToDecimal(int value, decimal expected)
        {
            value.ToDecimal().ShouldBe(expected);
        }

        [Theory]
        [InlineData(0, 0.0)]
        [InlineData(123, 123.0)]
        [InlineData(null, null)]
        public void ToDecimal_Nullable_ShouldConvertNullableIntToNullableDecimal(int? value, double? expected)
        {
            value.ToDecimal().ShouldBe(expected.HasValue ? Convert.ToDecimal(expected) : null);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        public void ToBool_ShouldConvertIntToBool(int value, bool expected)
        {
            value.ToBool().ShouldBe(expected);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(null, null)]
        public void ToBool_Nullable_ShouldConvertNullableIntToNullableBool(int? value, bool? expected)
        {
            value.ToBool().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123, 123L)]
        [InlineData(0, 0L)]
        public void ToLong_ShouldConvertIntToLong(int value, long expected)
        {
            value.ToLong().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123, 123L)]
        [InlineData(null, null)]
        public void ToLong_Nullable_ShouldConvertNullableIntToNullableLong(int? value, long? expected)
        {
            value.ToLong().ShouldBe(expected);
        }
    }
}
