using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TwilioVoicemailDetectionVoicemailDetectionTypesItem>))]
public enum TwilioVoicemailDetectionVoicemailDetectionTypesItem
{
    [EnumMember(Value = "machine_start")]
    MachineStart,

    [EnumMember(Value = "human")]
    Human,

    [EnumMember(Value = "fax")]
    Fax,

    [EnumMember(Value = "unknown")]
    Unknown,

    [EnumMember(Value = "machine_end_beep")]
    MachineEndBeep,

    [EnumMember(Value = "machine_end_silence")]
    MachineEndSilence,

    [EnumMember(Value = "machine_end_other")]
    MachineEndOther,
}
