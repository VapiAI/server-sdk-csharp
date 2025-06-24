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
                { "Authorization", $"Bearer {token}" },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Vapi.Net" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "Vapi.Net/0.8.2" },
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
        Calls = new CallsClient(_client);
        Chats = new ChatsClient(_client);
        Campaigns = new CampaignsClient(_client);
        Sessions = new SessionsClient(_client);
        Assistants = new AssistantsClient(_client);
        PhoneNumbers = new PhoneNumbersClient(_client);
        Tools = new ToolsClient(_client);
        Files = new FilesClient(_client);
        KnowledgeBases = new KnowledgeBasesClient(_client);
        Workflow = new WorkflowClient(_client);
        Squads = new SquadsClient(_client);
        TestSuites = new TestSuitesClient(_client);
        TestSuiteTests = new TestSuiteTestsClient(_client);
        TestSuiteRuns = new TestSuiteRunsClient(_client);
        Analytics = new AnalyticsClient(_client);
        Logs = new LogsClient(_client);
    }

    public CallsClient Calls { get; }

    public ChatsClient Chats { get; }

    public CampaignsClient Campaigns { get; }

    public SessionsClient Sessions { get; }

    public AssistantsClient Assistants { get; }

    public PhoneNumbersClient PhoneNumbers { get; }

    public ToolsClient Tools { get; }

    public FilesClient Files { get; }

    public KnowledgeBasesClient KnowledgeBases { get; }

    public WorkflowClient Workflow { get; }

    public SquadsClient Squads { get; }

    public TestSuitesClient TestSuites { get; }

    public TestSuiteTestsClient TestSuiteTests { get; }

    public TestSuiteRunsClient TestSuiteRuns { get; }

    public AnalyticsClient Analytics { get; }

    public LogsClient Logs { get; }
}
