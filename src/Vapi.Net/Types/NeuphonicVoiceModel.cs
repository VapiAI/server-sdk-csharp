using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<NeuphonicVoiceModel>))]
public enum NeuphonicVoiceModel
{
    [EnumMember(Value = "neu_hq")]
    NeuHq,

    [EnumMember(Value = "neu_fast")]
    NeuFast,
}
