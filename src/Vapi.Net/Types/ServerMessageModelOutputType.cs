using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageModelOutputType>))]
public enum ServerMessageModelOutputType
{
    [EnumMember(Value = "model-output")]
    ModelOutput,
}
