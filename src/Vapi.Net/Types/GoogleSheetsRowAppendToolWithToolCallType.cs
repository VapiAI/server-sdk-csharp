using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GoogleSheetsRowAppendToolWithToolCallType>))]
public enum GoogleSheetsRowAppendToolWithToolCallType
{
    [EnumMember(Value = "google.sheets.row.append")]
    GoogleSheetsRowAppend,
}
