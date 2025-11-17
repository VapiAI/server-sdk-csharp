using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ByoSipTrunkCredentialProvider>))]
public enum ByoSipTrunkCredentialProvider
{
    [EnumMember(Value = "byo-sip-trunk")]
    ByoSipTrunk,
}
