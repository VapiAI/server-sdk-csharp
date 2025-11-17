using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CerebrasCredentialProvider>))]
public enum CerebrasCredentialProvider
{
    [EnumMember(Value = "cerebras")]
    Cerebras,
}
