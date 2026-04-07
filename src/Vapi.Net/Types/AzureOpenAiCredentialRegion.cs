using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AzureOpenAiCredentialRegionSerializer))]
public enum AzureOpenAiCredentialRegion
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

internal class AzureOpenAiCredentialRegionSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AzureOpenAiCredentialRegion>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AzureOpenAiCredentialRegion
    > _stringToEnum = new()
    {
        { "australiaeast", AzureOpenAiCredentialRegion.Australiaeast },
        { "canadaeast", AzureOpenAiCredentialRegion.Canadaeast },
        { "canadacentral", AzureOpenAiCredentialRegion.Canadacentral },
        { "centralus", AzureOpenAiCredentialRegion.Centralus },
        { "eastus2", AzureOpenAiCredentialRegion.Eastus2 },
        { "eastus", AzureOpenAiCredentialRegion.Eastus },
        { "france", AzureOpenAiCredentialRegion.France },
        { "germanywestcentral", AzureOpenAiCredentialRegion.Germanywestcentral },
        { "india", AzureOpenAiCredentialRegion.India },
        { "japaneast", AzureOpenAiCredentialRegion.Japaneast },
        { "japanwest", AzureOpenAiCredentialRegion.Japanwest },
        { "northcentralus", AzureOpenAiCredentialRegion.Northcentralus },
        { "norway", AzureOpenAiCredentialRegion.Norway },
        { "polandcentral", AzureOpenAiCredentialRegion.Polandcentral },
        { "southcentralus", AzureOpenAiCredentialRegion.Southcentralus },
        { "spaincentral", AzureOpenAiCredentialRegion.Spaincentral },
        { "swedencentral", AzureOpenAiCredentialRegion.Swedencentral },
        { "switzerland", AzureOpenAiCredentialRegion.Switzerland },
        { "uaenorth", AzureOpenAiCredentialRegion.Uaenorth },
        { "uk", AzureOpenAiCredentialRegion.Uk },
        { "westeurope", AzureOpenAiCredentialRegion.Westeurope },
        { "westus", AzureOpenAiCredentialRegion.Westus },
        { "westus3", AzureOpenAiCredentialRegion.Westus3 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AzureOpenAiCredentialRegion,
        string
    > _enumToString = new()
    {
        { AzureOpenAiCredentialRegion.Australiaeast, "australiaeast" },
        { AzureOpenAiCredentialRegion.Canadaeast, "canadaeast" },
        { AzureOpenAiCredentialRegion.Canadacentral, "canadacentral" },
        { AzureOpenAiCredentialRegion.Centralus, "centralus" },
        { AzureOpenAiCredentialRegion.Eastus2, "eastus2" },
        { AzureOpenAiCredentialRegion.Eastus, "eastus" },
        { AzureOpenAiCredentialRegion.France, "france" },
        { AzureOpenAiCredentialRegion.Germanywestcentral, "germanywestcentral" },
        { AzureOpenAiCredentialRegion.India, "india" },
        { AzureOpenAiCredentialRegion.Japaneast, "japaneast" },
        { AzureOpenAiCredentialRegion.Japanwest, "japanwest" },
        { AzureOpenAiCredentialRegion.Northcentralus, "northcentralus" },
        { AzureOpenAiCredentialRegion.Norway, "norway" },
        { AzureOpenAiCredentialRegion.Polandcentral, "polandcentral" },
        { AzureOpenAiCredentialRegion.Southcentralus, "southcentralus" },
        { AzureOpenAiCredentialRegion.Spaincentral, "spaincentral" },
        { AzureOpenAiCredentialRegion.Swedencentral, "swedencentral" },
        { AzureOpenAiCredentialRegion.Switzerland, "switzerland" },
        { AzureOpenAiCredentialRegion.Uaenorth, "uaenorth" },
        { AzureOpenAiCredentialRegion.Uk, "uk" },
        { AzureOpenAiCredentialRegion.Westeurope, "westeurope" },
        { AzureOpenAiCredentialRegion.Westus, "westus" },
        { AzureOpenAiCredentialRegion.Westus3, "westus3" },
    };

    public override AzureOpenAiCredentialRegion Read(
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
        AzureOpenAiCredentialRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AzureOpenAiCredentialRegion ReadAsPropertyName(
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
        AzureOpenAiCredentialRegion value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
