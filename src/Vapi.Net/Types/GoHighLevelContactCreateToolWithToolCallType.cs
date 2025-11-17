using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GoHighLevelContactCreateToolWithToolCallType>))]
public enum GoHighLevelContactCreateToolWithToolCallType
{
    [EnumMember(Value = "gohighlevel.contact.create")]
    GohighlevelContactCreate,
}
