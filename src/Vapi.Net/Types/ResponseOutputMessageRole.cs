using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ResponseOutputMessageRole>))]
public enum ResponseOutputMessageRole
{
    [EnumMember(Value = "assistant")]
    Assistant,
}
