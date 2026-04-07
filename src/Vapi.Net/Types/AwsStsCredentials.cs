using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AwsStsCredentials : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the access key ID for the AWS credential
    /// </summary>
    [JsonPropertyName("AccessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>
    /// This is the expiration date for the AWS credential
    /// </summary>
    [JsonPropertyName("Expiration")]
    public DateTime? Expiration { get; set; }

    /// <summary>
    /// This is the secret access key for the AWS credential
    /// </summary>
    [JsonPropertyName("SecretAccessKey")]
    public string? SecretAccessKey { get; set; }

    /// <summary>
    /// This is the session token for the AWS credential
    /// </summary>
    [JsonPropertyName("SessionToken")]
    public string? SessionToken { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
