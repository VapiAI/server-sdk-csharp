using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AssemblyAiTranscriberLanguage>))]
public enum AssemblyAiTranscriberLanguage
{
    [EnumMember(Value = "en")]
    En,
}
