using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(WorkflowAnthropicModelModelSerializer))]
public enum WorkflowAnthropicModelModel
{
    [EnumMember(Value = "claude-3-opus-20240229")]
    Claude3Opus20240229,

    [EnumMember(Value = "claude-3-sonnet-20240229")]
    Claude3Sonnet20240229,

    [EnumMember(Value = "claude-3-haiku-20240307")]
    Claude3Haiku20240307,

    [EnumMember(Value = "claude-3-5-sonnet-20240620")]
    Claude35Sonnet20240620,

    [EnumMember(Value = "claude-3-5-sonnet-20241022")]
    Claude35Sonnet20241022,

    [EnumMember(Value = "claude-3-5-haiku-20241022")]
    Claude35Haiku20241022,

    [EnumMember(Value = "claude-3-7-sonnet-20250219")]
    Claude37Sonnet20250219,

    [EnumMember(Value = "claude-opus-4-20250514")]
    ClaudeOpus420250514,

    [EnumMember(Value = "claude-opus-4-5-20251101")]
    ClaudeOpus4520251101,

    [EnumMember(Value = "claude-opus-4-6")]
    ClaudeOpus46,

    [EnumMember(Value = "claude-sonnet-4-20250514")]
    ClaudeSonnet420250514,

    [EnumMember(Value = "claude-sonnet-4-5-20250929")]
    ClaudeSonnet4520250929,

    [EnumMember(Value = "claude-sonnet-4-6")]
    ClaudeSonnet46,

    [EnumMember(Value = "claude-haiku-4-5-20251001")]
    ClaudeHaiku4520251001,
}

internal class WorkflowAnthropicModelModelSerializer
    : global::System.Text.Json.Serialization.JsonConverter<WorkflowAnthropicModelModel>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        WorkflowAnthropicModelModel
    > _stringToEnum = new()
    {
        { "claude-3-opus-20240229", WorkflowAnthropicModelModel.Claude3Opus20240229 },
        { "claude-3-sonnet-20240229", WorkflowAnthropicModelModel.Claude3Sonnet20240229 },
        { "claude-3-haiku-20240307", WorkflowAnthropicModelModel.Claude3Haiku20240307 },
        { "claude-3-5-sonnet-20240620", WorkflowAnthropicModelModel.Claude35Sonnet20240620 },
        { "claude-3-5-sonnet-20241022", WorkflowAnthropicModelModel.Claude35Sonnet20241022 },
        { "claude-3-5-haiku-20241022", WorkflowAnthropicModelModel.Claude35Haiku20241022 },
        { "claude-3-7-sonnet-20250219", WorkflowAnthropicModelModel.Claude37Sonnet20250219 },
        { "claude-opus-4-20250514", WorkflowAnthropicModelModel.ClaudeOpus420250514 },
        { "claude-opus-4-5-20251101", WorkflowAnthropicModelModel.ClaudeOpus4520251101 },
        { "claude-opus-4-6", WorkflowAnthropicModelModel.ClaudeOpus46 },
        { "claude-sonnet-4-20250514", WorkflowAnthropicModelModel.ClaudeSonnet420250514 },
        { "claude-sonnet-4-5-20250929", WorkflowAnthropicModelModel.ClaudeSonnet4520250929 },
        { "claude-sonnet-4-6", WorkflowAnthropicModelModel.ClaudeSonnet46 },
        { "claude-haiku-4-5-20251001", WorkflowAnthropicModelModel.ClaudeHaiku4520251001 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        WorkflowAnthropicModelModel,
        string
    > _enumToString = new()
    {
        { WorkflowAnthropicModelModel.Claude3Opus20240229, "claude-3-opus-20240229" },
        { WorkflowAnthropicModelModel.Claude3Sonnet20240229, "claude-3-sonnet-20240229" },
        { WorkflowAnthropicModelModel.Claude3Haiku20240307, "claude-3-haiku-20240307" },
        { WorkflowAnthropicModelModel.Claude35Sonnet20240620, "claude-3-5-sonnet-20240620" },
        { WorkflowAnthropicModelModel.Claude35Sonnet20241022, "claude-3-5-sonnet-20241022" },
        { WorkflowAnthropicModelModel.Claude35Haiku20241022, "claude-3-5-haiku-20241022" },
        { WorkflowAnthropicModelModel.Claude37Sonnet20250219, "claude-3-7-sonnet-20250219" },
        { WorkflowAnthropicModelModel.ClaudeOpus420250514, "claude-opus-4-20250514" },
        { WorkflowAnthropicModelModel.ClaudeOpus4520251101, "claude-opus-4-5-20251101" },
        { WorkflowAnthropicModelModel.ClaudeOpus46, "claude-opus-4-6" },
        { WorkflowAnthropicModelModel.ClaudeSonnet420250514, "claude-sonnet-4-20250514" },
        { WorkflowAnthropicModelModel.ClaudeSonnet4520250929, "claude-sonnet-4-5-20250929" },
        { WorkflowAnthropicModelModel.ClaudeSonnet46, "claude-sonnet-4-6" },
        { WorkflowAnthropicModelModel.ClaudeHaiku4520251001, "claude-haiku-4-5-20251001" },
    };

    public override WorkflowAnthropicModelModel Read(
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
        WorkflowAnthropicModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override WorkflowAnthropicModelModel ReadAsPropertyName(
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
        WorkflowAnthropicModelModel value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
