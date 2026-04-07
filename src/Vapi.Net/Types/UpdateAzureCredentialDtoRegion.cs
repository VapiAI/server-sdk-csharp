using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateAzureCredentialDtoRegionSerializer))]
public enum UpdateAzureCredentialDtoRegion
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

internal class UpdateAzureCredentialDtoRegionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateAzureCredentialDtoRegion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateAzureCredentialDtoRegion
    > _stringToEnum = new()
    {
        { "australiaeast", UpdateAzureCredentialDtoRegion.Australiaeast },
        { "canadaeast", UpdateAzureCredentialDtoRegion.Canadaeast },
        { "canadacentral", UpdateAzureCredentialDtoRegion.Canadacentral },
        { "centralus", UpdateAzureCredentialDtoRegion.Centralus },
        { "eastus2", UpdateAzureCredentialDtoRegion.Eastus2 },
        { "eastus", UpdateAzureCredentialDtoRegion.Eastus },
        { "france", UpdateAzureCredentialDtoRegion.France },
        { "germanywestcentral", UpdateAzureCredentialDtoRegion.Germanywestcentral },
        { "india", UpdateAzureCredentialDtoRegion.India },
        { "japaneast", UpdateAzureCredentialDtoRegion.Japaneast },
        { "japanwest", UpdateAzureCredentialDtoRegion.Japanwest },
        { "northcentralus", UpdateAzureCredentialDtoRegion.Northcentralus },
        { "norway", UpdateAzureCredentialDtoRegion.Norway },
        { "polandcentral", UpdateAzureCredentialDtoRegion.Polandcentral },
        { "southcentralus", UpdateAzureCredentialDtoRegion.Southcentralus },
        { "spaincentral", UpdateAzureCredentialDtoRegion.Spaincentral },
        { "swedencentral", UpdateAzureCredentialDtoRegion.Swedencentral },
        { "switzerland", UpdateAzureCredentialDtoRegion.Switzerland },
        { "uaenorth", UpdateAzureCredentialDtoRegion.Uaenorth },
        { "uk", UpdateAzureCredentialDtoRegion.Uk },
        { "westeurope", UpdateAzureCredentialDtoRegion.Westeurope },
        { "westus", UpdateAzureCredentialDtoRegion.Westus },
        { "westus3", UpdateAzureCredentialDtoRegion.Westus3 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateAzureCredentialDtoRegion,
        string
    > _enumToString = new()
    {
        { UpdateAzureCredentialDtoRegion.Australiaeast, "australiaeast" },
        { UpdateAzureCredentialDtoRegion.Canadaeast, "canadaeast" },
        { UpdateAzureCredentialDtoRegion.Canadacentral, "canadacentral" },
        { UpdateAzureCredentialDtoRegion.Centralus, "centralus" },
        { UpdateAzureCredentialDtoRegion.Eastus2, "eastus2" },
        { UpdateAzureCredentialDtoRegion.Eastus, "eastus" },
        { UpdateAzureCredentialDtoRegion.France, "france" },
        { UpdateAzureCredentialDtoRegion.Germanywestcentral, "germanywestcentral" },
        { UpdateAzureCredentialDtoRegion.India, "india" },
        { UpdateAzureCredentialDtoRegion.Japaneast, "japaneast" },
        { UpdateAzureCredentialDtoRegion.Japanwest, "japanwest" },
        { UpdateAzureCredentialDtoRegion.Northcentralus, "northcentralus" },
        { UpdateAzureCredentialDtoRegion.Norway, "norway" },
        { UpdateAzureCredentialDtoRegion.Polandcentral, "polandcentral" },
        { UpdateAzureCredentialDtoRegion.Southcentralus, "southcentralus" },
        { UpdateAzureCredentialDtoRegion.Spaincentral, "spaincentral" },
        { UpdateAzureCredentialDtoRegion.Swedencentral, "swedencentral" },
        { UpdateAzureCredentialDtoRegion.Switzerland, "switzerland" },
        { UpdateAzureCredentialDtoRegion.Uaenorth, "uaenorth" },
        { UpdateAzureCredentialDtoRegion.Uk, "uk" },
        { UpdateAzureCredentialDtoRegion.Westeurope, "westeurope" },
        { UpdateAzureCredentialDtoRegion.Westus, "westus" },
        { UpdateAzureCredentialDtoRegion.Westus3, "westus3" },
    };

    public override UpdateAzureCredentialDtoRegion Read(
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
        UpdateAzureCredentialDtoRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateAzureCredentialDtoRegion ReadAsPropertyName(
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
        UpdateAzureCredentialDtoRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
