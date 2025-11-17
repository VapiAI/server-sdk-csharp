using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GoHighLevelCalendarAvailabilityToolWithToolCallType>))]
public enum GoHighLevelCalendarAvailabilityToolWithToolCallType
{
    [EnumMember(Value = "gohighlevel.calendar.availability.check")]
    GohighlevelCalendarAvailabilityCheck,
}
