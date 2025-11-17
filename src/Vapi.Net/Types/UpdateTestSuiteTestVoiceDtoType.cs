using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<UpdateTestSuiteTestVoiceDtoType>))]
public enum UpdateTestSuiteTestVoiceDtoType
{
    [EnumMember(Value = "voice")]
    Voice,
}
