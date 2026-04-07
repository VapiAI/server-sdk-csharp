using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageWorkflowNodeStartedTypeSerializer))]
public enum ClientMessageWorkflowNodeStartedType
{
    [EnumMember(Value = "workflow.node.started")]
    WorkflowNodeStarted,
}

internal class ClientMessageWorkflowNodeStartedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageWorkflowNodeStartedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageWorkflowNodeStartedType
    > _stringToEnum = new()
    {
        { "workflow.node.started", ClientMessageWorkflowNodeStartedType.WorkflowNodeStarted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageWorkflowNodeStartedType,
        string
    > _enumToString = new()
    {
        { ClientMessageWorkflowNodeStartedType.WorkflowNodeStarted, "workflow.node.started" },
    };

    public override ClientMessageWorkflowNodeStartedType Read(
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
        ClientMessageWorkflowNodeStartedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageWorkflowNodeStartedType ReadAsPropertyName(
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
        ClientMessageWorkflowNodeStartedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
