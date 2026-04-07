using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FormatPlanFormattersEnabledItemSerializer))]
public enum FormatPlanFormattersEnabledItem
{
    [EnumMember(Value = "markdown")]
    Markdown,

    [EnumMember(Value = "asterisk")]
    Asterisk,

    [EnumMember(Value = "quote")]
    Quote,

    [EnumMember(Value = "dash")]
    Dash,

    [EnumMember(Value = "newline")]
    Newline,

    [EnumMember(Value = "colon")]
    Colon,

    [EnumMember(Value = "acronym")]
    Acronym,

    [EnumMember(Value = "dollarAmount")]
    DollarAmount,

    [EnumMember(Value = "email")]
    Email,

    [EnumMember(Value = "date")]
    Date,

    [EnumMember(Value = "time")]
    Time,

    [EnumMember(Value = "distance")]
    Distance,

    [EnumMember(Value = "unit")]
    Unit,

    [EnumMember(Value = "percentage")]
    Percentage,

    [EnumMember(Value = "phoneNumber")]
    PhoneNumber,

    [EnumMember(Value = "number")]
    Number,

    [EnumMember(Value = "stripAsterisk")]
    StripAsterisk,
}

internal class FormatPlanFormattersEnabledItemSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FormatPlanFormattersEnabledItem>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FormatPlanFormattersEnabledItem
    > _stringToEnum = new()
    {
        { "markdown", FormatPlanFormattersEnabledItem.Markdown },
        { "asterisk", FormatPlanFormattersEnabledItem.Asterisk },
        { "quote", FormatPlanFormattersEnabledItem.Quote },
        { "dash", FormatPlanFormattersEnabledItem.Dash },
        { "newline", FormatPlanFormattersEnabledItem.Newline },
        { "colon", FormatPlanFormattersEnabledItem.Colon },
        { "acronym", FormatPlanFormattersEnabledItem.Acronym },
        { "dollarAmount", FormatPlanFormattersEnabledItem.DollarAmount },
        { "email", FormatPlanFormattersEnabledItem.Email },
        { "date", FormatPlanFormattersEnabledItem.Date },
        { "time", FormatPlanFormattersEnabledItem.Time },
        { "distance", FormatPlanFormattersEnabledItem.Distance },
        { "unit", FormatPlanFormattersEnabledItem.Unit },
        { "percentage", FormatPlanFormattersEnabledItem.Percentage },
        { "phoneNumber", FormatPlanFormattersEnabledItem.PhoneNumber },
        { "number", FormatPlanFormattersEnabledItem.Number },
        { "stripAsterisk", FormatPlanFormattersEnabledItem.StripAsterisk },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FormatPlanFormattersEnabledItem,
        string
    > _enumToString = new()
    {
        { FormatPlanFormattersEnabledItem.Markdown, "markdown" },
        { FormatPlanFormattersEnabledItem.Asterisk, "asterisk" },
        { FormatPlanFormattersEnabledItem.Quote, "quote" },
        { FormatPlanFormattersEnabledItem.Dash, "dash" },
        { FormatPlanFormattersEnabledItem.Newline, "newline" },
        { FormatPlanFormattersEnabledItem.Colon, "colon" },
        { FormatPlanFormattersEnabledItem.Acronym, "acronym" },
        { FormatPlanFormattersEnabledItem.DollarAmount, "dollarAmount" },
        { FormatPlanFormattersEnabledItem.Email, "email" },
        { FormatPlanFormattersEnabledItem.Date, "date" },
        { FormatPlanFormattersEnabledItem.Time, "time" },
        { FormatPlanFormattersEnabledItem.Distance, "distance" },
        { FormatPlanFormattersEnabledItem.Unit, "unit" },
        { FormatPlanFormattersEnabledItem.Percentage, "percentage" },
        { FormatPlanFormattersEnabledItem.PhoneNumber, "phoneNumber" },
        { FormatPlanFormattersEnabledItem.Number, "number" },
        { FormatPlanFormattersEnabledItem.StripAsterisk, "stripAsterisk" },
    };

    public override FormatPlanFormattersEnabledItem Read(
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
        FormatPlanFormattersEnabledItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FormatPlanFormattersEnabledItem ReadAsPropertyName(
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
        FormatPlanFormattersEnabledItem value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
