using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageCallEndpointingRequestType>))]
public enum ServerMessageCallEndpointingRequestType
{
    [EnumMember(Value = "call.endpointing.request")]
    CallEndpointingRequest,
}
