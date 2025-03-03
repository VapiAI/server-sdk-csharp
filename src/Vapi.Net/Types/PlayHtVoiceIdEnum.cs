using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<PlayHtVoiceIdEnum>))]
public enum PlayHtVoiceIdEnum
{
    [EnumMember(Value = "jennifer")]
    Jennifer,

    [EnumMember(Value = "melissa")]
    Melissa,

    [EnumMember(Value = "will")]
    Will,

    [EnumMember(Value = "chris")]
    Chris,

    [EnumMember(Value = "matt")]
    Matt,

    [EnumMember(Value = "jack")]
    Jack,

    [EnumMember(Value = "ruby")]
    Ruby,

    [EnumMember(Value = "davis")]
    Davis,

    [EnumMember(Value = "donna")]
    Donna,

    [EnumMember(Value = "michael")]
    Michael,
}
