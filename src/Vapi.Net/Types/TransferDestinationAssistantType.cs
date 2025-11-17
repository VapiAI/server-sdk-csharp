using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TransferDestinationAssistantType>))]
public enum TransferDestinationAssistantType
{
    [EnumMember(Value = "assistant")]
    Assistant,
}
