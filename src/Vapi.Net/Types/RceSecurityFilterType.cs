using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<RceSecurityFilterType>))]
public enum RceSecurityFilterType
{
    [EnumMember(Value = "rce")]
    Rce,
}
