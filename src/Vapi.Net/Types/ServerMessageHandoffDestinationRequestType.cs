using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageHandoffDestinationRequestType>))]
public enum ServerMessageHandoffDestinationRequestType
{
    [EnumMember(Value = "handoff-destination-request")]
    HandoffDestinationRequest,
}
