## 0.11.0 - 2025-11-19
* feat: add dial timeout configuration and conversation type to transfer and SMS transport
* Enhance TransferPlan with configurable dial timeout for SIP operations and introduce conversation type support for TwilioSmsChatTransport. These additions provide better control over call transfer behavior and enable explicit chat type specification for SMS transport.
* Key changes:
* Add DialTimeout property to TransferPlan for configuring SIP dial operation timeout (default 60 seconds)
* Add ConversationType property to TwilioSmsChatTransport with new enum for chat specification
* Update project GUIDs in solution file for project reference alignment
* Adjust User-Agent header to use dynamic versioning
* 🌿 Generated with Fern

