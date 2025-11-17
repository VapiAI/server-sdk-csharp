using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TransferSuccessfulToolUserEditableType>))]
public enum TransferSuccessfulToolUserEditableType
{
    [EnumMember(Value = "transferSuccessful")]
    TransferSuccessful,
}
