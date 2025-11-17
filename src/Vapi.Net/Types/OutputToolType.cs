using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<OutputToolType>))]
public enum OutputToolType
{
    [EnumMember(Value = "output")]
    Output,
}
