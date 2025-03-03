using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TransferMode>))]
public enum TransferMode
{
    [EnumMember(Value = "rolling-history")]
    RollingHistory,

    [EnumMember(Value = "swap-system-message-in-history")]
    SwapSystemMessageInHistory,
}
