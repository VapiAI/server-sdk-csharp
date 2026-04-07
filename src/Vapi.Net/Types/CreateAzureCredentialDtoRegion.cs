using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateAzureCredentialDtoRegionSerializer))]
public enum CreateAzureCredentialDtoRegion
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

internal class CreateAzureCredentialDtoRegionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateAzureCredentialDtoRegion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateAzureCredentialDtoRegion
    > _stringToEnum = new()
    {
        { "australiaeast", CreateAzureCredentialDtoRegion.Australiaeast },
        { "canadaeast", CreateAzureCredentialDtoRegion.Canadaeast },
        { "canadacentral", CreateAzureCredentialDtoRegion.Canadacentral },
        { "centralus", CreateAzureCredentialDtoRegion.Centralus },
        { "eastus2", CreateAzureCredentialDtoRegion.Eastus2 },
        { "eastus", CreateAzureCredentialDtoRegion.Eastus },
        { "france", CreateAzureCredentialDtoRegion.France },
        { "germanywestcentral", CreateAzureCredentialDtoRegion.Germanywestcentral },
        { "india", CreateAzureCredentialDtoRegion.India },
        { "japaneast", CreateAzureCredentialDtoRegion.Japaneast },
        { "japanwest", CreateAzureCredentialDtoRegion.Japanwest },
        { "northcentralus", CreateAzureCredentialDtoRegion.Northcentralus },
        { "norway", CreateAzureCredentialDtoRegion.Norway },
        { "polandcentral", CreateAzureCredentialDtoRegion.Polandcentral },
        { "southcentralus", CreateAzureCredentialDtoRegion.Southcentralus },
        { "spaincentral", CreateAzureCredentialDtoRegion.Spaincentral },
        { "swedencentral", CreateAzureCredentialDtoRegion.Swedencentral },
        { "switzerland", CreateAzureCredentialDtoRegion.Switzerland },
        { "uaenorth", CreateAzureCredentialDtoRegion.Uaenorth },
        { "uk", CreateAzureCredentialDtoRegion.Uk },
        { "westeurope", CreateAzureCredentialDtoRegion.Westeurope },
        { "westus", CreateAzureCredentialDtoRegion.Westus },
        { "westus3", CreateAzureCredentialDtoRegion.Westus3 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateAzureCredentialDtoRegion,
        string
    > _enumToString = new()
    {
        { CreateAzureCredentialDtoRegion.Australiaeast, "australiaeast" },
        { CreateAzureCredentialDtoRegion.Canadaeast, "canadaeast" },
        { CreateAzureCredentialDtoRegion.Canadacentral, "canadacentral" },
        { CreateAzureCredentialDtoRegion.Centralus, "centralus" },
        { CreateAzureCredentialDtoRegion.Eastus2, "eastus2" },
        { CreateAzureCredentialDtoRegion.Eastus, "eastus" },
        { CreateAzureCredentialDtoRegion.France, "france" },
        { CreateAzureCredentialDtoRegion.Germanywestcentral, "germanywestcentral" },
        { CreateAzureCredentialDtoRegion.India, "india" },
        { CreateAzureCredentialDtoRegion.Japaneast, "japaneast" },
        { CreateAzureCredentialDtoRegion.Japanwest, "japanwest" },
        { CreateAzureCredentialDtoRegion.Northcentralus, "northcentralus" },
        { CreateAzureCredentialDtoRegion.Norway, "norway" },
        { CreateAzureCredentialDtoRegion.Polandcentral, "polandcentral" },
        { CreateAzureCredentialDtoRegion.Southcentralus, "southcentralus" },
        { CreateAzureCredentialDtoRegion.Spaincentral, "spaincentral" },
        { CreateAzureCredentialDtoRegion.Swedencentral, "swedencentral" },
        { CreateAzureCredentialDtoRegion.Switzerland, "switzerland" },
        { CreateAzureCredentialDtoRegion.Uaenorth, "uaenorth" },
        { CreateAzureCredentialDtoRegion.Uk, "uk" },
        { CreateAzureCredentialDtoRegion.Westeurope, "westeurope" },
        { CreateAzureCredentialDtoRegion.Westus, "westus" },
        { CreateAzureCredentialDtoRegion.Westus3, "westus3" },
    };

    public override CreateAzureCredentialDtoRegion Read(
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
        CreateAzureCredentialDtoRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateAzureCredentialDtoRegion ReadAsPropertyName(
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
        CreateAzureCredentialDtoRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
