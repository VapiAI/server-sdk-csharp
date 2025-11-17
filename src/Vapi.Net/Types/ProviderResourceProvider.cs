using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ProviderResourceProvider>))]
public enum ProviderResourceProvider
{
    [EnumMember(Value = "11labs")]
    ElevenLabs,
}
