using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<OpenRouterCredentialProvider>))]
public enum OpenRouterCredentialProvider
{
    [EnumMember(Value = "openrouter")]
    Openrouter,
}
