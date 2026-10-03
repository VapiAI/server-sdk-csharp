namespace Vapi.Net;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class UnauthorizedError(object body)
    : VapiClientApiException("UnauthorizedError", 401, body);
