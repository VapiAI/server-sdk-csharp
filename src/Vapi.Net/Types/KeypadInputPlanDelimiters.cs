using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<KeypadInputPlanDelimiters>))]
public enum KeypadInputPlanDelimiters
{
    [EnumMember(Value = "#")]
    Hash,

    [EnumMember(Value = "*")]
    Asterisk,

    [EnumMember(Value = "")]
    Empty,
}
