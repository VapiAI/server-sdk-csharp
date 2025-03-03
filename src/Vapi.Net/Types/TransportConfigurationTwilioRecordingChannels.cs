using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TransportConfigurationTwilioRecordingChannels>))]
public enum TransportConfigurationTwilioRecordingChannels
{
    [EnumMember(Value = "mono")]
    Mono,

    [EnumMember(Value = "dual")]
    Dual,
}
