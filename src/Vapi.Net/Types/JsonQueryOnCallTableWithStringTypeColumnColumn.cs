using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<JsonQueryOnCallTableWithStringTypeColumnColumn>))]
public enum JsonQueryOnCallTableWithStringTypeColumnColumn
{
    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "artifact.structuredOutputs[OutputID]")]
    ArtifactStructuredOutputsOutputId,
}
