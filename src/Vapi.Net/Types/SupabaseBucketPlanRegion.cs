using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<SupabaseBucketPlanRegion>))]
public enum SupabaseBucketPlanRegion
{
    [EnumMember(Value = "us-west-1")]
    UsWest1,

    [EnumMember(Value = "us-east-1")]
    UsEast1,

    [EnumMember(Value = "us-east-2")]
    UsEast2,

    [EnumMember(Value = "ca-central-1")]
    CaCentral1,

    [EnumMember(Value = "eu-west-1")]
    EuWest1,

    [EnumMember(Value = "eu-west-2")]
    EuWest2,

    [EnumMember(Value = "eu-west-3")]
    EuWest3,

    [EnumMember(Value = "eu-central-1")]
    EuCentral1,

    [EnumMember(Value = "eu-central-2")]
    EuCentral2,

    [EnumMember(Value = "eu-north-1")]
    EuNorth1,

    [EnumMember(Value = "ap-south-1")]
    ApSouth1,

    [EnumMember(Value = "ap-southeast-1")]
    ApSoutheast1,

    [EnumMember(Value = "ap-northeast-1")]
    ApNortheast1,

    [EnumMember(Value = "ap-northeast-2")]
    ApNortheast2,

    [EnumMember(Value = "ap-southeast-2")]
    ApSoutheast2,

    [EnumMember(Value = "sa-east-1")]
    SaEast1,
}
