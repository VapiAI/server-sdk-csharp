using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateAzureOpenAiCredentialDtoRegionSerializer))]
public enum UpdateAzureOpenAiCredentialDtoRegion
{
    [EnumMember(Value = "australiaeast")]
    Australiaeast,

    [EnumMember(Value = "canadaeast")]
    Canadaeast,

    [EnumMember(Value = "canadacentral")]
    Canadacentral,

    [EnumMember(Value = "centralus")]
    Centralus,

    [EnumMember(Value = "eastus2")]
    Eastus2,

    [EnumMember(Value = "eastus")]
    Eastus,

    [EnumMember(Value = "france")]
    France,

    [EnumMember(Value = "germanywestcentral")]
    Germanywestcentral,

    [EnumMember(Value = "india")]
    India,

    [EnumMember(Value = "japaneast")]
    Japaneast,

    [EnumMember(Value = "japanwest")]
    Japanwest,

    [EnumMember(Value = "northcentralus")]
    Northcentralus,

    [EnumMember(Value = "norway")]
    Norway,

    [EnumMember(Value = "polandcentral")]
    Polandcentral,

    [EnumMember(Value = "southcentralus")]
    Southcentralus,

    [EnumMember(Value = "spaincentral")]
    Spaincentral,

    [EnumMember(Value = "swedencentral")]
    Swedencentral,

    [EnumMember(Value = "switzerland")]
    Switzerland,

    [EnumMember(Value = "uaenorth")]
    Uaenorth,

    [EnumMember(Value = "uk")]
    Uk,

    [EnumMember(Value = "westeurope")]
    Westeurope,

    [EnumMember(Value = "westus")]
    Westus,

    [EnumMember(Value = "westus3")]
    Westus3,
}

internal class UpdateAzureOpenAiCredentialDtoRegionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateAzureOpenAiCredentialDtoRegion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateAzureOpenAiCredentialDtoRegion
    > _stringToEnum = new()
    {
        { "australiaeast", UpdateAzureOpenAiCredentialDtoRegion.Australiaeast },
        { "canadaeast", UpdateAzureOpenAiCredentialDtoRegion.Canadaeast },
        { "canadacentral", UpdateAzureOpenAiCredentialDtoRegion.Canadacentral },
        { "centralus", UpdateAzureOpenAiCredentialDtoRegion.Centralus },
        { "eastus2", UpdateAzureOpenAiCredentialDtoRegion.Eastus2 },
        { "eastus", UpdateAzureOpenAiCredentialDtoRegion.Eastus },
        { "france", UpdateAzureOpenAiCredentialDtoRegion.France },
        { "germanywestcentral", UpdateAzureOpenAiCredentialDtoRegion.Germanywestcentral },
        { "india", UpdateAzureOpenAiCredentialDtoRegion.India },
        { "japaneast", UpdateAzureOpenAiCredentialDtoRegion.Japaneast },
        { "japanwest", UpdateAzureOpenAiCredentialDtoRegion.Japanwest },
        { "northcentralus", UpdateAzureOpenAiCredentialDtoRegion.Northcentralus },
        { "norway", UpdateAzureOpenAiCredentialDtoRegion.Norway },
        { "polandcentral", UpdateAzureOpenAiCredentialDtoRegion.Polandcentral },
        { "southcentralus", UpdateAzureOpenAiCredentialDtoRegion.Southcentralus },
        { "spaincentral", UpdateAzureOpenAiCredentialDtoRegion.Spaincentral },
        { "swedencentral", UpdateAzureOpenAiCredentialDtoRegion.Swedencentral },
        { "switzerland", UpdateAzureOpenAiCredentialDtoRegion.Switzerland },
        { "uaenorth", UpdateAzureOpenAiCredentialDtoRegion.Uaenorth },
        { "uk", UpdateAzureOpenAiCredentialDtoRegion.Uk },
        { "westeurope", UpdateAzureOpenAiCredentialDtoRegion.Westeurope },
        { "westus", UpdateAzureOpenAiCredentialDtoRegion.Westus },
        { "westus3", UpdateAzureOpenAiCredentialDtoRegion.Westus3 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateAzureOpenAiCredentialDtoRegion,
        string
    > _enumToString = new()
    {
        { UpdateAzureOpenAiCredentialDtoRegion.Australiaeast, "australiaeast" },
        { UpdateAzureOpenAiCredentialDtoRegion.Canadaeast, "canadaeast" },
        { UpdateAzureOpenAiCredentialDtoRegion.Canadacentral, "canadacentral" },
        { UpdateAzureOpenAiCredentialDtoRegion.Centralus, "centralus" },
        { UpdateAzureOpenAiCredentialDtoRegion.Eastus2, "eastus2" },
        { UpdateAzureOpenAiCredentialDtoRegion.Eastus, "eastus" },
        { UpdateAzureOpenAiCredentialDtoRegion.France, "france" },
        { UpdateAzureOpenAiCredentialDtoRegion.Germanywestcentral, "germanywestcentral" },
        { UpdateAzureOpenAiCredentialDtoRegion.India, "india" },
        { UpdateAzureOpenAiCredentialDtoRegion.Japaneast, "japaneast" },
        { UpdateAzureOpenAiCredentialDtoRegion.Japanwest, "japanwest" },
        { UpdateAzureOpenAiCredentialDtoRegion.Northcentralus, "northcentralus" },
        { UpdateAzureOpenAiCredentialDtoRegion.Norway, "norway" },
        { UpdateAzureOpenAiCredentialDtoRegion.Polandcentral, "polandcentral" },
        { UpdateAzureOpenAiCredentialDtoRegion.Southcentralus, "southcentralus" },
        { UpdateAzureOpenAiCredentialDtoRegion.Spaincentral, "spaincentral" },
        { UpdateAzureOpenAiCredentialDtoRegion.Swedencentral, "swedencentral" },
        { UpdateAzureOpenAiCredentialDtoRegion.Switzerland, "switzerland" },
        { UpdateAzureOpenAiCredentialDtoRegion.Uaenorth, "uaenorth" },
        { UpdateAzureOpenAiCredentialDtoRegion.Uk, "uk" },
        { UpdateAzureOpenAiCredentialDtoRegion.Westeurope, "westeurope" },
        { UpdateAzureOpenAiCredentialDtoRegion.Westus, "westus" },
        { UpdateAzureOpenAiCredentialDtoRegion.Westus3, "westus3" },
    };

    public override UpdateAzureOpenAiCredentialDtoRegion Read(
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
        UpdateAzureOpenAiCredentialDtoRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateAzureOpenAiCredentialDtoRegion ReadAsPropertyName(
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
        UpdateAzureOpenAiCredentialDtoRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
