using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(
    typeof(EnumSerializer<ProviderResourceControllerDeleteProviderResourceRequestResourceName>)
)]
public enum ProviderResourceControllerDeleteProviderResourceRequestResourceName
{
    [EnumMember(Value = "pronunciation-dictionary")]
    PronunciationDictionary,
}
