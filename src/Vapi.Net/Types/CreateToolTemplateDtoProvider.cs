using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CreateToolTemplateDtoProvider>))]
public enum CreateToolTemplateDtoProvider
{
    [EnumMember(Value = "make")]
    Make,

    [EnumMember(Value = "gohighlevel")]
    Gohighlevel,

    [EnumMember(Value = "function")]
    Function,
}
