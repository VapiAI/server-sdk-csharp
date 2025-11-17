using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<UpdateTextEditorToolDtoName>))]
public enum UpdateTextEditorToolDtoName
{
    [EnumMember(Value = "str_replace_editor")]
    StrReplaceEditor,
}
