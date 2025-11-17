using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TestSuitePhoneNumberProvider>))]
public enum TestSuitePhoneNumberProvider
{
    [EnumMember(Value = "test-suite")]
    TestSuite,
}
