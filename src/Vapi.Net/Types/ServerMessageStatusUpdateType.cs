using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageStatusUpdateType>))]
public enum ServerMessageStatusUpdateType
{
    [EnumMember(Value = "status-update")]
    StatusUpdate,
}
