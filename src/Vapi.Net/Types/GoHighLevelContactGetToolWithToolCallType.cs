using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GoHighLevelContactGetToolWithToolCallType>))]
public enum GoHighLevelContactGetToolWithToolCallType
{
    [EnumMember(Value = "gohighlevel.contact.get")]
    GohighlevelContactGet,
}
