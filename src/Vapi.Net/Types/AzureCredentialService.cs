using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AzureCredentialService>))]
public enum AzureCredentialService
{
    [EnumMember(Value = "speech")]
    Speech,

    [EnumMember(Value = "blob_storage")]
    BlobStorage,
}
