using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ResponseTextDeltaEventType>))]
public enum ResponseTextDeltaEventType
{
    [EnumMember(Value = "response.output_text.delta")]
    ResponseOutputTextDelta,
}
