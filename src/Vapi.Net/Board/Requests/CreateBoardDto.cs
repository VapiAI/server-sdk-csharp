using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateBoardDto
{
    /// <summary>
    /// This is the contents of the Board, which is an array of objects defining the type, contents, and position of the widgets on the Board.
    /// </summary>
    [JsonPropertyName("items")]
    public IEnumerable<OneOf<BoardInsightItem, BoardMetricWidgetItem>>? Items { get; set; }

    /// <summary>
    /// This is the name of the Board.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is the layout of the Board.
    /// </summary>
    [JsonPropertyName("layout")]
    public required BoardLayout Layout { get; set; }

    /// <summary>
    /// This is the timerange override for the board.
    /// By default, individual insights have their own timerange.
    /// This is a global override for the board which will be passed to all insights on the board.
    /// </summary>
    [JsonPropertyName("timeRangeOverride")]
    public InsightTimeRangeWithStep? TimeRangeOverride { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
