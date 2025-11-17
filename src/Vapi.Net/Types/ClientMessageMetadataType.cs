using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageMetadataType>))]
public enum ClientMessageMetadataType
{
    [EnumMember(Value = "metadata")]
    Metadata,
}
