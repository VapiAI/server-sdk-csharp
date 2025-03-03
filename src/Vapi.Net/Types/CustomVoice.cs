using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CustomVoice
{
    /// <summary>
    /// This is the plan for chunking the model output before it is sent to the voice provider.
    /// </summary>
    [JsonPropertyName("chunkPlan")]
    public ChunkPlan? ChunkPlan { get; set; }

    /// <summary>
    /// This is where the voice request will be sent.
    ///
    /// Request Example:
    ///
    /// POST https://{server.url}
    /// Content-Type: application/json
    ///
    /// {
    ///   "message": {
    ///     "type": "voice-request",
    ///     "text": "Hello, world!",
    ///     "sampleRate": 24000,
    ///     ...other metadata about the call...
    ///   }
    /// }
    ///
    /// Response Expected: 1-channel 16-bit raw PCM audio at the sample rate specified in the request. Here is how the response will be piped to the transport:
    /// ```
    /// response.on('data', (chunk: Buffer) =&gt; {
    ///   outputStream.write(chunk);
    /// });
    /// ```
    /// </summary>
    [JsonPropertyName("server")]
    public required Server Server { get; set; }

    /// <summary>
    /// This is the plan for voice provider fallbacks in the event that the primary voice provider fails.
    /// </summary>
    [JsonPropertyName("fallbackPlan")]
    public FallbackPlan? FallbackPlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
