using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<JsonSchemaFormat>))]
public enum JsonSchemaFormat
{
    [EnumMember(Value = "date-time")]
    DateTime,

    [EnumMember(Value = "time")]
    Time,

    [EnumMember(Value = "date")]
    Date,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "email")]
    Email,

    [EnumMember(Value = "hostname")]
    Hostname,

    [EnumMember(Value = "ipv4")]
    Ipv4,

    [EnumMember(Value = "ipv6")]
    Ipv6,

    [EnumMember(Value = "uuid")]
    Uuid,
}
