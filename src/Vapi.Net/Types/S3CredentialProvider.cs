using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<S3CredentialProvider>))]
public enum S3CredentialProvider
{
    [EnumMember(Value = "s3")]
    S3,
}
