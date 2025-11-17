using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CreateTextEditorToolDtoSubType>))]
public enum CreateTextEditorToolDtoSubType
{
    [EnumMember(Value = "text_editor_20241022")]
    TextEditor20241022,
}
