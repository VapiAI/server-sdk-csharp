using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FilterDateTypeColumnOnCallTableColumn>))]
public enum FilterDateTypeColumnOnCallTableColumn
{
    [EnumMember(Value = "startedAt")]
    StartedAt,

    [EnumMember(Value = "endedAt")]
    EndedAt,
}
