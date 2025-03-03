using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<UpdateAzureCredentialDtoService>))]
public enum UpdateAzureCredentialDtoService
{
    [EnumMember(Value = "speech")]
    Speech,

    [EnumMember(Value = "blob_storage")]
    BlobStorage,
}
