using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TransferHookActionType>))]
public enum TransferHookActionType
{
    [EnumMember(Value = "transfer")]
    Transfer,
}
