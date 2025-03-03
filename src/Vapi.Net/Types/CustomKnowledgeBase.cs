using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CustomKnowledgeBase
{
    /// <summary>
    /// This is where the knowledge base request will be sent.
    ///
    /// Request Example:
    ///
    /// POST https://{server.url}
    /// Content-Type: application/json
    ///
    /// {
    ///   "messsage": {
    ///     "type": "knowledge-base-request",
    ///     "messages": [
    ///       {
    ///         "role": "user",
    ///         "content": "Why is ocean blue?"
    ///       }
    ///     ],
    ///     ...other metadata about the call...
    ///   }
    /// }
    ///
    /// Response Expected:
    /// ```
    /// {
    ///   "message": {
    ///      "role": "assistant",
    ///      "content": "The ocean is blue because water absorbs everything but blue.",
    ///   }, // YOU CAN RETURN THE EXACT RESPONSE TO SPEAK
    ///   "documents": [
    ///     {
    ///       "content": "The ocean is blue primarily because water absorbs colors in the red part of the light spectrum and scatters the blue light, making it more visible to our eyes.",
    ///       "similarity": 1
    ///     },
    ///     {
    ///       "content": "Blue light is scattered more by the water molecules than other colors, enhancing the blue appearance of the ocean.",
    ///       "similarity": .5
    ///     }
    ///   ] // OR, YOU CAN RETURN AN ARRAY OF DOCUMENTS THAT WILL BE SENT TO THE MODEL
    /// }
    /// ```
    /// </summary>
    [JsonPropertyName("server")]
    public required Server Server { get; set; }

    /// <summary>
    /// This is the id of the knowledge base.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the org id of the knowledge base.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
