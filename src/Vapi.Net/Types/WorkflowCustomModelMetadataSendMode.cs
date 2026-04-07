using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(WorkflowCustomModelMetadataSendModeSerializer))]
public enum WorkflowCustomModelMetadataSendMode
{
    [EnumMember(Value = "off")]
    Off,

    [EnumMember(Value = "variable")]
    Variable,

    [EnumMember(Value = "destructured")]
    Destructured,
}

internal class WorkflowCustomModelMetadataSendModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<WorkflowCustomModelMetadataSendMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        WorkflowCustomModelMetadataSendMode
    > _stringToEnum = new()
    {
        { "off", WorkflowCustomModelMetadataSendMode.Off },
        { "variable", WorkflowCustomModelMetadataSendMode.Variable },
        { "destructured", WorkflowCustomModelMetadataSendMode.Destructured },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        WorkflowCustomModelMetadataSendMode,
        string
    > _enumToString = new()
    {
        { WorkflowCustomModelMetadataSendMode.Off, "off" },
        { WorkflowCustomModelMetadataSendMode.Variable, "variable" },
        { WorkflowCustomModelMetadataSendMode.Destructured, "destructured" },
    };

    public override WorkflowCustomModelMetadataSendMode Read(
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
        WorkflowCustomModelMetadataSendMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override WorkflowCustomModelMetadataSendMode ReadAsPropertyName(
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
        WorkflowCustomModelMetadataSendMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
