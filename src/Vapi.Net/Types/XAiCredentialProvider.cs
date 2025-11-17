using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<XAiCredentialProvider>))]
public enum XAiCredentialProvider
{
    [EnumMember(Value = "xai")]
    Xai,
}
