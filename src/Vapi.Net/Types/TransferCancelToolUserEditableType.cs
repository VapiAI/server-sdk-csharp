using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TransferCancelToolUserEditableType>))]
public enum TransferCancelToolUserEditableType
{
    [EnumMember(Value = "transferCancel")]
    TransferCancel,
}
