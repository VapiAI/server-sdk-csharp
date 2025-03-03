using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AzureOpenAiCredentialRegion>))]
public enum AzureOpenAiCredentialRegion
{
    [EnumMember(Value = "australia")]
    Australia,

    [EnumMember(Value = "canadaeast")]
    Canadaeast,

    [EnumMember(Value = "canadacentral")]
    Canadacentral,

    [EnumMember(Value = "eastus2")]
    Eastus2,

    [EnumMember(Value = "eastus")]
    Eastus,

    [EnumMember(Value = "france")]
    France,

    [EnumMember(Value = "india")]
    India,

    [EnumMember(Value = "japaneast")]
    Japaneast,

    [EnumMember(Value = "japanwest")]
    Japanwest,

    [EnumMember(Value = "uaenorth")]
    Uaenorth,

    [EnumMember(Value = "northcentralus")]
    Northcentralus,

    [EnumMember(Value = "norway")]
    Norway,

    [EnumMember(Value = "southcentralus")]
    Southcentralus,

    [EnumMember(Value = "swedencentral")]
    Swedencentral,

    [EnumMember(Value = "switzerland")]
    Switzerland,

    [EnumMember(Value = "uk")]
    Uk,

    [EnumMember(Value = "westus")]
    Westus,

    [EnumMember(Value = "westus3")]
    Westus3,
}
