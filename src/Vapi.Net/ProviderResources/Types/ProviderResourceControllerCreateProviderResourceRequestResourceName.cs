using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(
    typeof(EnumSerializer<ProviderResourceControllerCreateProviderResourceRequestResourceName>)
)]
public enum ProviderResourceControllerCreateProviderResourceRequestResourceName
{
    [EnumMember(Value = "pronunciation-dictionary")]
    PronunciationDictionary,
}
