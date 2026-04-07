using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TestSuitePhoneNumberProviderSerializer))]
public enum TestSuitePhoneNumberProvider
{
    [EnumMember(Value = "test-suite")]
    TestSuite,
}

internal class TestSuitePhoneNumberProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TestSuitePhoneNumberProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TestSuitePhoneNumberProvider
    > _stringToEnum = new() { { "test-suite", TestSuitePhoneNumberProvider.TestSuite } };

    private static readonly global::System.Collections.Generic.Dictionary<
        TestSuitePhoneNumberProvider,
        string
    > _enumToString = new() { { TestSuitePhoneNumberProvider.TestSuite, "test-suite" } };

    public override TestSuitePhoneNumberProvider Read(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception("The JSON value could not be read as a string.");
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void Write(
        global::System.Text.Json.Utf8JsonWriter writer,
        TestSuitePhoneNumberProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TestSuitePhoneNumberProvider ReadAsPropertyName(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception(
                "The JSON property name could not be read as a string."
            );
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void WriteAsPropertyName(
        global::System.Text.Json.Utf8JsonWriter writer,
        TestSuitePhoneNumberProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
