using Vapi.Net.Core;

namespace Vapi.Net;

public partial class VapiClient
{
    private readonly RawClient _client;

    public VapiClient(string? token = null, ClientOptions? clientOptions = null)
    {
        var defaultHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {token ?? ""}" },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Vapi.Net" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "Vapi.Net/0.10.0" },
            }
        );
        clientOptions ??= new ClientOptions();
        foreach (var header in defaultHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        _client = new RawClient(clientOptions);
        Assistants = new AssistantsClient(_client);
        Squads = new SquadsClient(_client);
        Calls = new CallsClient(_client);
        Chats = new ChatsClient(_client);
        Campaigns = new CampaignsClient(_client);
        Sessions = new SessionsClient(_client);
        PhoneNumbers = new PhoneNumbersClient(_client);
        Tools = new ToolsClient(_client);
        Files = new FilesClient(_client);
        StructuredOutputs = new StructuredOutputsClient(_client);
        Insight = new InsightClient(_client);
        Eval = new EvalClient(_client);
        ObservabilityScorecard = new ObservabilityScorecardClient(_client);
        ProviderResources = new ProviderResourcesClient(_client);
        Analytics = new AnalyticsClient(_client);
    }

    public AssistantsClient Assistants { get; }

    public SquadsClient Squads { get; }

    public CallsClient Calls { get; }

    public ChatsClient Chats { get; }

    public CampaignsClient Campaigns { get; }

    public SessionsClient Sessions { get; }

    public PhoneNumbersClient PhoneNumbers { get; }

    public ToolsClient Tools { get; }

    public FilesClient Files { get; }

    public StructuredOutputsClient StructuredOutputs { get; }

    public InsightClient Insight { get; }

    public EvalClient Eval { get; }

    public ObservabilityScorecardClient ObservabilityScorecard { get; }

    public ProviderResourcesClient ProviderResources { get; }

    public AnalyticsClient Analytics { get; }
}
