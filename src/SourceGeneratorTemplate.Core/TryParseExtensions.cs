namespace SourceGeneratorTemplate.Core;

public static class TryParseExtensions
{
    public static bool TryParseNullableInt32(this string str, out int? value)
    {
        var parsed = int.TryParse(str, out int tempValue);
        value = parsed ? tempValue : null;
        return parsed;
    }
    public static bool TryParseNullableUInt32(this string str, out uint? value)
    {
        var parsed = uint.TryParse(str, out uint tempValue);
        value = parsed ? tempValue : null;
        return parsed;
    }
    public static bool TryParseNullableInt64(this string str, out long? value)
    {
        var parsed = long.TryParse(str, out long tempValue);
        value = parsed ? tempValue : null;
        return parsed;
    }
    public static bool TryParseNullableUInt64(this string str, out ulong? value)
    {
        var parsed = ulong.TryParse(str, out ulong tempValue);
        value = parsed ? tempValue : null;
        return parsed;
    }
}
