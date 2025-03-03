using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TestSuiteRunControllerFindAllPaginatedRequestSortOrder>))]
public enum TestSuiteRunControllerFindAllPaginatedRequestSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}
