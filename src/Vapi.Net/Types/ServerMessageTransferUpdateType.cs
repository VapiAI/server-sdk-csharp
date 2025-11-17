using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageTransferUpdateType>))]
public enum ServerMessageTransferUpdateType
{
    [EnumMember(Value = "transfer-update")]
    TransferUpdate,
}
