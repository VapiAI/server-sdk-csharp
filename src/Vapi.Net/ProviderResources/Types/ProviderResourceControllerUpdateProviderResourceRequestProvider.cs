using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(
    typeof(EnumSerializer<ProviderResourceControllerUpdateProviderResourceRequestProvider>)
)]
public enum ProviderResourceControllerUpdateProviderResourceRequestProvider
{
    [EnumMember(Value = "11labs")]
    ElevenLabs,
}
