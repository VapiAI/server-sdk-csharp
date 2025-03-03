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
                { "User-Agent", "Vapi.Net/0.5.0" },
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
        Assistants = new AssistantsClient(_client);
        PhoneNumbers = new PhoneNumbersClient(_client);
        Squads = new SquadsClient(_client);
        KnowledgeBases = new KnowledgeBasesClient(_client);
        Blocks = new BlocksClient(_client);
        Tools = new ToolsClient(_client);
        Files = new FilesClient(_client);
        Analytics = new AnalyticsClient(_client);
        Logs = new LogsClient(_client);
        TestSuites = new TestSuitesClient(_client);
        TestSuiteTests = new TestSuiteTestsClient(_client);
        TestSuiteRuns = new TestSuiteRunsClient(_client);
    }

    public CallsClient Calls { get; init; }

    public AssistantsClient Assistants { get; init; }

    public PhoneNumbersClient PhoneNumbers { get; init; }

    public SquadsClient Squads { get; init; }

    public KnowledgeBasesClient KnowledgeBases { get; init; }

    public BlocksClient Blocks { get; init; }

    public ToolsClient Tools { get; init; }

    public FilesClient Files { get; init; }

    public AnalyticsClient Analytics { get; init; }

    public LogsClient Logs { get; init; }

    public TestSuitesClient TestSuites { get; init; }

    public TestSuiteTestsClient TestSuiteTests { get; init; }

    public TestSuiteRunsClient TestSuiteRuns { get; init; }
}
