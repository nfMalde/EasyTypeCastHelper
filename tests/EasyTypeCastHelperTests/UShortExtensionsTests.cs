using EasyTypeCastHelper;
using Shouldly;

namespace EasyTypeCastHelperTests
{
    public class UShortExtensionsTests
    {
        [Theory]
        [InlineData((ushort)123, 123L)]
        [InlineData((ushort)0, 0L)]
        public void ToLong_ShouldConvertUShortToLong(ushort value, long expected)
        {
            value.ToLong().ShouldBe(expected);
        }

        [Theory]
        [InlineData((ushort)123, 123L)]
        [InlineData(null, null)]
        public void ToLong_Nullable_ShouldConvertNullableUShortToNullableLong(ushort? value, long? expected)
        {
            value.ToLong().ShouldBe(expected);
        }

        [Theory]
        [InlineData((ushort)123, 123.0)]
        [InlineData((ushort)0, 0.0)]
        public void ToDouble_ShouldConvertUShortToDouble(ushort value, double expected)
        {
            value.ToDouble().ShouldBe(expected);
        }

        [Theory]
        [InlineData((ushort)123, 123.0)]
        [InlineData(null, null)]
        public void ToDouble_Nullable_ShouldConvertNullableUShortToNullableDouble(ushort? value, double? expected)
        {
            value.ToDouble().ShouldBe(expected);
        }

        [Theory]
        [InlineData((ushort)123, 123.0)]
        [InlineData((ushort)0, 0.0)]
        public void ToDecimal_ShouldConvertUShortToDecimal(ushort value, decimal expected)
        {
            value.ToDecimal().ShouldBe(expected);
        }

        [Theory]
        [InlineData((ushort)123, 123.0)]
        [InlineData(null, null)]
        public void ToDecimal_Nullable_ShouldConvertNullableUShortToNullableDecimal(ushort? value, double? expected)
        {
            decimal? d = null;

            if (expected.HasValue)
            {
                d = (decimal)expected.Value;
            }

            value.ToDecimal().ShouldBe(d);
        }

        [Theory]
        [InlineData((ushort)123, 123)]
        [InlineData((ushort)0, 0)]
        public void ToInt_ShouldConvertUShortToInt(ushort value, int expected)
        {
            value.ToInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData((ushort)123, 123)]
        [InlineData(null, null)]
        public void ToInt_Nullable_ShouldConvertNullableUShortToNullableInt(ushort? value, int? expected)
        {
            value.ToInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData((ushort)123, (short)123)]
        [InlineData((ushort)0, (short)0)]
        public void ToShort_ShouldConvertUShortToShort(ushort value, short expected)
        {
            value.ToShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData((ushort)123, (short)123)]
        [InlineData(null, null)]
        public void ToShort_Nullable_ShouldConvertNullableUShortToNullableShort(ushort? value, short? expected)
        {
            value.ToShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData((ushort)123, (ushort)123)]
        [InlineData((ushort)0, (ushort)0)]
        public void ToUShort_ShouldConvertUShortToUShort(ushort value, ushort expected)
        {
            value.ToUShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData((ushort)123, (ushort)123)]
        [InlineData(null, null)]
        public void ToUShort_Nullable_ShouldConvertNullableUShortToNullableUShort(ushort? value, ushort? expected)
        {
            value.ToUShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData((ushort)1, true)]
        [InlineData((ushort)0, false)]
        public void ToBool_ShouldConvertUShortToBool(ushort value, bool expected)
        {
            value.ToBool().ShouldBe(expected);
        }

        [Theory]
        [InlineData((ushort)1, true)]
        [InlineData((ushort)0, false)]
        [InlineData(null, null)]
        public void ToBool_Nullable_ShouldConvertNullableUShortToNullableBool(ushort? value, bool? expected)
        {
            value.ToBool().ShouldBe(expected);
        }
    }
}
