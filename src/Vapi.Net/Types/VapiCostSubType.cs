using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<VapiCostSubType>))]
public enum VapiCostSubType
{
    [EnumMember(Value = "normal")]
    Normal,

    [EnumMember(Value = "overage")]
    Overage,
}