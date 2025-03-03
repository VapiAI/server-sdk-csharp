using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record SyncVoiceLibraryDto
{
    /// <summary>
    /// List of providers you want to sync.
    /// </summary>
    [JsonPropertyName("providers")]
    public IEnumerable<SyncVoiceLibraryDtoProvidersItem>? Providers { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
