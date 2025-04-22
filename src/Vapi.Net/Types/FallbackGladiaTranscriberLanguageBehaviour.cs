using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackGladiaTranscriberLanguageBehaviour>))]
public enum FallbackGladiaTranscriberLanguageBehaviour
{
    [EnumMember(Value = "manual")]
    Manual,

    [EnumMember(Value = "automatic single language")]
    AutomaticSingleLanguage,

    [EnumMember(Value = "automatic multiple languages")]
    AutomaticMultipleLanguages,
}
