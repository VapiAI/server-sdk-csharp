using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<HmacAuthenticationPlanSignatureEncoding>))]
public enum HmacAuthenticationPlanSignatureEncoding
{
    [EnumMember(Value = "hex")]
    Hex,

    [EnumMember(Value = "base64")]
    Base64,
}
