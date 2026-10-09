namespace Vapi.Net;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class PaymentRequiredError(SimulationRunPaymentRequiredResponse body)
    : VapiClientApiException("PaymentRequiredError", 402, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new SimulationRunPaymentRequiredResponse Body => body;
}
