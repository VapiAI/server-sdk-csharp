using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record FallbackCustomTranscriber
{
    /// <summary>
    /// This is where the transcription request will be sent.
    ///
    /// Usage:
    /// 1. Vapi will initiate a websocket connection with `server.url`.
    ///
    /// 2. Vapi will send an initial text frame with the sample rate. Format:
    /// ```
    ///     {
    ///       "type": "start",
    ///       "encoding": "linear16", // 16-bit raw PCM format
    ///       "container": "raw",
    ///       "sampleRate": {{sampleRate}},
    ///       "channels": 2 // customer is channel 0, assistant is channel 1
    ///     }
    /// ```
    ///
    /// 3. Vapi will send the audio data in 16-bit raw PCM format as binary frames.
    ///
    /// 4. You can read the messages something like this:
    /// ```
    /// ws.on('message', (data, isBinary) =&gt; {
    ///   if (isBinary) {
    ///     pcmBuffer = Buffer.concat([pcmBuffer, data]);
    ///     console.log(`Received PCM data, buffer size: ${pcmBuffer.length}`);
    ///   } else {
    ///     console.log('Received message:', JSON.parse(data.toString()));
    ///   }
    /// });
    /// ```
    ///
    /// 5. You will respond with transcriptions as you have them. Format:
    /// ```
    ///  {
    ///     "type": "transcriber-response",
    ///     "transcription": "Hello, world!",
    ///     "channel": "customer" | "assistant"
    ///  }
    /// ```
    /// </summary>
    [JsonPropertyName("server")]
    public required Server Server { get; set; }

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
