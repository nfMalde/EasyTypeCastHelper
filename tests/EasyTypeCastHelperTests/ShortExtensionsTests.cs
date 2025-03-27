using EasyTypeCastHelper;
using Shouldly;

namespace EasyTypeCastHelperTests
{
    public class ShortExtensionsTests
    {
        [Theory]
        [InlineData((short)123, 123L)]
        [InlineData((short)0, 0L)]
        public void ToLong_ShouldConvertShortToLong(short value, long expected)
        {
            value.ToLong().ShouldBe(expected);
        }

        [Theory]
        [InlineData((short)123, 123L)]
        [InlineData(null, null)]
        public void ToLong_Nullable_ShouldConvertNullableShortToNullableLong(short? value, long? expected)
        {
            value.ToLong().ShouldBe(expected);
        }

        [Theory]
        [InlineData((short)123, 123.0)]
        [InlineData((short)0, 0.0)]
        public void ToDouble_ShouldConvertShortToDouble(short value, double expected)
        {
            value.ToDouble().ShouldBe(expected);
        }

        [Theory]
        [InlineData((short)123, 123.0)]
        [InlineData(null, null)]
        public void ToDouble_Nullable_ShouldConvertNullableShortToNullableDouble(short? value, double? expected)
        {
            value.ToDouble().ShouldBe(expected);
        }

        [Theory]
        [InlineData((short)123, 123.0)]
        [InlineData((short)0, 0.0)]
        public void ToDecimal_ShouldConvertShortToDecimal(short value, decimal expected)
        {
            value.ToDecimal().ShouldBe(expected);
        }

        [Theory]
        [InlineData((short)123, 123.0)]
        [InlineData(null, null)]
        public void ToDecimal_Nullable_ShouldConvertNullableShortToNullableDecimal(short? value, double? expected)
        {
            decimal? d = null;

            if (expected.HasValue)
            {
                d = (decimal)expected.Value;
            }

            value.ToDecimal().ShouldBe(d);
        }

        [Theory]
        [InlineData((short)123, 123)]
        [InlineData((short)0, 0)]
        public void ToInt_ShouldConvertShortToInt(short value, int expected)
        {
            value.ToInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData((short)123, 123)]
        [InlineData(null, null)]
        public void ToInt_Nullable_ShouldConvertNullableShortToNullableInt(short? value, int? expected)
        {
            value.ToInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData((short)123, (short)123)]
        [InlineData((short)0, (short)0)]
        public void ToShort_ShouldConvertShortToShort(short value, short expected)
        {
            value.ToShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData((short)123, (short)123)]
        [InlineData(null, null)]
        public void ToShort_Nullable_ShouldConvertNullableShortToNullableShort(short? value, short? expected)
        {
            value.ToShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData((short)123, (ushort)123)]
        [InlineData((short)0, (ushort)0)]
        public void ToUShort_ShouldConvertShortToUShort(short value, ushort expected)
        {
            value.ToUShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData((short)123, (ushort)123)]
        [InlineData(null, null)]
        public void ToUShort_Nullable_ShouldConvertNullableShortToNullableUShort(short? value, ushort? expected)
        {
            value.ToUShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData((short)1, true)]
        [InlineData((short)0, false)]
        public void ToBool_ShouldConvertShortToBool(short value, bool expected)
        {
            value.ToBool().ShouldBe(expected);
        }

        [Theory]
        [InlineData((short)1, true)]
        [InlineData((short)0, false)]
        [InlineData(null, null)]
        public void ToBool_Nullable_ShouldConvertNullableShortToNullableBool(short? value, bool? expected)
        {
            value.ToBool().ShouldBe(expected);
        }
    }
}
