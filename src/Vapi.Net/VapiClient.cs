using Vapi.Net.Core;

namespace Vapi.Net;

public partial class VapiClient : IVapiClient
{
    private readonly RawClient _client;

    public VapiClient(string? token = null, ClientOptions? clientOptions = null)
    {
        clientOptions ??= new ClientOptions();
        var platformHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Vapi.Net" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "Vapi.Net/1.0.0" },
            }
        );
        foreach (var header in platformHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        var clientOptionsWithAuth = clientOptions.Clone();
        var authHeaders = new Headers(
            new Dictionary<string, string>() { { "Authorization", $"Bearer {token ?? ""}" } }
        );
        foreach (var header in authHeaders)
        {
            clientOptionsWithAuth.Headers[header.Key] = header.Value;
        }
        _client = new RawClient(clientOptionsWithAuth);
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

    public IAssistantsClient Assistants { get; }

    public ISquadsClient Squads { get; }

    public ICallsClient Calls { get; }

    public IChatsClient Chats { get; }

    public ICampaignsClient Campaigns { get; }

    public ISessionsClient Sessions { get; }

    public IPhoneNumbersClient PhoneNumbers { get; }

    public IToolsClient Tools { get; }

    public IFilesClient Files { get; }

    public IStructuredOutputsClient StructuredOutputs { get; }

    public IInsightClient Insight { get; }

    public IEvalClient Eval { get; }

    public IObservabilityScorecardClient ObservabilityScorecard { get; }

    public IProviderResourcesClient ProviderResources { get; }

    public IAnalyticsClient Analytics { get; }
}
