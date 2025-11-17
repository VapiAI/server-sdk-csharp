using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<DeveloperMessageRole>))]
public enum DeveloperMessageRole
{
    [EnumMember(Value = "developer")]
    Developer,
}
