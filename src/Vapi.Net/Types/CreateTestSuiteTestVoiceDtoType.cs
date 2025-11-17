using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CreateTestSuiteTestVoiceDtoType>))]
public enum CreateTestSuiteTestVoiceDtoType
{
    [EnumMember(Value = "voice")]
    Voice,
}
