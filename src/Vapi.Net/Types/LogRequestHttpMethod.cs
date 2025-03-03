using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<LogRequestHttpMethod>))]
public enum LogRequestHttpMethod
{
    [EnumMember(Value = "POST")]
    Post,

    [EnumMember(Value = "GET")]
    Get,

    [EnumMember(Value = "PUT")]
    Put,

    [EnumMember(Value = "PATCH")]
    Patch,

    [EnumMember(Value = "DELETE")]
    Delete,
}
