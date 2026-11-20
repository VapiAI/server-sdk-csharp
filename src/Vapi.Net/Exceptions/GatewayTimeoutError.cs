namespace Vapi.Net;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class GatewayTimeoutError(object body)
    : VapiClientApiException("GatewayTimeoutError", 504, body);
