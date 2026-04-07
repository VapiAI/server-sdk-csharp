using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateAnthropicBedrockCredentialDtoRegionSerializer))]
public enum UpdateAnthropicBedrockCredentialDtoRegion
{
    [EnumMember(Value = "us-east-1")]
    UsEast1,

    [EnumMember(Value = "us-west-2")]
    UsWest2,

    [EnumMember(Value = "eu-west-1")]
    EuWest1,

    [EnumMember(Value = "eu-west-3")]
    EuWest3,

    [EnumMember(Value = "ap-northeast-1")]
    ApNortheast1,

    [EnumMember(Value = "ap-southeast-2")]
    ApSoutheast2,
}

internal class UpdateAnthropicBedrockCredentialDtoRegionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateAnthropicBedrockCredentialDtoRegion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateAnthropicBedrockCredentialDtoRegion
    > _stringToEnum = new()
    {
        { "us-east-1", UpdateAnthropicBedrockCredentialDtoRegion.UsEast1 },
        { "us-west-2", UpdateAnthropicBedrockCredentialDtoRegion.UsWest2 },
        { "eu-west-1", UpdateAnthropicBedrockCredentialDtoRegion.EuWest1 },
        { "eu-west-3", UpdateAnthropicBedrockCredentialDtoRegion.EuWest3 },
        { "ap-northeast-1", UpdateAnthropicBedrockCredentialDtoRegion.ApNortheast1 },
        { "ap-southeast-2", UpdateAnthropicBedrockCredentialDtoRegion.ApSoutheast2 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateAnthropicBedrockCredentialDtoRegion,
        string
    > _enumToString = new()
    {
        { UpdateAnthropicBedrockCredentialDtoRegion.UsEast1, "us-east-1" },
        { UpdateAnthropicBedrockCredentialDtoRegion.UsWest2, "us-west-2" },
        { UpdateAnthropicBedrockCredentialDtoRegion.EuWest1, "eu-west-1" },
        { UpdateAnthropicBedrockCredentialDtoRegion.EuWest3, "eu-west-3" },
        { UpdateAnthropicBedrockCredentialDtoRegion.ApNortheast1, "ap-northeast-1" },
        { UpdateAnthropicBedrockCredentialDtoRegion.ApSoutheast2, "ap-southeast-2" },
    };

    public override UpdateAnthropicBedrockCredentialDtoRegion Read(
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
        UpdateAnthropicBedrockCredentialDtoRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateAnthropicBedrockCredentialDtoRegion ReadAsPropertyName(
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
        UpdateAnthropicBedrockCredentialDtoRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
