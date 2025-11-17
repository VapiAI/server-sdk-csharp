using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageLanguageChangeDetectedType>))]
public enum ServerMessageLanguageChangeDetectedType
{
    [EnumMember(Value = "language-change-detected")]
    LanguageChangeDetected,
}
