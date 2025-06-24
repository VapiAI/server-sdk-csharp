using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<UpdateSessionDtoStatus>))]
public enum UpdateSessionDtoStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "completed")]
    Completed,
}
