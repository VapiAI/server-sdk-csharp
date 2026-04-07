using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SupabaseBucketPlanRegionSerializer))]
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

internal class SupabaseBucketPlanRegionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SupabaseBucketPlanRegion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SupabaseBucketPlanRegion
    > _stringToEnum = new()
    {
        { "us-west-1", SupabaseBucketPlanRegion.UsWest1 },
        { "us-east-1", SupabaseBucketPlanRegion.UsEast1 },
        { "us-east-2", SupabaseBucketPlanRegion.UsEast2 },
        { "ca-central-1", SupabaseBucketPlanRegion.CaCentral1 },
        { "eu-west-1", SupabaseBucketPlanRegion.EuWest1 },
        { "eu-west-2", SupabaseBucketPlanRegion.EuWest2 },
        { "eu-west-3", SupabaseBucketPlanRegion.EuWest3 },
        { "eu-central-1", SupabaseBucketPlanRegion.EuCentral1 },
        { "eu-central-2", SupabaseBucketPlanRegion.EuCentral2 },
        { "eu-north-1", SupabaseBucketPlanRegion.EuNorth1 },
        { "ap-south-1", SupabaseBucketPlanRegion.ApSouth1 },
        { "ap-southeast-1", SupabaseBucketPlanRegion.ApSoutheast1 },
        { "ap-northeast-1", SupabaseBucketPlanRegion.ApNortheast1 },
        { "ap-northeast-2", SupabaseBucketPlanRegion.ApNortheast2 },
        { "ap-southeast-2", SupabaseBucketPlanRegion.ApSoutheast2 },
        { "sa-east-1", SupabaseBucketPlanRegion.SaEast1 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        SupabaseBucketPlanRegion,
        string
    > _enumToString = new()
    {
        { SupabaseBucketPlanRegion.UsWest1, "us-west-1" },
        { SupabaseBucketPlanRegion.UsEast1, "us-east-1" },
        { SupabaseBucketPlanRegion.UsEast2, "us-east-2" },
        { SupabaseBucketPlanRegion.CaCentral1, "ca-central-1" },
        { SupabaseBucketPlanRegion.EuWest1, "eu-west-1" },
        { SupabaseBucketPlanRegion.EuWest2, "eu-west-2" },
        { SupabaseBucketPlanRegion.EuWest3, "eu-west-3" },
        { SupabaseBucketPlanRegion.EuCentral1, "eu-central-1" },
        { SupabaseBucketPlanRegion.EuCentral2, "eu-central-2" },
        { SupabaseBucketPlanRegion.EuNorth1, "eu-north-1" },
        { SupabaseBucketPlanRegion.ApSouth1, "ap-south-1" },
        { SupabaseBucketPlanRegion.ApSoutheast1, "ap-southeast-1" },
        { SupabaseBucketPlanRegion.ApNortheast1, "ap-northeast-1" },
        { SupabaseBucketPlanRegion.ApNortheast2, "ap-northeast-2" },
        { SupabaseBucketPlanRegion.ApSoutheast2, "ap-southeast-2" },
        { SupabaseBucketPlanRegion.SaEast1, "sa-east-1" },
    };

    public override SupabaseBucketPlanRegion Read(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception("The JSON value could not be read as a string.");
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void Write(
        global::System.Text.Json.Utf8JsonWriter writer,
        SupabaseBucketPlanRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SupabaseBucketPlanRegion ReadAsPropertyName(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception(
                "The JSON property name could not be read as a string."
            );
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void WriteAsPropertyName(
        global::System.Text.Json.Utf8JsonWriter writer,
        SupabaseBucketPlanRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
