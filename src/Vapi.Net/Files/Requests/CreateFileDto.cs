using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateFileDto
{
    public required FileParameter File { get; set; }

    /// <summary>
    /// Optional product flow that owns the uploaded file.
    /// </summary>
    public CreateFilesRequestPurpose? Purpose { get; set; }

    /// <summary>
    /// Optional JSON-encoded metadata for multipart uploads.
    /// </summary>
    public string? Metadata { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
