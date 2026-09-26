using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ListFilesRequest
{
    /// <summary>
    /// Only return files with this purpose. When omitted, files of every purpose except composer attachments are returned.
    /// </summary>
    [JsonIgnore]
    public ListFilesRequestPurpose? Purpose { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
