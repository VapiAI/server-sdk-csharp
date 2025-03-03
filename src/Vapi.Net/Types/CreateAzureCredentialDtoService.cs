using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CreateAzureCredentialDtoService>))]
public enum CreateAzureCredentialDtoService
{
    [EnumMember(Value = "speech")]
    Speech,

    [EnumMember(Value = "blob_storage")]
    BlobStorage,
}
