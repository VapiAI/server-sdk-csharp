using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ResponseOutputTextType>))]
public enum ResponseOutputTextType
{
    [EnumMember(Value = "output_text")]
    OutputText,
}
