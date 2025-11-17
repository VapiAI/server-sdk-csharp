using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ResponseObjectObject>))]
public enum ResponseObjectObject
{
    [EnumMember(Value = "response")]
    Response,
}
