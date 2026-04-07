namespace Vapi.Net;

public partial interface IVapiClient
{
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
