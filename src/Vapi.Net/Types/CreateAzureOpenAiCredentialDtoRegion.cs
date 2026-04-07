using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateAzureOpenAiCredentialDtoRegionSerializer))]
public enum CreateAzureOpenAiCredentialDtoRegion
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

internal class CreateAzureOpenAiCredentialDtoRegionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateAzureOpenAiCredentialDtoRegion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateAzureOpenAiCredentialDtoRegion
    > _stringToEnum = new()
    {
        { "australiaeast", CreateAzureOpenAiCredentialDtoRegion.Australiaeast },
        { "canadaeast", CreateAzureOpenAiCredentialDtoRegion.Canadaeast },
        { "canadacentral", CreateAzureOpenAiCredentialDtoRegion.Canadacentral },
        { "centralus", CreateAzureOpenAiCredentialDtoRegion.Centralus },
        { "eastus2", CreateAzureOpenAiCredentialDtoRegion.Eastus2 },
        { "eastus", CreateAzureOpenAiCredentialDtoRegion.Eastus },
        { "france", CreateAzureOpenAiCredentialDtoRegion.France },
        { "germanywestcentral", CreateAzureOpenAiCredentialDtoRegion.Germanywestcentral },
        { "india", CreateAzureOpenAiCredentialDtoRegion.India },
        { "japaneast", CreateAzureOpenAiCredentialDtoRegion.Japaneast },
        { "japanwest", CreateAzureOpenAiCredentialDtoRegion.Japanwest },
        { "northcentralus", CreateAzureOpenAiCredentialDtoRegion.Northcentralus },
        { "norway", CreateAzureOpenAiCredentialDtoRegion.Norway },
        { "polandcentral", CreateAzureOpenAiCredentialDtoRegion.Polandcentral },
        { "southcentralus", CreateAzureOpenAiCredentialDtoRegion.Southcentralus },
        { "spaincentral", CreateAzureOpenAiCredentialDtoRegion.Spaincentral },
        { "swedencentral", CreateAzureOpenAiCredentialDtoRegion.Swedencentral },
        { "switzerland", CreateAzureOpenAiCredentialDtoRegion.Switzerland },
        { "uaenorth", CreateAzureOpenAiCredentialDtoRegion.Uaenorth },
        { "uk", CreateAzureOpenAiCredentialDtoRegion.Uk },
        { "westeurope", CreateAzureOpenAiCredentialDtoRegion.Westeurope },
        { "westus", CreateAzureOpenAiCredentialDtoRegion.Westus },
        { "westus3", CreateAzureOpenAiCredentialDtoRegion.Westus3 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateAzureOpenAiCredentialDtoRegion,
        string
    > _enumToString = new()
    {
        { CreateAzureOpenAiCredentialDtoRegion.Australiaeast, "australiaeast" },
        { CreateAzureOpenAiCredentialDtoRegion.Canadaeast, "canadaeast" },
        { CreateAzureOpenAiCredentialDtoRegion.Canadacentral, "canadacentral" },
        { CreateAzureOpenAiCredentialDtoRegion.Centralus, "centralus" },
        { CreateAzureOpenAiCredentialDtoRegion.Eastus2, "eastus2" },
        { CreateAzureOpenAiCredentialDtoRegion.Eastus, "eastus" },
        { CreateAzureOpenAiCredentialDtoRegion.France, "france" },
        { CreateAzureOpenAiCredentialDtoRegion.Germanywestcentral, "germanywestcentral" },
        { CreateAzureOpenAiCredentialDtoRegion.India, "india" },
        { CreateAzureOpenAiCredentialDtoRegion.Japaneast, "japaneast" },
        { CreateAzureOpenAiCredentialDtoRegion.Japanwest, "japanwest" },
        { CreateAzureOpenAiCredentialDtoRegion.Northcentralus, "northcentralus" },
        { CreateAzureOpenAiCredentialDtoRegion.Norway, "norway" },
        { CreateAzureOpenAiCredentialDtoRegion.Polandcentral, "polandcentral" },
        { CreateAzureOpenAiCredentialDtoRegion.Southcentralus, "southcentralus" },
        { CreateAzureOpenAiCredentialDtoRegion.Spaincentral, "spaincentral" },
        { CreateAzureOpenAiCredentialDtoRegion.Swedencentral, "swedencentral" },
        { CreateAzureOpenAiCredentialDtoRegion.Switzerland, "switzerland" },
        { CreateAzureOpenAiCredentialDtoRegion.Uaenorth, "uaenorth" },
        { CreateAzureOpenAiCredentialDtoRegion.Uk, "uk" },
        { CreateAzureOpenAiCredentialDtoRegion.Westeurope, "westeurope" },
        { CreateAzureOpenAiCredentialDtoRegion.Westus, "westus" },
        { CreateAzureOpenAiCredentialDtoRegion.Westus3, "westus3" },
    };

    public override CreateAzureOpenAiCredentialDtoRegion Read(
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
        CreateAzureOpenAiCredentialDtoRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateAzureOpenAiCredentialDtoRegion ReadAsPropertyName(
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
        CreateAzureOpenAiCredentialDtoRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
