using global::System.Net.Http;

namespace Vapi.Net.Core;

internal static class HttpMethodExtensions
{
    public static readonly HttpMethod Patch = new("PATCH");
}
