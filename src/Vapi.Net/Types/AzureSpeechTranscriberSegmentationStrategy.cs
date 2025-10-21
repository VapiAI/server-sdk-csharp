using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AzureSpeechTranscriberSegmentationStrategy>))]
public enum AzureSpeechTranscriberSegmentationStrategy
{
    [EnumMember(Value = "Default")]
    Default,

    [EnumMember(Value = "Time")]
    Time,

    [EnumMember(Value = "Semantic")]
    Semantic,
}
