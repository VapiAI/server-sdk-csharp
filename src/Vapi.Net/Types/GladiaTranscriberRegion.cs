using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GladiaTranscriberRegion>))]
public enum GladiaTranscriberRegion
{
    [EnumMember(Value = "us-west")]
    UsWest,

    [EnumMember(Value = "eu-west")]
    EuWest,
}
