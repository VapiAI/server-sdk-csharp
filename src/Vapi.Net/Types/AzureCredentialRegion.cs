using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AzureCredentialRegionSerializer))]
public enum AzureCredentialRegion
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

internal class AzureCredentialRegionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AzureCredentialRegion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AzureCredentialRegion
    > _stringToEnum = new()
    {
        { "australiaeast", AzureCredentialRegion.Australiaeast },
        { "canadaeast", AzureCredentialRegion.Canadaeast },
        { "canadacentral", AzureCredentialRegion.Canadacentral },
        { "centralus", AzureCredentialRegion.Centralus },
        { "eastus2", AzureCredentialRegion.Eastus2 },
        { "eastus", AzureCredentialRegion.Eastus },
        { "france", AzureCredentialRegion.France },
        { "germanywestcentral", AzureCredentialRegion.Germanywestcentral },
        { "india", AzureCredentialRegion.India },
        { "japaneast", AzureCredentialRegion.Japaneast },
        { "japanwest", AzureCredentialRegion.Japanwest },
        { "northcentralus", AzureCredentialRegion.Northcentralus },
        { "norway", AzureCredentialRegion.Norway },
        { "polandcentral", AzureCredentialRegion.Polandcentral },
        { "southcentralus", AzureCredentialRegion.Southcentralus },
        { "spaincentral", AzureCredentialRegion.Spaincentral },
        { "swedencentral", AzureCredentialRegion.Swedencentral },
        { "switzerland", AzureCredentialRegion.Switzerland },
        { "uaenorth", AzureCredentialRegion.Uaenorth },
        { "uk", AzureCredentialRegion.Uk },
        { "westeurope", AzureCredentialRegion.Westeurope },
        { "westus", AzureCredentialRegion.Westus },
        { "westus3", AzureCredentialRegion.Westus3 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AzureCredentialRegion,
        string
    > _enumToString = new()
    {
        { AzureCredentialRegion.Australiaeast, "australiaeast" },
        { AzureCredentialRegion.Canadaeast, "canadaeast" },
        { AzureCredentialRegion.Canadacentral, "canadacentral" },
        { AzureCredentialRegion.Centralus, "centralus" },
        { AzureCredentialRegion.Eastus2, "eastus2" },
        { AzureCredentialRegion.Eastus, "eastus" },
        { AzureCredentialRegion.France, "france" },
        { AzureCredentialRegion.Germanywestcentral, "germanywestcentral" },
        { AzureCredentialRegion.India, "india" },
        { AzureCredentialRegion.Japaneast, "japaneast" },
        { AzureCredentialRegion.Japanwest, "japanwest" },
        { AzureCredentialRegion.Northcentralus, "northcentralus" },
        { AzureCredentialRegion.Norway, "norway" },
        { AzureCredentialRegion.Polandcentral, "polandcentral" },
        { AzureCredentialRegion.Southcentralus, "southcentralus" },
        { AzureCredentialRegion.Spaincentral, "spaincentral" },
        { AzureCredentialRegion.Swedencentral, "swedencentral" },
        { AzureCredentialRegion.Switzerland, "switzerland" },
        { AzureCredentialRegion.Uaenorth, "uaenorth" },
        { AzureCredentialRegion.Uk, "uk" },
        { AzureCredentialRegion.Westeurope, "westeurope" },
        { AzureCredentialRegion.Westus, "westus" },
        { AzureCredentialRegion.Westus3, "westus3" },
    };

    public override AzureCredentialRegion Read(
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
        AzureCredentialRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AzureCredentialRegion ReadAsPropertyName(
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
        AzureCredentialRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
