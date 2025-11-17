using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<MakeToolType>))]
public enum MakeToolType
{
    [EnumMember(Value = "make")]
    Make,
}
