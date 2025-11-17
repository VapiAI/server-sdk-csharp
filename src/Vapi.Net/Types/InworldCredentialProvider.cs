using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<InworldCredentialProvider>))]
public enum InworldCredentialProvider
{
    [EnumMember(Value = "inworld")]
    Inworld,
}
