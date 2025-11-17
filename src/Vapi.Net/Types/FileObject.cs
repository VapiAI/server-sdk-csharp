using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FileObject>))]
public enum FileObject
{
    [EnumMember(Value = "file")]
    File,
}
