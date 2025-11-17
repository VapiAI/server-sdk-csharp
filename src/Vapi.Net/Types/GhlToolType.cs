using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GhlToolType>))]
public enum GhlToolType
{
    [EnumMember(Value = "ghl")]
    Ghl,
}
