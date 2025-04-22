using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CerebrasModelModel>))]
public enum CerebrasModelModel
{
    [EnumMember(Value = "llama3.1-8b")]
    Llama318B,

    [EnumMember(Value = "llama-3.3-70b")]
    Llama3370B,
}
