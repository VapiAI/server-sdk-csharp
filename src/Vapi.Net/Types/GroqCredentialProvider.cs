using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GroqCredentialProvider>))]
public enum GroqCredentialProvider
{
    [EnumMember(Value = "groq")]
    Groq,
}
