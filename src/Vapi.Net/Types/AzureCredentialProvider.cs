using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AzureCredentialProvider>))]
public enum AzureCredentialProvider
{
    [EnumMember(Value = "azure")]
    Azure,
}
