using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GoHighLevelCredentialProvider>))]
public enum GoHighLevelCredentialProvider
{
    [EnumMember(Value = "gohighlevel")]
    Gohighlevel,
}
