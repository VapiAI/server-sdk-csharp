using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FileStatus>))]
public enum FileStatus
{
    [EnumMember(Value = "processing")]
    Processing,

    [EnumMember(Value = "done")]
    Done,

    [EnumMember(Value = "failed")]
    Failed,
}
