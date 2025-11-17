using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ResponseErrorEventType>))]
public enum ResponseErrorEventType
{
    [EnumMember(Value = "error")]
    Error,
}
