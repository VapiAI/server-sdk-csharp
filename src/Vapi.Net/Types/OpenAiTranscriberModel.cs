using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<OpenAiTranscriberModel>))]
public enum OpenAiTranscriberModel
{
    [EnumMember(Value = "gpt-4o-transcribe")]
    Gpt4OTranscribe,

    [EnumMember(Value = "gpt-4o-mini-transcribe")]
    Gpt4OMiniTranscribe,
}
