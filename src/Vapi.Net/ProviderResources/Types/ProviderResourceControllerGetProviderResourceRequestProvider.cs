using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(
    typeof(EnumSerializer<ProviderResourceControllerGetProviderResourceRequestProvider>)
)]
public enum ProviderResourceControllerGetProviderResourceRequestProvider
{
    [EnumMember(Value = "11labs")]
    ElevenLabs,
}
