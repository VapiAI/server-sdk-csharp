using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TwilioSmsChatTransportConversationType>))]
public enum TwilioSmsChatTransportConversationType
{
    [EnumMember(Value = "chat")]
    Chat,
}
