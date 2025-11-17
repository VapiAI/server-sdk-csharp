using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GoHighLevelMcpCredentialProvider>))]
public enum GoHighLevelMcpCredentialProvider
{
    [EnumMember(Value = "ghl.oauth2-authorization")]
    GhlOauth2Authorization,
}
