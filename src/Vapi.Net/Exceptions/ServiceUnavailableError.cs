namespace Vapi.Net;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ServiceUnavailableError(object body)
    : VapiClientApiException("ServiceUnavailableError", 503, body);
