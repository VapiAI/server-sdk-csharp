using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<MakeCredentialProvider>))]
public enum MakeCredentialProvider
{
    [EnumMember(Value = "make")]
    Make,
}
