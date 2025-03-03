using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FileStatus>))]
public enum FileStatus
{
    [EnumMember(Value = "indexed")]
    Indexed,

    [EnumMember(Value = "not_indexed")]
    NotIndexed,
}
