using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ResponseTextDoneEventType>))]
public enum ResponseTextDoneEventType
{
    [EnumMember(Value = "response.output_text.done")]
    ResponseOutputTextDone,
}
