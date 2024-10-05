using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(StringEnumSerializer<GladiaTranscriberLanguageBehaviour>))]
public enum GladiaTranscriberLanguageBehaviour
{
    [EnumMember(Value = "manual")]
    Manual,

    [EnumMember(Value = "automatic single language")]
    AutomaticSingleLanguage,

    [EnumMember(Value = "automatic multiple languages")]
    AutomaticMultipleLanguages,
}