using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GoHighLevelCalendarEventCreateToolWithToolCallType>))]
public enum GoHighLevelCalendarEventCreateToolWithToolCallType
{
    [EnumMember(Value = "gohighlevel.calendar.event.create")]
    GohighlevelCalendarEventCreate,
}
