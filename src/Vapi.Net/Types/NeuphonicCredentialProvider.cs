using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<NeuphonicCredentialProvider>))]
public enum NeuphonicCredentialProvider
{
    [EnumMember(Value = "neuphonic")]
    Neuphonic,
}
