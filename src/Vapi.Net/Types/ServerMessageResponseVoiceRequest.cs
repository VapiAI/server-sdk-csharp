using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ServerMessageResponseVoiceRequest
{
    /// <summary>
    /// DO NOT respond to a `voice-request` webhook with this schema of { data }. This schema just exists to document what the response should look like. Follow these instructions:
    ///
    /// Here is what the request will look like:
    ///
    /// POST https://{assistant.voice.server.url}
    /// Content-Type: application/json
    ///
    /// {
    ///   "messsage": {
    ///     "type": "voice-request",
    ///     "text": "Hello, world!",
    ///     "sampleRate": 24000,
    ///     ...other metadata about the call...
    ///   }
    /// }
    ///
    /// The expected response is 1-channel 16-bit raw PCM audio at the sample rate specified in the request. Here is how the response will be piped to the transport:
    /// ```
    /// response.on('data', (chunk: Buffer) =&gt; {
    ///   outputStream.write(chunk);
    /// });
    /// ```
    /// </summary>
    [JsonPropertyName("data")]
    public required string Data { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
