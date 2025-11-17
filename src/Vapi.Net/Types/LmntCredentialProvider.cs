using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<LmntCredentialProvider>))]
public enum LmntCredentialProvider
{
    [EnumMember(Value = "lmnt")]
    Lmnt,
}
