using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackAssemblyAiTranscriberLanguage>))]
public enum FallbackAssemblyAiTranscriberLanguage
{
    [EnumMember(Value = "en")]
    En,
}
