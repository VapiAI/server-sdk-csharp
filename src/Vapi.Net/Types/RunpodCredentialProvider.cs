using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<RunpodCredentialProvider>))]
public enum RunpodCredentialProvider
{
    [EnumMember(Value = "runpod")]
    Runpod,
}
