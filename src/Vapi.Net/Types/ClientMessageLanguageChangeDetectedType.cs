using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageLanguageChangeDetectedType>))]
public enum ClientMessageLanguageChangeDetectedType
{
    [EnumMember(Value = "language-change-detected")]
    LanguageChangeDetected,
}
