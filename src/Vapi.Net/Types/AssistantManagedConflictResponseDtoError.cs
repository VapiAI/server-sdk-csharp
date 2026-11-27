using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantManagedConflictResponseDtoErrorSerializer))]
public enum AssistantManagedConflictResponseDtoError
{
    [EnumMember(Value = "assistant_managed_by_vapi_agents")]
    AssistantManagedByVapiAgents,
}

internal class AssistantManagedConflictResponseDtoErrorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantManagedConflictResponseDtoError>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantManagedConflictResponseDtoError
    > _stringToEnum = new()
    {
        {
            "assistant_managed_by_vapi_agents",
            AssistantManagedConflictResponseDtoError.AssistantManagedByVapiAgents
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantManagedConflictResponseDtoError,
        string
    > _enumToString = new()
    {
        {
            AssistantManagedConflictResponseDtoError.AssistantManagedByVapiAgents,
            "assistant_managed_by_vapi_agents"
        },
    };

    public override AssistantManagedConflictResponseDtoError Read(
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
        AssistantManagedConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantManagedConflictResponseDtoError ReadAsPropertyName(
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
        AssistantManagedConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
