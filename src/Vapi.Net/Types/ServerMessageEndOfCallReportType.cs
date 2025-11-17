using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageEndOfCallReportType>))]
public enum ServerMessageEndOfCallReportType
{
    [EnumMember(Value = "end-of-call-report")]
    EndOfCallReport,
}
