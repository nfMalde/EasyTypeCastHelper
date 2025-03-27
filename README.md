[![Nuget](https://img.shields.io/nuget/v/EasyTypeCastHelper?style=flat-square)](https://www.nuget.org/packages/EasyTypeCastHelper/) 
 [![Downloads](https://img.shields.io/nuget/dt/EasyTypeCastHelper?style=flat-square)](https://www.nuget.org/packages/EasyTypeCastHelper/)
 [![Paypal Donate](https://www.paypalobjects.com/en_US/i/btn/btn_donate_SM.gif)](https://www.paypal.com/donate/?hosted_button_id=SVZHLRTQ6H4VL)
[![Pull Request Check](https://github.com/nfMalde/EasyTypeCastHelper/actions/workflows/pr.yml/badge.svg)](https://github.com/nfMalde/EasyTypeCastHelper/actions/workflows/pr.yml)
# EasyTypeCastHelper

EasyTypeCastHelper is a lightweight utility library designed to simplify type casting in your projects. It provides a set of helper functions to safely and efficiently cast between different types in C#.

## Features

- Safe type casting with null checks.
- Support for common type conversions.
- Easy-to-use API for developers.

## Installation

Add the nuget package to your project by

```bash
dotnet add package EasyTypeCastHelper
```

or via nuget package console


```powershell
NuGet\Install-Package EasyTypeCastHelper
```

## Usage

### Example

```csharp
using EasyTypeCastHelper;

class Program
{
    static void Main(string[] args)
    {
        string value = "123";
        int result = value.ToInt(value);
        Console.WriteLine(result); // Output: 123

        // JSON Helper

        Test o = new() { Test = true };

        string json = o.ToJson();

        Console.WriteLine(json); // Output {"Test": true}

        Test t2 = json.DeserializeFromJson<Test>();
        


    }

    private class Test {
        public bool Test {get; set;}
    }
}
```

## API Documentation
(Note: Docs are generated by AI using the XML Doc comments from the source code) 

### `DecimalExtensions`

The `DecimalExtensions` class provides extension methods for converting `decimal` and `decimal?` values to various types.

#### Methods

- **`ToBool(this decimal value)`**
  Converts a `decimal` value to a `bool`.

- **`ToNullableBool(this decimal? value, bool? defaultValue = null)`**
  Converts a nullable `decimal` value to a nullable `bool`. Returns the `defaultValue` if the input is `null`.

- **`ToUInt(this decimal value)`**
  Converts a `decimal` value to an `uint`.

- **`ToUInt(this decimal? value, uint? defaultValue = null)`**
  Converts a nullable `decimal` value to a nullable `uint`. Returns the `defaultValue` if the input is `null`.

- **`ToUShort(this decimal value)`**
  Converts a `decimal` value to a `ushort`.

- **`ToUShort(this decimal? value, ushort? defaultValue = null)`**
  Converts a nullable `decimal` value to a nullable `ushort`. Returns the `defaultValue` if the input is `null`.

- **`ToShort(this decimal value)`**
  Converts a `decimal` value to a `short`.

- **`ToShort(this decimal? value, short? defaultValue = null)`**
  Converts a nullable `decimal` value to a nullable `short`. Returns the `defaultValue` if the input is `null`.

- **`ToULong(this decimal value)`**
  Converts a `decimal` value to a `ulong`.

- **`ToULong(this decimal? value, ulong? defaultValue = null)`**
  Converts a nullable `decimal` value to a nullable `ulong`. Returns the `defaultValue` if the input is `null`.

- **`ToInt(this decimal value)`**
  Converts a `decimal` value to an `int`.

- **`ToInt(this decimal? value, int? defaultValue = null)`**
  Converts a nullable `decimal` value to a nullable `int`. Returns the `defaultValue` if the input is `null`.

- **`ToLong(this decimal value)`**
  Converts a `decimal` value to a `long`.

- **`ToLong(this decimal? value, long? defaultValue = null)`**
  Converts a nullable `decimal` value to a nullable `long`. Returns the `defaultValue` if the input is `null`.

- **`ToFloat(this decimal value)`**
  Converts a `decimal` value to a `float`.

- **`ToFloat(this decimal? value, float? defaultValue = null)`**
  Converts a nullable `decimal` value to a nullable `float`. Returns the `defaultValue` if the input is `null`.

- **`ToDouble(this decimal value)`**
  Converts a `decimal` value to a `double`.

- **`ToDouble(this decimal? value, double? defaultValue = null)`**
  Converts a nullable `decimal` value to a nullable `double`. Returns the

---

### `DoubleExtensions`
The `DoubleExtensions` class provides extension methods for converting `double` and `double?` values to various types.

#### Methods

- **`ToUInt(this double value)`**
  Converts a `double` value to a `uint`.

- **`ToUInt(this double? value, uint? defaultValue = null)`**
  Converts a nullable `double` value to a nullable `uint`. Returns the `defaultValue` if the input is `null`.

- **`ToUShort(this double value)`**
  Converts a `double` value to a `ushort`.

- **`ToUShort(this double? value, ushort? defaultValue = null)`**
  Converts a nullable `double` value to a nullable `ushort`. Returns the `defaultValue` if the input is `null`.

- **`ToShort(this double value)`**
  Converts a `double` value to a `short`.

- **`ToShort(this double? value, short? defaultValue = null)`**
  Converts a nullable `double` value to a nullable `short`. Returns the `defaultValue` if the input is `null`.

- **`ToULong(this double value)`**
  Converts a `double` value to a `ulong`.

- **`ToULong(this double? value, ulong? defaultValue = null)`**
  Converts a nullable `double` value to a nullable `ulong`. Returns the `defaultValue` if the input is `null`.

- **`ToInt(this double value)`**
  Converts a `double` value to an `int`.

- **`ToInt(this double? value, int? defaultValue = null)`**
  Converts a nullable `double` value to a nullable `int`. Returns the `defaultValue` if the input is `null`.

- **`ToLong(this double value)`**
  Converts a `double` value to a `long`.

- **`ToLong(this double? value, long? defaultValue = null)`**
  Converts a nullable `double` value to a nullable `long`. Returns the `defaultValue` if the input is `null`.

- **`ToFloat(this double value)`**
  Converts a `double` value to a `float`.

- **`ToFloat(this double? value, float? defaultValue = null)`**
  Converts a nullable `double` value to a nullable `float`. Returns the `defaultValue` if the input is `null`.

- **`ToDecimal(this double value)`**
  Converts a `double` value to a `decimal`.

- **`ToDecimal(this double? value, decimal? defaultValue = null)`**
  Converts a nullable `double` value to a nullable `decimal`. Returns the `defaultValue` if the input is `null`.

- **`ToTimeSpanFromSeconds(this double value)`**
  Converts a `double` value to a `TimeSpan` representing seconds.

- **`ToTimeSpanFromSeconds(this double? value, TimeSpan? defaultValue = null)`**
  Converts a nullable `double` value to a nullable `TimeSpan` representing seconds. Returns the `defaultValue` if the input is `null`.

- **`ToTimeSpanFromMinutes(this double value)`**
  Converts a `double` value to a `TimeSpan` representing minutes.

- **`ToTimeSpanFromMinutes(this double? value, TimeSpan? defaultValue = null)`**
  Converts a nullable `double` value to a nullable `TimeSpan` representing minutes. Returns the `defaultValue` if the input is `null`.

- **`ToTimeSpanFromHours(this double value)`**
  Converts a `double` value to a `TimeSpan` representing hours.

- **`ToTimeSpanFromHours(this double? value, TimeSpan? defaultValue = null)`**
  Converts a nullable `double` value to a nullable `TimeSpan` representing hours. Returns the `defaultValue` if the input is `null`.

- **`ToTimeSpanFromDays(this double value)`**
  Converts a `double` value to a `TimeSpan` representing days.

- **`ToTimeSpanFromDays(this double? value, TimeSpan? defaultValue = null)`**
  Converts a nullable `double` value to a nullable `TimeSpan` representing days. Returns the `defaultValue` if the input is `null`.

- **`ToTimeSpanFromMilliseconds(this double value)`**
  Converts a `double` value to a `TimeSpan` representing milliseconds.

- **`ToTimeSpanFromMilliseconds(this double? value, TimeSpan? defaultValue = null)`**
  Converts a nullable `double` value to a nullable `TimeSpan` representing milliseconds. Returns the `defaultValue` if the input is `null`.

- **`ToDateTimeFromUnixTimestamp(this double value)`**
  Converts a `double` value representing a Unix timestamp (in seconds) to a `DateTime`.

- **`ToDateTimeFromUnixTimestamp(this double? value, DateTime? defaultValue = null)`**
  Converts a nullable `double` value representing a Unix timestamp (in seconds) to a nullable `DateTime`. Returns the `defaultValue` if the input is `null`.

- **`ToDateTimeFromUnixTimestampMilliseconds(this double value)`**
  Converts a `double` value representing a Unix timestamp (in milliseconds) to a `DateTime`.

- **`ToDateTimeFromUnixTimestampMilliseconds(this double? value, DateTime? defaultValue = null)`**
  Converts a nullable `double` value representing a Unix timestamp (in milliseconds) to a nullable `DateTime`. Returns the `defaultValue` if the input is `null`.

- **`ToDateTimeFromTicks(this double value)`**
  Converts a `double` value representing ticks to a `DateTime`.

- **`ToDateTimeFromTicks(this double? value, DateTime? defaultValue = null)`**
  Converts a nullable `double` value representing ticks to a nullable `DateTime`. Returns the `defaultValue` if the input is `null`.

---

### `IntExtensions`

The `IntExtensions` class provides extension methods for converting `int` and `int?` values to various types.

#### Methods

- **`ToUInt(this int value)`**
  Converts an `int` value to a `uint`.

- **`ToUInt(this int? value, uint? defaultValue = null)`**
  Converts a nullable `int` value to a nullable `uint`. Returns the `defaultValue` if the input is `null`.

- **`ToULong(this int value)`**
  Converts an `int` value to a `ulong`.

- **`ToULong(this int? value, ulong? defaultValue = null)`**
  Converts a nullable `int` value to a nullable `ulong`. Returns the `defaultValue` if the input is `null`.

- **`ToShort(this int value)`**
  Converts an `int` value to a `short`.

- **`ToShort(this int? value, short? defaultValue = null)`**
  Converts a nullable `int` value to a nullable `short`. Returns the `defaultValue` if the input is `null`.

- **`ToUShort(this int value)`**
  Converts an `int` value to a `ushort`.

- **`ToUShort(this int? value, ushort? defaultValue = null)`**
  Converts a nullable `int` value to a nullable `ushort`. Returns the `defaultValue` if the input is `null`.

- **`ToLong(this int value)`**
  Converts an `int` value to a `long`.

- **`ToLong(this int? value, long? defaultValue = null)`**
  Converts a nullable `int` value to a nullable `long`. Returns the `defaultValue` if the input is `null`.

- **`ToDouble(this int value)`**
  Converts an `int` value to a `double`.

- **`ToDouble(this int? value, double? defaultValue = null)`**
  Converts a nullable `int` value to a nullable `double`. Returns the `defaultValue` if the input is `null`.

- **`ToDecimal(this int value)`**
  Converts an `int` value to a `decimal`.

- **`ToDecimal(this int? value, decimal? defaultValue = null)`**
  Converts a nullable `int` value to a nullable `decimal`. Returns the `defaultValue` if the input is `null`.

- **`ToBool(this int value)`**
  Converts an `int` value to a `bool`. Returns `true` if the value is not zero, otherwise `false`.

- **`ToBool(this int? value, bool? defaultValue = null)`**
  Converts a nullable `int` value to a nullable `bool`. Returns `true` if the value is not zero, `false` if it is zero, or the `defaultValue` if the input is `null`.

- **`ToTimeSpanFromSeconds(this int value)`**
  Converts an `int` value to a `TimeSpan` representing seconds.

- **`ToTimeSpanFromSeconds(this int? value, TimeSpan? defaultValue = null)`**
  Converts a nullable `int` value to a nullable `TimeSpan` representing seconds. Returns the `defaultValue` if the input is `null`.

- **`ToTimeSpanFromMinutes(this int value)`**
  Converts an `int` value to a `TimeSpan` representing minutes.

- **`ToTimeSpanFromMinutes(this int? value, TimeSpan? defaultValue = null)`**
  Converts a nullable `int` value to a nullable `TimeSpan` representing minutes. Returns the `defaultValue` if the input is `null`.

- **`ToTimeSpanFromHours(this int value)`**
  Converts an `int` value to a `TimeSpan` representing hours.

- **`ToTimeSpanFromHours(this int? value, TimeSpan? defaultValue = null)`**
  Converts a nullable `int` value to a nullable `TimeSpan` representing hours. Returns the `defaultValue` if the input is `null`.

- **`ToTimeSpanFromDays(this int value)`**
  Converts an `int` value to a `TimeSpan` representing days.

- **`ToTimeSpanFromDays(this int? value, TimeSpan? defaultValue = null)`**
  Converts a nullable `int` value to a nullable `TimeSpan` representing days. Returns the `defaultValue` if the input is `null`.

- **`ToDateTimeFromUnixTimestamp(this int value)`**
  Converts an `int` value representing a Unix timestamp (in seconds) to a `DateTime`.

- **`ToDateTimeFromUnixTimestamp(this int? value, DateTime? defaultValue = null)`**
  Converts a nullable `int` value representing a Unix timestamp (in seconds) to a nullable `DateTime`. Returns the `defaultValue` if the input is `null`.

- **`ToDateTimeFromUnixTimestampMilliseconds(this int value)`**
  Converts an `int` value representing a Unix timestamp (in milliseconds) to a `DateTime`.

- **`ToDateTimeFromUnixTimestampMilliseconds(this int? value, DateTime? defaultValue = null)`**
  Converts a nullable `int` value representing a Unix timestamp (in milliseconds) to a nullable `DateTime`. Returns the `defaultValue` if the input is `null`.

- **`ToDateTimeFromTicks(this int value)`**
  Converts an `int` value representing ticks to a `DateTime`.

- **`ToDateTimeFromTicks(this int? value, DateTime? defaultValue = null)`**
  Converts a nullable `int` value representing ticks to a nullable `DateTime`. Returns the `defaultValue` if the input is `null`.

---

### `LongExtensions`

The `LongExtensions` class provides extension methods for converting `long` and `long?` values to various types.

#### Methods

- **`ToUInt(this long value)`**
  Converts a `long` value to a `uint`.

- **`ToUInt(this long? value, uint? defaultValue = null)`**
  Converts a nullable `long` value to a nullable `uint`. Returns the `defaultValue` if the input is `null`.

- **`ToULong(this long value)`**
  Converts a `long` value to a `ulong`.

- **`ToULong(this long? value, ulong? defaultValue = null)`**
  Converts a nullable `long` value to a nullable `ulong`. Returns the `defaultValue` if the input is `null`.

- **`ToShort(this long value)`**
  Converts a `long` value to a `short`.

- **`ToShort(this long? value, short? defaultValue = null)`**
  Converts a nullable `long` value to a nullable `short`. Returns the `defaultValue` if the input is `null`.

- **`ToUShort(this long value)`**
  Converts a `long` value to a `ushort`.

- **`ToUShort(this long? value, ushort? defaultValue = null)`**
  Converts a nullable `long` value to a nullable `ushort`. Returns the `defaultValue` if the input is `null`.

- **`ToInt(this long value)`**
  Converts a `long` value to an `int`.

- **`ToInt(this long? value, int? defaultValue = null)`**
  Converts a nullable `long` value to a nullable `int`. Returns the `defaultValue` if the input is `null`.

- **`ToDouble(this long value)`**
  Converts a `long` value to a `double`.

- **`ToDouble(this long? value, double? defaultValue = null)`**
  Converts a nullable `long` value to a nullable `double`. Returns the `defaultValue` if the input is `null`.

- **`ToFloat(this long value)`**
  Converts a `long` value to a `float`.

- **`ToFloat(this long? value, float? defaultValue = null)`**
  Converts a nullable `long` value to a nullable `float`. Returns the `defaultValue` if the input is `null`.

- **`ToDecimal(this long value)`**
  Converts a `long` value to a `decimal`.

- **`ToDecimal(this long? value, decimal? defaultValue = null)`**
  Converts a nullable `long` value to a nullable `decimal`. Returns the `defaultValue` if the input is `null`.

- **`ToTimeSpanFromSeconds(this long value)`**
  Converts a `long` value to a `TimeSpan` representing seconds.

- **`ToTimeSpanFromSeconds(this long? value, TimeSpan? defaultValue = null)`**
  Converts a nullable `long` value to a nullable `TimeSpan` representing seconds. Returns the `defaultValue` if the input is `null`.

- **`ToTimeSpanFromMinutes(this long value)`**
  Converts a `long` value to a `TimeSpan` representing minutes.

- **`ToTimeSpanFromMinutes(this long? value, TimeSpan? defaultValue = null)`**
  Converts a nullable `long` value to a nullable `TimeSpan` representing minutes. Returns the `defaultValue` if the input is `null`.

- **`ToTimeSpanFromHours(this long value)`**
  Converts a `long` value to a `TimeSpan` representing hours.

- **`ToTimeSpanFromHours(this long? value, TimeSpan? defaultValue = null)`**
  Converts a nullable `long` value to a nullable `TimeSpan` representing hours. Returns the `defaultValue` if the input is `null`.

- **`ToTimeSpanFromDays(this long value)`**
  Converts a `long` value to a `TimeSpan` representing days.

- **`ToTimeSpanFromDays(this long? value, TimeSpan? defaultValue = null)`**
  Converts a nullable `long` value to a nullable `TimeSpan` representing days. Returns the `defaultValue` if the input is `null`.

- **`ToDateTimeFromUnixTimestamp(this long value)`**
  Converts a `long` value representing a Unix timestamp (in seconds) to a `DateTime`.

- **`ToDateTimeFromUnixTimestamp(this long? value, DateTime? defaultValue = null)`**
  Converts a nullable `long` value representing a Unix timestamp (in seconds) to a nullable `DateTime`. Returns the `defaultValue` if the input is `null`.

- **`ToDateTimeFromUnixTimestampMilliseconds(this long value)`**
  Converts a `long` value representing a Unix timestamp (in milliseconds) to a `DateTime`.

- **`ToDateTimeFromUnixTimestampMilliseconds(this long? value, DateTime? defaultValue = null)`**
  Converts a nullable `long` value representing a Unix timestamp (in milliseconds) to a nullable `DateTime`. Returns the `defaultValue` if the input is `null`.

- **`ToDateTimeFromTicks(this long value)`**
  Converts a `long` value representing ticks to a `DateTime`.

- **`ToDateTimeFromTicks(this long? value, DateTime? defaultValue = null)`**
  Converts a nullable `long` value representing ticks to a nullable `DateTime`. Returns the `defaultValue` if the input is `null`.

---

### `ObjectExtensions`

The `ObjectExtensions` class provides extension methods for object serialization.

#### Methods

- **`ToNullableJson(this object value, JsonSerializerOptions? options = null)`**
  Serializes the specified object to a JSON string. If the object is `null`, it returns `null`.

  - **Parameters**:
    - `value`: The object to serialize.
    - `options`: Optional JSON serializer options.
  - **Returns**: A JSON string representation of the object, or `null` if the object is `null`.

- **`ToJson(this object? value, JsonSerializerOptions? options = null)`**
  Serializes the specified object to a JSON string if it is not `null`.

  - **Parameters**:
    - `value`: The object to serialize, or `null`.
    - `options`: Optional JSON serializer options.
  - **Returns**: A JSON string representation of the object, or `null` if the object is `null`.

---

### `ShortExtensions`

The `ShortExtensions` class provides extension methods for converting `short` and `short?` values to various types.

#### Methods

- **`ToLong(this short value)`**
  Converts a `short` value to a `long`.

- **`ToLong(this short? value, long? defaultValue = null)`**
  Converts a nullable `short` value to a nullable `long`. Returns the `defaultValue` if the input is `null`.

- **`ToDouble(this short value)`**
  Converts a `short` value to a `double`.

- **`ToDouble(this short? value, double? defaultValue = null)`**
  Converts a nullable `short` value to a nullable `double`. Returns the `defaultValue` if the input is `null`.

- **`ToDecimal(this short value)`**
  Converts a `short` value to a `decimal`.

- **`ToDecimal(this short? value, decimal? defaultValue = null)`**
  Converts a nullable `short` value to a nullable `decimal`. Returns the `defaultValue` if the input is `null`.

- **`ToInt(this short value)`**
  Converts a `short` value to an `int`.

- **`ToInt(this short? value, int? defaultValue = null)`**
  Converts a nullable `short` value to a nullable `int`. Returns the `defaultValue` if the input is `null`.

- **`ToShort(this short value)`**
  Converts a `short` value to a `short`.

- **`ToShort(this short? value, short? defaultValue = null)`**
  Converts a nullable `short` value to a nullable `short`. Returns the `defaultValue` if the input is `null`.

- **`ToUShort(this short value)`**
  Converts a `short` value to a `ushort`.

- **`ToUShort(this short? value, ushort? defaultValue = null)`**
  Converts a nullable `short` value to a nullable `ushort`. Returns the `defaultValue` if the input is `null`.

- **`ToBool(this short value)`**
  Converts a `short` value to a `bool`.

- **`ToBool(this short? value, bool? defaultValue = null)`**
  Converts a nullable `short` value to a nullable `bool`. Returns the `defaultValue` if the input is `null`.


---

### `StringExtensions`

The `StringExtensions` class provides extension methods for converting strings to various types.

#### Methods

- **`ToInt(this string? value, int defaultValue = 0)`**
  Converts the string to an integer. Returns the `defaultValue` if the conversion fails.

- **`ToNullableInt(this string? value)`**
  Converts the string to a nullable integer. Returns `null` if the conversion fails.

- **`ToDouble(this string? value, double defaultValue = 0.0, NumberStyles numberStyles = NumberStyles.Any, CultureInfo? cultureInfo = null)`**
  Converts the string to a double. Returns the `defaultValue` if the conversion fails.

- **`ToNullableDouble(this string? value, NumberStyles numberStyles = NumberStyles.Any, CultureInfo? cultureInfo = null)`**
  Converts the string to a nullable double. Returns `null` if the conversion fails.

- **`ToBool(this string? value, bool defaultValue = false)`**
  Converts the string to a boolean. Returns the `defaultValue` if the conversion fails.

- **`ToNullableBool(this string? value)`**
  Converts the string to a nullable boolean. Returns `null` if the conversion fails.

- **`ToDateTime(this string? value, DateTime defaultValue, DateTimeStyles dateTimeStyles = DateTimeStyles.None, CultureInfo? cultureInfo = null)`**
  Converts the string to a `DateTime`. Returns the `defaultValue` if the conversion fails.

- **`ToNullableDateTime(this string? value, DateTimeStyles dateTimeStyles = DateTimeStyles.None, CultureInfo? cultureInfo = null)`**
  Converts the string to a nullable `DateTime`. Returns `null` if the conversion fails.

- **`ToGuid(this string? value, Guid defaultValue)`**
  Converts the string to a `Guid`. Returns the `defaultValue` if the conversion fails.

- **`ToNullableGuid(this string? value)`**
  Converts the string to a nullable `Guid`. Returns `null` if the conversion fails.

- **`ToEnum<T>(this string? value, T defaultValue) where T : struct`**
  Converts the string to an enum of type `T`. Returns the `defaultValue` if the conversion fails.

- **`ToNullableEnum<T>(this string? value) where T : struct`**
  Converts the string to a nullable enum of type `T`. Returns `null` if the conversion fails.

- **`DeserializeFromJson<T>(this string value, JsonSerializerOptions? options = null)`**
  Deserializes the string from JSON into an object of type `T`.

- **`DeserializeFromNullableJson<T>(this string? value, JsonSerializerOptions? options = null)`**
  Deserializes the string from JSON into an object of type `T`. Returns `default` if the string is `null`.

---

### `UintExtensions`

The `UintExtensions` class provides extension methods for converting `uint` and `uint?` values to various types.

#### Methods

- **`ToInt(this uint value)`**
  Converts a `uint` value to an `int`.

- **`ToInt(this uint? value, int? defaultValue = null)`**
  Converts a nullable `uint` value to a nullable `int`. Returns the `defaultValue` if the input is `null`.

- **`ToShort(this uint value)`**
  Converts a `uint` value to a `short`.

- **`ToShort(this uint? value, short? defaultValue = null)`**
  Converts a nullable `uint` value to a nullable `short`. Returns the `defaultValue` if the input is `null`.

- **`ToLong(this uint value)`**
  Converts a `uint` value to a `long`.

- **`ToLong(this uint? value, long? defaultValue = null)`**
  Converts a nullable `uint` value to a nullable `long`. Returns the `defaultValue` if the input is `null`.

- **`ToDouble(this uint value)`**
  Converts a `uint` value to a `double`.

- **`ToDouble(this uint? value, double? defaultValue = null)`**
  Converts a nullable `uint` value to a nullable `double`. Returns the `defaultValue` if the input is `null`.

- **`ToDecimal(this uint value)`**
  Converts a `uint` value to a `decimal`.

- **`ToDecimal(this uint? value, decimal? defaultValue = null)`**
  Converts a nullable `uint` value to a nullable `decimal`. Returns the `defaultValue` if the input is `null`.

- **`ToULong(this uint value)`**
  Converts a `uint` value to a `ulong`.

- **`ToULong(this uint? value, ulong? defaultValue = null)`**
  Converts a nullable `uint` value to a nullable `ulong`. Returns the `defaultValue` if the input is `null`.

- **`ToUShort(this uint value)`**
  Converts a `uint` value to a `ushort`.

- **`ToUShort(this uint? value, ushort? defaultValue = null)`**
  Converts a nullable `uint` value to a nullable `ushort`. Returns the `defaultValue` if the input is `null`.

- **`ToBool(this uint value)`**
  Converts a `uint` value to a `bool`.

- **`ToBool(this uint? value, bool? defaultValue = null)`**
  Converts a nullable `uint` value to a nullable `bool`. Returns the `defaultValue` if the input is `null`.

---

### `ULongExtensions`

The `ULongExtensions` class provides extension methods for converting `ulong` and `ulong?` values to various types.

#### Methods

- **`ToLong(this ulong value)`**
  Converts a `ulong` value to a `long`.

- **`ToLong(this ulong? value, long? defaultValue = null)`**
  Converts a nullable `ulong` value to a nullable `long`. Returns the `defaultValue` if the input is `null`.

- **`ToDouble(this ulong value)`**
  Converts a `ulong` value to a `double`.

- **`ToDouble(this ulong? value, double? defaultValue = null)`**
  Converts a nullable `ulong` value to a nullable `double`. Returns the `defaultValue` if the input is `null`.

- **`ToDecimal(this ulong value)`**
  Converts a `ulong` value to a `decimal`.

- **`ToDecimal(this ulong? value, decimal? defaultValue = null)`**
  Converts a nullable `ulong` value to a nullable `decimal`. Returns the `defaultValue` if the input is `null`.

- **`ToInt(this ulong value)`**
  Converts a `ulong` value to an `int`.

- **`ToInt(this ulong? value, int? defaultValue = null)`**
  Converts a nullable `ulong` value to a nullable `int`. Returns the `defaultValue` if the input is `null`.

- **`ToShort(this ulong value)`**
  Converts a `ulong` value to a `short`.

- **`ToShort(this ulong? value, short? defaultValue = null)`**
  Converts a nullable `ulong` value to a nullable `short`. Returns the `defaultValue` if the input is `null`.

- **`ToULong(this ulong value)`**
  Converts a `ulong` value to a `ulong`.

- **`ToULong(this ulong? value, ulong? defaultValue = null)`**
  Converts a nullable `ulong` value to a nullable `ulong`. Returns the `defaultValue` if the input is `null`.

- **`ToUShort(this ulong value)`**
  Converts a `ulong` value to a `ushort`.

- **`ToUShort(this ulong? value, ushort? defaultValue = null)`**
  Converts a nullable `ulong` value to a nullable `ushort`. Returns the `defaultValue` if the input is `null`.

- **`ToBool(this ulong value)`**
  Converts a `ulong` value to a `bool`.

- **`ToBool(this ulong? value, bool? defaultValue = null)`**
  Converts a nullable `ulong` value to a nullable `bool`. Returns the `defaultValue` if the input is `null`.

---

### `UShortExtensions`

The `UShortExtensions` class provides extension methods for converting `ushort` and `ushort?` values to various types.

#### Methods

- **`ToLong(this ushort value)`**
  Converts a `ushort` value to a `long`.

- **`ToLong(this ushort? value, long? defaultValue = null)`**
  Converts a nullable `ushort` value to a nullable `long`. Returns the `defaultValue` if the input is `null`.

- **`ToDouble(this ushort value)`**
  Converts a `ushort` value to a `double`.

- **`ToDouble(this ushort? value, double? defaultValue = null)`**
  Converts a nullable `ushort` value to a nullable `double`. Returns the `defaultValue` if the input is `null`.

- **`ToDecimal(this ushort value)`**
  Converts a `ushort` value to a `decimal`.

- **`ToDecimal(this ushort? value, decimal? defaultValue = null)`**
  Converts a nullable `ushort` value to a nullable `decimal`. Returns the `defaultValue` if the input is `null`.

- **`ToInt(this ushort value)`**
  Converts a `ushort` value to an `int`.

- **`ToInt(this ushort? value, int? defaultValue = null)`**
  Converts a nullable `ushort` value to a nullable `int`. Returns the `defaultValue` if the input is `null`.

- **`ToShort(this ushort value)`**
  Converts a `ushort` value to a `short`.

- **`ToShort(this ushort? value, short? defaultValue = null)`**
  Converts a nullable `ushort` value to a nullable `short`. Returns the `defaultValue` if the input is `null`.

- **`ToUShort(this ushort value)`**
  Converts a `ushort` value to a `ushort`.

- **`ToUShort(this ushort? value, ushort? defaultValue = null)`**
  Converts a nullable `ushort` value to a nullable `ushort`. Returns the `defaultValue` if the input is `null`.

- **`ToBool(this ushort value)`**
  Converts a `ushort` value to a `bool`.

- **`ToBool(this ushort? value, bool? defaultValue = null)`**
  Converts a nullable `ushort` value to a nullable `bool`. Returns the `defaultValue` if the input is `null`.

---

## Donate
You like this project? If you dont mind every "tip" is appreciated.

If you like to you can send an paypal donation* via  [![Paypal Donate](https://www.paypalobjects.com/en_US/DK/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/donate/?hosted_button_id=SVZHLRTQ6H4VL)


*Note: Not refund possible.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request. 

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.