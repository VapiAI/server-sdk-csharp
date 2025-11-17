using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageModelOutputType>))]
public enum ClientMessageModelOutputType
{
    [EnumMember(Value = "model-output")]
    ModelOutput,
}
