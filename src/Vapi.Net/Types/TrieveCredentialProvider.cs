using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TrieveCredentialProvider>))]
public enum TrieveCredentialProvider
{
    [EnumMember(Value = "trieve")]
    Trieve,
}
