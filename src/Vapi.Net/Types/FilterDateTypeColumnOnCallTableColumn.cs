using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FilterDateTypeColumnOnCallTableColumnSerializer))]
public enum FilterDateTypeColumnOnCallTableColumn
{
    [EnumMember(Value = "startedAt")]
    StartedAt,

    [EnumMember(Value = "endedAt")]
    EndedAt,
}

internal class FilterDateTypeColumnOnCallTableColumnSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FilterDateTypeColumnOnCallTableColumn>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FilterDateTypeColumnOnCallTableColumn
    > _stringToEnum = new()
    {
        { "startedAt", FilterDateTypeColumnOnCallTableColumn.StartedAt },
        { "endedAt", FilterDateTypeColumnOnCallTableColumn.EndedAt },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FilterDateTypeColumnOnCallTableColumn,
        string
    > _enumToString = new()
    {
        { FilterDateTypeColumnOnCallTableColumn.StartedAt, "startedAt" },
        { FilterDateTypeColumnOnCallTableColumn.EndedAt, "endedAt" },
    };

    public override FilterDateTypeColumnOnCallTableColumn Read(
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
        FilterDateTypeColumnOnCallTableColumn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FilterDateTypeColumnOnCallTableColumn ReadAsPropertyName(
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
        FilterDateTypeColumnOnCallTableColumn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
