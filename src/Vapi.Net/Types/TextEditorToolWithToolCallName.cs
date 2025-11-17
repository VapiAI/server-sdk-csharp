using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TextEditorToolWithToolCallName>))]
public enum TextEditorToolWithToolCallName
{
    [EnumMember(Value = "str_replace_editor")]
    StrReplaceEditor,
}
