using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record UpdateToolTemplateDto
{
    [JsonPropertyName("details")]
    public object? Details { get; set; }

    [JsonPropertyName("providerDetails")]
    public object? ProviderDetails { get; set; }

    [JsonPropertyName("metadata")]
    public ToolTemplateMetadata? Metadata { get; set; }

    [JsonPropertyName("visibility")]
    public UpdateToolTemplateDtoVisibility? Visibility { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// The name of the template. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provider")]
    public UpdateToolTemplateDtoProvider? Provider { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}