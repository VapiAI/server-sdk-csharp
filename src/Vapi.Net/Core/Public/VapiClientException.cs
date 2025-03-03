using System;

namespace Vapi.Net;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class VapiClientException(string message, Exception? innerException = null)
    : Exception(message, innerException);
