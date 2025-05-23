using System.Net.Http;
using System.Threading;
using global::System.Threading.Tasks;
using Vapi.Net.Core;

namespace Vapi.Net;

public partial class VapiClient
{
    private readonly RawClient _client;

    public VapiClient(string token, ClientOptions? clientOptions = null)
    {
        var defaultHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {token}" },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Vapi.Net" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "Vapi.Net/0.8.1" },
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

    public async global::System.Threading.Tasks.Task PrometheusControllerIndexAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "prometheus_metrics",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new VapiClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}
