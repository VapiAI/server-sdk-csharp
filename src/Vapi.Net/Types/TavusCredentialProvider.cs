using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TavusCredentialProvider>))]
public enum TavusCredentialProvider
{
    [EnumMember(Value = "tavus")]
    Tavus,
}
