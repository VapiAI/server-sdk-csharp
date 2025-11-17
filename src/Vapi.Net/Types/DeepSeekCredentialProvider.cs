using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<DeepSeekCredentialProvider>))]
public enum DeepSeekCredentialProvider
{
    [EnumMember(Value = "deep-seek")]
    DeepSeek,
}
