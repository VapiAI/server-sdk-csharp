using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<VapiModelProvider>))]
public enum VapiModelProvider
{
    [EnumMember(Value = "vapi")]
    Vapi,
}
