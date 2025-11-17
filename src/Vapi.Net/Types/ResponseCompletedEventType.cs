using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ResponseCompletedEventType>))]
public enum ResponseCompletedEventType
{
    [EnumMember(Value = "response.completed")]
    ResponseCompleted,
}
