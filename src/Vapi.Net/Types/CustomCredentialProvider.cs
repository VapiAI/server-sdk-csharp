using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CustomCredentialProvider>))]
public enum CustomCredentialProvider
{
    [EnumMember(Value = "custom-credential")]
    CustomCredential,
}
