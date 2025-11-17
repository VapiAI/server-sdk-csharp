using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CreateTextEditorToolDtoName>))]
public enum CreateTextEditorToolDtoName
{
    [EnumMember(Value = "str_replace_editor")]
    StrReplaceEditor,
}
