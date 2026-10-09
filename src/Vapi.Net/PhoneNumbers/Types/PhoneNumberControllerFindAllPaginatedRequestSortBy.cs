using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PhoneNumberControllerFindAllPaginatedRequestSortBySerializer))]
public enum PhoneNumberControllerFindAllPaginatedRequestSortBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,
}

internal class PhoneNumberControllerFindAllPaginatedRequestSortBySerializer
    : global::System.Text.Json.Serialization.JsonConverter<PhoneNumberControllerFindAllPaginatedRequestSortBy>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PhoneNumberControllerFindAllPaginatedRequestSortBy
    > _stringToEnum = new()
    {
        { "createdAt", PhoneNumberControllerFindAllPaginatedRequestSortBy.CreatedAt },
        { "duration", PhoneNumberControllerFindAllPaginatedRequestSortBy.Duration },
        { "cost", PhoneNumberControllerFindAllPaginatedRequestSortBy.Cost },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PhoneNumberControllerFindAllPaginatedRequestSortBy,
        string
    > _enumToString = new()
    {
        { PhoneNumberControllerFindAllPaginatedRequestSortBy.CreatedAt, "createdAt" },
        { PhoneNumberControllerFindAllPaginatedRequestSortBy.Duration, "duration" },
        { PhoneNumberControllerFindAllPaginatedRequestSortBy.Cost, "cost" },
    };

    public override PhoneNumberControllerFindAllPaginatedRequestSortBy Read(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception("The JSON value could not be read as a string.");
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void Write(
        global::System.Text.Json.Utf8JsonWriter writer,
        PhoneNumberControllerFindAllPaginatedRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PhoneNumberControllerFindAllPaginatedRequestSortBy ReadAsPropertyName(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception(
                "The JSON property name could not be read as a string."
            );
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void WriteAsPropertyName(
        global::System.Text.Json.Utf8JsonWriter writer,
        PhoneNumberControllerFindAllPaginatedRequestSortBy value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
