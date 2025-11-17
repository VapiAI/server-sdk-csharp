using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GoogleCredentialProvider>))]
public enum GoogleCredentialProvider
{
    [EnumMember(Value = "google")]
    Google,
}
