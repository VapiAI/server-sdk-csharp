using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(
    typeof(EnumSerializer<ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider>)
)]
public enum ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider
{
    [EnumMember(Value = "11labs")]
    ElevenLabs,
}
