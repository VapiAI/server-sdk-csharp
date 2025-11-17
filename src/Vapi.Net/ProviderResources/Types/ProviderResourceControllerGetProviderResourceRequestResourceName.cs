using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(
    typeof(EnumSerializer<ProviderResourceControllerGetProviderResourceRequestResourceName>)
)]
public enum ProviderResourceControllerGetProviderResourceRequestResourceName
{
    [EnumMember(Value = "pronunciation-dictionary")]
    PronunciationDictionary,
}
