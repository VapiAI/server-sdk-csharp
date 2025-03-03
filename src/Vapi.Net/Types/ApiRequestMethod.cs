using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ApiRequestMethod>))]
public enum ApiRequestMethod
{
    [EnumMember(Value = "POST")]
    Post,

    [EnumMember(Value = "GET")]
    Get,
}
