using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GladiaCredentialProvider>))]
public enum GladiaCredentialProvider
{
    [EnumMember(Value = "gladia")]
    Gladia,
}
