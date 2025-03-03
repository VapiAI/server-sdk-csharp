using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<VoiceLibraryGender>))]
public enum VoiceLibraryGender
{
    [EnumMember(Value = "male")]
    Male,

    [EnumMember(Value = "female")]
    Female,
}
