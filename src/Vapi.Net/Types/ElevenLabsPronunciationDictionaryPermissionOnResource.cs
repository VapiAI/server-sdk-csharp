using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ElevenLabsPronunciationDictionaryPermissionOnResource>))]
public enum ElevenLabsPronunciationDictionaryPermissionOnResource
{
    [EnumMember(Value = "admin")]
    Admin,

    [EnumMember(Value = "editor")]
    Editor,

    [EnumMember(Value = "viewer")]
    Viewer,
}
