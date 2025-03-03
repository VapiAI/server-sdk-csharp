using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<RegexOptionType>))]
public enum RegexOptionType
{
    [EnumMember(Value = "ignore-case")]
    IgnoreCase,

    [EnumMember(Value = "whole-word")]
    WholeWord,

    [EnumMember(Value = "multi-line")]
    MultiLine,
}
