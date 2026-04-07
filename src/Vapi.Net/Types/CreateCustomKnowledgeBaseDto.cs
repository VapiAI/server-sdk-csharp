using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateCustomKnowledgeBaseDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This knowledge base is bring your own knowledge base implementation.
    /// </summary>
    [JsonPropertyName("provider")]
    public required CreateCustomKnowledgeBaseDtoProvider Provider { get; set; }

    /// <summary>
    /// This is where the knowledge base request will be sent.
    ///
    /// Request Example:
    ///
    /// POST https://{server.url}
    /// Content-Type: application/json
    ///
    /// {
    ///   "messsage": {
    ///     "type": "knowledge-base-request",
    ///     "messages": [
    ///       {
    ///         "role": "user",
    ///         "content": "Why is ocean blue?"
    ///       }
    ///     ],
    ///     ...other metadata about the call...
    ///   }
    /// }
    ///
    /// Response Expected:
    /// ```
    /// {
    ///   "message": {
    ///      "role": "assistant",
    ///      "content": "The ocean is blue because water absorbs everything but blue.",
    ///   }, // YOU CAN RETURN THE EXACT RESPONSE TO SPEAK
    ///   "documents": [
    ///     {
    ///       "content": "The ocean is blue primarily because water absorbs colors in the red part of the light spectrum and scatters the blue light, making it more visible to our eyes.",
    ///       "similarity": 1
    ///     },
    ///     {
    ///       "content": "Blue light is scattered more by the water molecules than other colors, enhancing the blue appearance of the ocean.",
    ///       "similarity": .5
    ///     }
    ///   ] // OR, YOU CAN RETURN AN ARRAY OF DOCUMENTS THAT WILL BE SENT TO THE MODEL
    /// }
    /// ```
    /// </summary>
    [JsonPropertyName("server")]
    public required Server Server { get; set; }

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
