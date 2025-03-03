using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TestSuiteTestControllerFindAllPaginatedRequestSortOrder>))]
public enum TestSuiteTestControllerFindAllPaginatedRequestSortOrder
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,
}
