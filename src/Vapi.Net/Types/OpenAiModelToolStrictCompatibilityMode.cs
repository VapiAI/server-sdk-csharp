using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<OpenAiModelToolStrictCompatibilityMode>))]
public enum OpenAiModelToolStrictCompatibilityMode
{
    [EnumMember(Value = "strip-parameters-with-unsupported-validation")]
    StripParametersWithUnsupportedValidation,

    [EnumMember(Value = "strip-unsupported-validation")]
    StripUnsupportedValidation,
}
