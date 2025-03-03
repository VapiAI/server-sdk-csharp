using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record AddVoiceToProviderDto
{
    /// <summary>
    /// This is the owner_id of your shared voice which you want to add to your provider Account from Provider Voice Library
    /// </summary>
    [JsonPropertyName("ownerId")]
    public required string OwnerId { get; set; }

    /// <summary>
    /// This is the voice_id of the shared voice which you want to add to your provider Account from Provider Voice Library
    /// </summary>
    [JsonPropertyName("voiceId")]
    public required string VoiceId { get; set; }

    /// <summary>
    /// This is the new name of the voice which you want to have once you have added voice to your provider Account from Provider Voice Library
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
