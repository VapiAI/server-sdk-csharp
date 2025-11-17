using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<InflectionAiModelModel>))]
public enum InflectionAiModelModel
{
    [EnumMember(Value = "inflection_3_pi")]
    Inflection3Pi,
}
