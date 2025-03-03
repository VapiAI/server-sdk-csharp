using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ApiRequestMode>))]
public enum ApiRequestMode
{
    [EnumMember(Value = "blocking")]
    Blocking,

    [EnumMember(Value = "background")]
    Background,
}
