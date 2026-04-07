using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record FallbackCustomTranscriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
