## [3.0.0] - 2026-10-09
### Breaking Changes
- **`CreateCampaignDto`** has been removed; callers that construct or reference this type must migrate to the updated campaign creation API.
- **`CreateTrieveKnowledgeBaseDto`** has been removed; update any code that instantiates or references this record.
- **`FallbackGladiaTranscriberLanguages`** enum has been removed; replace usages with the current transcriber language type.
- **`FallbackVapiVoiceVoiceId`** enum has been removed; replace usages with the current Vapi voice ID type.
- **`ByoSipTrunkCredential.SbcConfiguration`** property has been removed; remove any references to this field. Additionally, `EvalGroqModelModel.MetaLlamaLlama4Maverick17B128EInstruct` has been removed from the enum.

### Breaking Changes
- **`GladiaTranscriberLanguages`** enum has been removed; update any references to this type and its values.
- **`VapiVoiceVoiceId`** enum has been removed; update any references to this type and its values.
- **`TrieveKnowledgeBase`**, **`TrieveKnowledgeBaseChunkPlan`**, **`TrieveKnowledgeBaseSearchPlan`**, and **`UpdateTrieveKnowledgeBaseDto`** records have been removed; remove or replace any usages of these types.
- **`GroqModelModel.MetaLlamaLlama4Maverick17B128EInstruct`** enum value has been removed; update any switch expressions or assignments referencing this value.

### Added
- **`CreateCallDto.AssistantVersion`** and **`CreateCallDto.SquadVersion`** — new optional properties to pin a call to a specific assistant or squad version.
- **`CreateCallDto.Transport`** — new optional property to specify the transport configuration for a call.

### Breaking Changes
- **`ICampaignsClient.CampaignControllerUpdateAsync`** now accepts `CampaignControllerUpdateRequest` instead of `UpdateCampaignDto`; replace `UpdateCampaignDto` with `CampaignControllerUpdateRequest` at all call sites.
- **`IFilesClient.ListAsync`** now requires a `ListFilesRequest` parameter; pass a `new ListFilesRequest()` (with optional `Purpose` filter) at all call sites.

### Added
- **Six new V2 campaign methods** on `ICampaignsClient`: `CampaignControllerFindAllV2Async`, `CampaignControllerCreateV2Async`, `CampaignControllerFindOneV2Async`, `CampaignControllerRemoveV2Async`, `CampaignControllerUpdateV2Async`, and `CampaignControllerGetCampaignV2ContactsAsync`.
- **`XaiModel.ToolRefs`** — new optional property (`IEnumerable<ToolRef>?`) for version-pinned tool references; when the same `toolId` appears in both `ToolIds` and `ToolRefs`, the `ToolRefs` pin takes precedence.
- **`sortBy` query parameter** added to list/paginated endpoints across `ChatsClient`, `EvalClient`, `InsightClient`, `ObservabilityScorecardClient`, `PhoneNumbersClient`, `ProviderResourcesClient`, and `SessionsClient`.

### Changed
- **`EvalClient`** now throws a typed `ForbiddenError` exception when the API returns HTTP 403, instead of a generic `VapiClientApiException`.

### Breaking Changes
- **`IStructuredOutputsClient.StructuredOutputControllerRunAsync`** now returns `WithRawResponseTask<OneOf<StructuredOutputRerunResponse, StructuredOutputControllerRunResponseOne>>` instead of `WithRawResponseTask<StructuredOutput>`; update call sites to handle the discriminated union result.
- **`CerebrasModelModel.Llama3370B`** enum value has been removed; replace any references with a supported model value.

### Added
- **`CartesiaTranscriberModel.Ink2`** — new `"ink-2"` transcriber model option for Cartesia.
- **`ListSquadsRequest.IdAny`** — new filter parameter to retrieve squads matching any of the specified IDs.

### Changed
- XML doc comments added or updated across all tool DTO types, `BackoffPlan`, `CallHookCustomerSpeechTimeout`, and `IStructuredOutputsClient` interface methods to improve IntelliSense documentation.

### Added
- **`FallbackCartesiaTranscriberModel.Ink2`** — new `ink-2` model value is now available for Cartesia fallback transcription.
- **`FallbackSonioxTranscriberModel.SttRtV5`** — new `stt-rt-v5` model value is now available for Soniox fallback transcription.
- **`ServerMessageCallArtifactUpload`** and **`ServerMessageCampaignPredial`** — two new variants added to the `ServerMessage.Message` union.
- **`ServerMessageResponseCampaignPredial`** — new variant added to the `ServerMessageResponse.MessageResponse` union.

### Changed
- **`ElevenLabsVoice` and `FallbackElevenLabsVoice`** — doc comments for `SimilarityBoost`, `Style`, `UseSpeakerBoost`, `Speed`, `OptimizeStreamingLatency`, `EnableSsmlParsing`, and `AutoMode` now note these properties are ignored by `eleven_v4_turbo`; `Language` now documents Flash v2.5 and v4 Turbo support.
- **`OpenAiVoice` and `FallbackOpenAiVoice`** — `VoiceId` doc updated to reflect GPT-Live-only voices (`quartz`, `ripple`, `vesper`, and others) replacing the previous realtime-model note.

### Added
- **`SonioxTranscriberModel.SttRtV5`** — new Soniox transcriber model value `stt-rt-v5` is now available for selection.
- **`UpdateCampaignDtoStatus.Cancelled`** — new campaign status value `cancelled` can now be used when updating a campaign.

### Changed
- **`SipAuthentication.Realm`** — documentation clarifies that the default SIP realm is region-specific (e.g. `sip.vapi.ai` for US, `sip.eu.vapi.ai` for EU).
- **`TransferPlan.FallbackPlan`** — documentation expanded to describe SIP cold-transfer fallback behavior when transfer outcome detection is enabled.
- **XML doc comments** added to `SipAuthentication`, `SipTrunkGateway`, `SubscriptionLimits`, `ToolMessageDelayed`, `TransferPlan`, and all `Update*ToolDto` types for improved IntelliSense discoverability.

### Added
- **`BoardClient`** — new client (`IBoardClient`) for the `reporting/board` resource, supporting list, create, get, delete, update, and metrics-overview operations.
- **`AssistantControllerValidateBackgroundSoundUrlAsync`** — new method on `AssistantsClient` / `IAssistantsClient` that validates a background sound URL by performing a ranged media request; accepts the new `ValidateBackgroundSoundUrlDto` and returns `BackgroundSoundUrlValidationResult`.
- **`UpdateAssistantDtoServerMessagesItem.CallArtifactUpload`** — new enum value (`"call.artifact.upload"`) for subscribing to call artifact upload server messages.
- **`ConflictError` (HTTP 409) handling** — `AssistantsClient.CreateAsync` now throws a typed `ConflictError` on 409 responses instead of a generic `VapiClientApiException`.

### Added
- **Board API** — new `CreateBoardDto`, `UpdateBoardDto`, `BoardControllerFindOneRequest`, `BoardControllerRemoveRequest`, `BoardControllerFindAllRequestSortBy`, and `BoardControllerFindAllRequestSortOrder` types to support creating, updating, and querying boards with widget layouts and time-range overrides.
- **Call artifact download methods** — `CallArtifactControllerMonoRecordingDownloadAsync`, `CallArtifactControllerStereoRecordingDownloadAsync`, `CallArtifactControllerVideoRecordingDownloadAsync`, `CallArtifactControllerCustomerRecordingDownloadAsync`, `CallArtifactControllerAssistantRecordingDownloadAsync`, `CallArtifactControllerPcapDownloadAsync`, and `CallArtifactControllerCallLogsDownloadAsync` added to `ICallsClient` and `CallsClient`.
- **`CampaignControllerFindAllRequest.SortBy`** — new optional `SortBy` property (type `CampaignControllerFindAllRequestSortBy`) for sorting campaign list results by column.

### Changed
- **`CallsClient`** error handling — existing list, create, get, delete, and update methods now throw typed exceptions (`BadRequestError`, `InternalServerError`, `ServiceUnavailableError`) for specific HTTP status codes instead of always falling through to a generic `VapiClientApiException`.

### Added
- **V2 campaign request types** — `CampaignControllerFindAllV2Request`, `CampaignControllerFindOneV2Request`, `CampaignControllerGetCampaignV2ContactsRequest`, `CampaignControllerRemoveV2Request`, `CampaignControllerUpdateV2Request`, and `CampaignControllerUpdateRequest` are now available for interacting with the V2 campaign endpoints.
- **New campaign enums** — `CampaignControllerFindAllV2RequestStatus`, `CampaignControllerFindAllV2RequestSortBy`, `CampaignControllerFindAllV2RequestSortOrder`, `CampaignControllerGetCampaignV2ContactsRequestSortBy`, `CampaignControllerGetCampaignV2ContactsRequestStatusItem`, and `CampaignControllerFindAllRequestSortBy` support the new V2 filtering and sorting options.
- **`CampaignControllerFindAllRequestStatus.Cancelled` and `.Archived`** — two new status values added to the existing campaign status enum for filtering cancelled and archived campaigns.
- **`ListChatsRequest.IdAny`** — new optional property to filter chats by multiple IDs supplied as a comma-separated string.
- **`ListChatsRequest.SortBy`** — new optional `ListChatsRequestSortBy` property to control the sort column when listing chats.

### Added
- **`IKnowledgeBasesV2Client`** — new client for managing v2 knowledge bases, including file attach/detach/retry operations; exposed as `VapiClient.KnowledgeBasesV2`.
- **`ISimulationPersonalitiesClient`, `ISimulationScenariosClient`, `ISimulationRunsClient`, `ISimulationSuitesClient`, `ISimulationsClient`** — new simulation-related clients exposed on `IVapiClient` for running and managing eval simulations.
- **`ITrafficAllocationsClient`** and **`IBoardClient`** — new top-level clients exposed on `IVapiClient`.
- **Typed HTTP error exceptions** — `ConflictError` (409), `ForbiddenError` (403), `InternalServerError` (500), `PaymentRequiredError` (402), `ServiceUnavailableError` (503), and `UnauthorizedError` (401) now thrown for the corresponding non-2XX responses.
- **`ListFilesRequest`** parameter added to `IFilesClient.ListAsync` for filtering by purpose; `CreateFileDto` gains optional `Purpose` and `Metadata` fields; `InsightRunDto` gains optional `AssistantId`; `EvalControllerGetPaginatedRequest` and `InsightControllerFindAllRequest` gain optional `SortBy` properties.

### Added
- **`KnowledgeBasesV2Client`** — new client for managing knowledge bases via the v2 API, supporting list, create, get, update, and delete operations.
- **`KnowledgeBaseV2ControllerFilesGetAsync`**, **`KnowledgeBaseV2ControllerFileAttachAsync`**, **`KnowledgeBaseV2ControllerFileDetachAsync`**, and **`KnowledgeBaseV2ControllerFileRetryAsync`** — file management methods on `KnowledgeBasesV2Client` for attaching, detaching, and retrying files within a knowledge base.
- **`CreateKnowledgeBaseV2Dto`**, **`UpdateKnowledgeBaseV2Dto`**, and **`AttachKnowledgeBaseV2FileDto`** — request/DTO types for the new knowledge base v2 endpoints.
- **`ScorecardControllerGetPaginatedRequest.SortBy`** — new optional `SortBy` query parameter to control the sort column when paginating scorecards (defaults to `createdAt`).

### Added
- **`ISimulationPersonalitiesClient`** — new client for managing AI tester personalities used in simulations, with full CRUD support (`FindAll`, `Create`, `FindOne`, `Remove`, `Update`).
- **`SortBy`** optional property added to `PhoneNumberControllerFindAllPaginatedRequest`, `ProviderResourceControllerGetProviderResourcesPaginatedRequest`, `ListSessionsRequest`, and `PersonalityControllerFindAllRequest`, accepting `createdAt`, `duration`, or `cost`.
- **`SquadOverrides`** and **`IdAny`** optional filter properties added to `ListSessionsRequest` for squad-based call filtering and multi-session ID lookups.
- **New `SortBy` enums** (`PhoneNumberControllerFindAllPaginatedRequestSortBy`, `ProviderResourceControllerGetProviderResourcesPaginatedRequestSortBy`, `ListSessionsRequestSortBy`, `ScorecardControllerGetPaginatedRequestSortBy`) added to support the new sort column parameter across paginated endpoints.

### Added
- **`SimulationPersonalitiesClient`** — new client for managing simulation personalities (AI tester configurations), supporting list, create, get, update, and delete operations.
- **`ISimulationRunsClient`** — new client interface for managing simulation runs, including starting runs, cancelling runs and individual items, listing run items, and generating AI improvement suggestions.
- **`SimulationRunControllerFindAllRequest`** and **`SimulationRunControllerFindItemsRequest`** — rich request types with filtering by status, target type, date ranges, and pagination controls.
- **`PersonalityControllerFindAllRequestSortBy`** and **`PersonalityControllerFindAllRequestSortOrder`** — new enums for sorting personality list results.

### Added
- **`SimulationRunsClient`** — new client for managing simulation runs against assistants and squads, supporting list, create, get, cancel (group and item), and AI suggestion generation operations.
- **`SimulationRunControllerFindAllRequestFilterStatus`** — new enum for filtering simulation runs by status (`Passed`, `Failed`, `Running`).
- **`SimulationRunControllerFindAllRequestSortBy`** — new enum for sorting simulation runs by `CreatedAt`, `Duration`, or `Cost`.
- **`SimulationRunControllerFindAllRequestSortOrder`** — new enum for specifying sort direction (`Asc`, `Desc`) when listing simulation runs.

### Added
- **`ISimulationScenariosClient`** — new client interface for managing simulation scenarios, exposing find-all, create, find-one, update, and delete operations.
- **`ScenarioControllerFindAllRequest`** — new request record with rich filtering options (name search, pagination, date range filters) for listing scenarios.
- **`ScenarioControllerFindOneRequest`** and **`ScenarioControllerRemoveRequest`** — new request records for single-scenario retrieval and deletion.
- **New `SimulationRuns` filter and sort enums** — `SimulationRunControllerFindAllRequestStatus`, `SimulationRunControllerFindAllRequestTargetType`, `SimulationRunControllerFindItemsRequestStatus`, `SimulationRunControllerFindItemsRequestSortBy`, and `SimulationRunControllerFindItemsRequestSortOrder` for filtering and sorting simulation run list endpoints.

### Added
- **`SimulationScenariosClient`** — new client for managing simulation scenarios, with `ScenarioControllerFindAllAsync`, `ScenarioControllerCreateAsync`, `ScenarioControllerFindOneAsync`, `ScenarioControllerRemoveAsync`, and `ScenarioControllerUpdateAsync` methods.
- **`ISimulationSuitesClient`** — new client interface for managing simulation suites, supporting FindAll, Create, Duplicate, FindOne, Remove, and Update operations.
- **`ScenarioControllerFindAllRequestSortBy`** and **`ScenarioControllerFindAllRequestSortOrder`** — new enums for sorting scenario list results.
- **`SimulationSuiteControllerFindAllRequest`** and related request types — new request records with pagination, filtering, and sorting support for simulation suite queries.

### Added
- **`SimulationSuitesClient`** — new client for managing simulation suites, with `SimulationSuiteControllerFindAllAsync`, `SimulationSuiteControllerCreateAsync`, `SimulationSuiteControllerDuplicateAsync`, `SimulationSuiteControllerFindOneAsync`, `SimulationSuiteControllerRemoveAsync`, and `SimulationSuiteControllerUpdateAsync` methods.
- **`ISimulationsClient`** — new interface exposing simulation management including scenario generation (`SimulationGenerateControllerGenerateAsync`), concurrency querying (`SimulationControllerGetConcurrencyAsync`), and full CRUD operations.
- **`GenerateScenariosDto`** — new request type for AI-driven scenario generation, accepting optional `AssistantId` and `SquadId`.
- **`SimulationControllerFindAllRequest`** — new paginated list request type with filtering by date ranges, sort order, and standalone-only flag.
- **`SimulationSuiteControllerFindAllRequestSortBy`** and **`SimulationSuiteControllerFindAllRequestSortOrder`** — new enums for controlling sort behavior on simulation suite list queries.

### Added
- **`SimulationsClient`** — new client for managing simulations, supporting scenario generation, CRUD operations, and concurrency limit queries via the `eval/simulation` endpoints.
- **`SimulationControllerFindAllRequestSortBy`** and **`SimulationControllerFindAllRequestSortOrder`** — new enums for sorting simulation list results by `createdAt`, `duration`, or `cost` in ascending or descending order.
- **`StructuredOutputControllerFindAllRequestSortBy`** — new enum and `SortBy` property on `StructuredOutputControllerFindAllRequest` for sorting structured output results.
- **`ListSquadsRequest.IdAny`** — new optional property to filter squads by a set of IDs.
- **`StructuredOutputControllerRunResponseOne`** — new response type exposing a `Skipped` map of structured outputs that were gated by conditions and not extracted.

### Added
- **`TrafficAllocationsClient`** — new client for managing assistant traffic splitting (beta), supporting paginated history, create, latest, and find-by-id operations via `TrafficAllocationControllerFindAllPaginatedAsync`, `TrafficAllocationControllerCreateAsync`, `TrafficAllocationControllerLatestGetAsync`, and `TrafficAllocationControllerFindOneAsync`.
- **`CreateTrafficAllocationDto`** — new request type for creating a traffic allocation, with `AssistantId`, `AllocationIntent`, `Targets`, `ExpectedCurrentAllocationId`, and `Description` properties.
- **`CreateTrafficAllocationDtoAllocationIntent`** — new enum with `FollowLatest` and `Explicit` values for controlling traffic split behavior.
- **`TrafficAllocationControllerFindAllPaginatedRequestSortOrder`** — new enum (`Asc`, `Desc`) for controlling pagination sort order on the allocation history endpoint.

### Changed
- **`ToolsClient`** — `CreateAsync` and `UpdateAsync` now throw `ConflictError` on HTTP 409 responses instead of a generic `VapiClientApiException`.

### Added
- **`AnthropicBedrockModelFallbackModelsItem`** — new enum for specifying fallback model options on Anthropic Bedrock model configurations.
- **`AssemblyAiTranscriberLanguageCodesItem`** and **`AssemblyAiTranscriberMode`** — new enums for configuring AssemblyAI transcriber language codes and accuracy/latency mode.
- **New enum values** across `AnthropicBedrockCredentialRegion` (`EuCentral1`), `AnthropicBedrockModelModel` (`GlobalAnthropicClaudeHaiku4520251001V10`), `AnthropicModelModel` (`ClaudeSonnet5`), and `AssemblyAiTranscriberSpeechModel` (`Universal35Pro`, `Universal36Pro`).
- **`Assistant.LatestVersion`** and **`Assistant.ModelDeprecations`** — new optional properties exposing the assistant's latest version label and any model deprecation notices at response time.
- **`AssistantActivation.AssistantVersion`** and **`AssistantActivation.SquadVersion`** — new optional properties recording which assistant and squad versions were active when an activation was logged; **`AnalysisCost.StructuredOutputBreakdown`** exposes per-structured-output cost rows.

### Added
- **`AssistantDraft`** — new record representing a versioned draft of an assistant, with full configuration properties and required identity fields (`Id`, `OrgId`, `AssistantId`, `BaseVersion`, `CreatedAt`, `UpdatedAt`).
- **`AssistantDraftPaginatedResponse`** and **`AssistantDraftPaginatedMetadata`** — new records for paginated listing of assistant drafts.
- **`AssistantDraftConflictResponseDto`** — new record surfacing conflict error details (including `ExistingDraftId`) when a draft creation conflicts with an existing draft.
- **New supporting enums** — `AssistantDraftFirstMessageMode`, `AssistantDraftClientMessagesItem`, and `AssistantDraftBackgroundSoundZero` for configuring draft assistant behavior.

### Added
- **`AssistantVersion`** — new record representing a versioned snapshot of an assistant's full configuration, including metadata fields such as `Id`, `OrgId`, `AssistantId`, `Version`, `ConfigHash`, `ParentVersion`, and `ModelDeprecations`.
- **`AssistantDraftServerMessagesItem`** — new enum covering all server message event types for assistant drafts, including `call.artifact.upload`.
- **`AssistantPinnedConflictResponseDto`** and **`AssistantPinnedConflictResponseDtoError`** — new types returned when a delete is rejected because the assistant is pinned to an active resource.
- **`CallArtifactUpload`** enum value added to `AssistantServerMessagesItem` and `AssistantOverridesServerMessagesItem`, enabling subscription to `call.artifact.upload` server events.

### Added
- **`AssistantVersionPaginatedMetadata`** — new record for paginated assistant version list responses, exposing `NextCursor`, `HasNextPage`, and `Limit`.
- **`AssistantVersionBackgroundSoundZero`**, **`AssistantVersionClientMessagesItem`**, **`AssistantVersionFirstMessageMode`**, **`AssistantVersionServerMessagesItem`**, and **`AssistantVersionVoicemailDetectionZero`** — new enums supporting assistant version configuration.
- **`AudioFormat`** — new record describing call audio format, sample rate, and optional container type, along with supporting enums `AudioFormatFormat` and `AudioFormatContainer`.
- **`AzureCredentialRegion`** — new values `Switzerlandnorth` and `Switzerlandwest` added to the Azure region enum.
- **`AzureOpenAiCredentialModelsItem`** — new model values added: `Gpt56Luna20260709`, `Gpt56Terra20260709`, `Gpt56Sol20260709`, `Gpt4O`, `Gpt41`, and `Gpt54Mini20260317`.

### Added
- **`Board`**, **`BoardInsightItem`**, **`BoardMetricWidgetItem`**, **`BoardLayout`**, **`BoardItemPosition`**, **`BoardItemSize`**, and **`BoardPaginatedResponse`** — new types for creating and managing dashboard boards with positioned insight and metric widgets.
- **`BackgroundSoundUrlValidationResult`** and **`BackgroundSoundUrlValidationResultReason`** — new types for validating whether a background sound URL serves a live audio file and surfacing the failure reason when it does not.
- **`BooleanComparatorScorecardMetricCondition`** — new type for defining boolean equality conditions in scorecard metrics, with supporting `BooleanComparatorScorecardMetricConditionComparator` and `BooleanComparatorScorecardMetricConditionType` enums.
- **`AzureOpenAiCredentialRegion.Switzerlandnorth`** and **`AzureOpenAiCredentialRegion.Switzerlandwest`** — two new Azure region values for Switzerland North and Switzerland West.
- **`BotMessage.AssistantName`** and **`BotMessage.AssistantId`** — new optional properties identifying the sub-agent that produced a message in squad or handoff calls; **`BarInsight.SystemKey`** — new optional stable server-owned identifier for system-created insights.

### Added
- **`CallArtifactUploadItemType`** — new enum representing the type of artifact uploaded at the end of a call (e.g. `EndOfCallReport`, `RecordingMono`, `RecordingStereo`, `Log`, `Pcap`).
- **`CampaignCallMetrics`** — new record exposing `Dialed` and `Connected` counts for a campaign.
- **`CampaignContact`** — new record representing a contact entry within a campaign, including optional `AssistantOverrides` and `SquadOverrides`.
- **`CallEndedReason`** — ~50 new enum values covering xAI and Microsoft voice/transcriber failures, Vapi transcriber and voice failures, Cartesia transcriber failures, ElevenLabs concurrent-request and voice-disabled-by-owner errors, SIP outbound unallocated-number and carrier-released-call scenarios, call-forwarding no-answer, assistant/squad version validation errors, and config-fault model/transport errors.

### Added
- **`CampaignContactCounters`** — new record exposing per-status contact counts (`Pending`, `Dispatched`, `Completed`, `Failed`, `Skipped`, `PredialFailed`) for a campaign.
- **`CampaignContactWithOutcome`** and **`CampaignContactPaginatedResponse`** — new types for retrieving paginated contact-level results with call outcomes.
- **`CampaignSummary`** and **`CampaignSummaryPaginatedResponse`** — new types for listing campaigns with aggregated metrics, contact counters, and schedule details.
- **`CampaignPredialPlan`** — new type enabling the blocking `campaign.predial` eligibility webhook; set on a campaign to gate each contact before dialing.
- **`CampaignStatus.Cancelled`** and **`CampaignStatus.Archived`** — two new enum values reflecting additional campaign lifecycle states; **`CampaignServerMessagesItem`** and **`CampaignContactWithOutcomeStatus`** enums added for webhook event and contact status modeling; **`CartesiaCredential.ApiUrl`** added to support on-premises Cartesia deployments.

### Added
- **`AssistantVersion`** — new optional `string?` property on all `ClientMessage*` types that surfaces the version label (e.g. `v3`) of the assistant configured for the call.
- **`ClientInboundMessageAppendContext`** — new record for injecting commentary, thinking, or instructions into an active call, with the accompanying **`ClientInboundMessageAppendContextKind`** enum (`Commentary`, `Thinking`, `Instructions`).
- **`ClientMessageTranscript.Confidence`** and **`ClientMessageTranscript.ConfidenceSource`** — new optional properties that expose the transcriber's confidence score and its origin (`Provider` or `Derived`), along with the new **`ClientMessageTranscriptConfidenceSource`** enum.
- **`ClientMessageTranscript.AssistantId`** and **`ClientMessageTranscript.AssistantName`** — new optional properties identifying the assistant that produced a transcript on assistant-role events.
- **`CartesiaVoiceModel.Sonic35`** and **`CartesiaVoiceModel.Sonic3520260504`** — new enum values for the Cartesia Sonic 3.5 voice model and its dated snapshot variant.

### Added
- **`CreateAssistantDraftDto`** — new record for creating assistant drafts, supporting the full assistant configuration surface including a `BaseVersion` pointer to the published version the draft was forked from.
- **`CreateAssistantDraftDtoBackgroundSoundZero`**, **`CreateAssistantDraftDtoClientMessagesItem`**, and **`CreateAssistantDraftDtoFirstMessageMode`** — supporting enums for the new draft DTO.
- **`CreateAnthropicBedrockCredentialDtoRegion.EuCentral1`** — adds the `eu-central-1` AWS region as a valid option for Anthropic Bedrock credentials.
- **`ClientMessageWorkflowNodeStarted.AssistantVersion`** — new optional property exposing the version label (e.g. `v3`) of the assistant configured for the call.
- XML doc comments added to `CloudflareR2BucketPlan`, `CompliancePlan`, `ConversationNode`, `Compliance`, `Condition`, `CostBreakdown`, and many other types for improved IntelliSense discoverability.

### Added
- **`CreateCampaignDto`** — new type for configuring outbound calling campaigns, supporting assistant, squad, or workflow targeting with dial plans, schedules, customer lists, predial webhooks, and concurrency controls.
- **`CreateAssistantDraftDtoServerMessagesItem`** and **`CreateAssistantDraftDtoVoicemailDetectionZero`** — new enum types for assistant draft configuration.
- **`CallArtifactUpload`** — new value added to `CreateAssistantDtoServerMessagesItem` enum to subscribe to artifact upload server messages.
- **New Azure regions** `Switzerlandnorth` and `Switzerlandwest` added to `CreateAzureCredentialDtoRegion` and `CreateAzureOpenAiCredentialDtoRegion`.
- **New Azure OpenAI model values** added to `CreateAzureOpenAiCredentialDtoModelsItem`, including `gpt-5.6-luna-2026-07-09`, `gpt-5.6-terra-2026-07-09`, `gpt-5.6-sol-2026-07-09`, `gpt-4o`, `gpt-4.1`, and `gpt-5.4-mini-2026-03-17`.

### Added
- **`CreateS3CompatibleCredentialDto`** — new credential type for storing call artifacts in any S3-compatible bucket, with `BucketPlan`, `FallbackIndex`, and `Name` properties.
- **`CreateElevenLabsCredentialDtoApiUrl`** — new enum for selecting the ElevenLabs global or EU data residency endpoint; exposed as the optional `ApiUrl` property on `CreateElevenLabsCredentialDto`.
- **`CreateCampaignDtoServerMessagesItem`** — new enum covering campaign and contact lifecycle events (e.g. `CampaignStarted`, `ContactDispatched`, `CampaignJobContinued`).
- **`CreateCustomerDto.SquadOverrides`** — new optional `AssistantOverrides` property for applying overrides when a call targets a `squadId` instead of a single assistant.
- **`CreateCartesiaCredentialDto.ApiUrl`** — new optional string property for pointing to an on-premises Cartesia instance.

### Added
- **`CreateSimulationRunResponse`** — new record representing the response from creating a simulation run, including status, timing, item counts, and a dashboard URL.
- **`CreateSimulationRunResponseStatus`** — new enum with values `Queued`, `Running`, and `Ended` for tracking simulation run lifecycle.
- **`CreateToolDraftDto`** — new record for creating tool drafts, supporting all tool variants (api-request, code, computer, sip-request, mcp, handoff, etc.) with associated `CreateToolDraftDtoMethod` and `CreateToolDraftDtoVerb` enums.
- **`CreateSonioxCredentialDto.ApiUrl`** — new optional property for specifying a custom Soniox WebSocket endpoint (e.g. an EU-region server).
- **`CreateStructuredOutputDto.Conditions`** — new optional property for gating structured output execution with AND-semantics conditions; send `null` to clear a previously saved gate.

### Added
- **`CreateToolDraftDtoType`** and **`CreateToolDraftDtoVerb`** — new enums for configuring tool draft type and verb values.
- **`CreateTrafficAllocationTargetDto`** — new record for defining traffic splits across published assistant versions, with `AssistantVersion` and `Percentage` required properties.
- **`CustomerSpeechTimeoutOptionsTriggerResetMode`** and **`DeepgramTranscriberRedactionItem`** — new enums for speech timeout reset behavior and Deepgram transcription redaction categories.
- **`AssistantVersion`** and **`SquadVersion`** — new optional properties on `CreateWebCallDto` to pin a web call to a specific published assistant or squad version.
- **New enum values** added to `DeepSeekModelModel` (`DeepseekFlash`, `DeepseekFlashThinking`), `DeepgramVoiceModel` (`Flux`), and `DeepgramVoiceId` (43 new voice IDs including `Viktoria`, `Kara`, `Hannah`, and more).

### Added
- **`EndedReasonCondition`** and **`EndedReasonConditionOperator`** — new types for filtering structured outputs based on a call's ended reason using `oneOf` / `notOneOf` membership operators.
- **`ElevenLabsCredentialApiUrl`** enum and **`ElevenLabsCredential.ApiUrl`** optional property — enables selecting the global or EU data residency ElevenLabs API endpoint per credential.
- **New model enum values** — `ElevenLabsVoiceModel.ElevenV4Turbo`, `EvalAnthropicModelModel.ClaudeSonnet5`, `EvalGoogleModelModel.Gemini35Flash` and `Gemini31FlashLite`, and dozens of new `EvalOpenAiModelModel` values covering GPT-5.x, GPT-6, and region-specific Azure deployments.
- **`ExportChatDto.IdAny`** and **`ExportChatDto.SortBy`** — new optional properties for filtering chats by multiple IDs and controlling sort column in CSV exports.
- **XML doc comments** added to `DeveloperMessage`, `DialPlanEntry`, `Edge`, `Eval`, `EvalPaginatedResponse`, `EvalRunPaginatedResponse`, and many other public types for improved IntelliSense support.

## 2.0.0 - 2026-06-24
### Breaking Changes
* **`CartesiaExperimentalControlsSpeedZero`** has been renamed to **`CartesiaSpeedControlZero`**; update all references and the type argument in `CartesiaExperimentalControls.Speed` (`OneOf<CartesiaSpeedControlZero, double>?`).
* **`FallbackAzureVoiceVoiceIdZero`** has been renamed to **`FallbackAzureVoiceIdZero`**; update all references and the type argument in `FallbackAzureVoice.VoiceId` (`OneOf<FallbackAzureVoiceIdZero, string>`).

## 1.1.1 - 2026-05-20
* chore: remove explicit ContentType from internal POST request builders
* Remove the redundant `ContentType = "application/json"` property from
* internal request configuration objects across multiple clients. The HTTP
* client already sets this header by default when a body is present, so
* the explicit assignment was unnecessary.
* Key changes:
* Remove `ContentType = "application/json"` from `AssistantsClient` POST request
* Remove `ContentType = "application/json"` from `EvalClient` POST request
* Remove `ContentType = "application/json"` from `InsightClient` POST requests (two endpoints)
* Remove `ContentType = "application/json"` from `ObservabilityScorecardClient` POST request
* Remove `ContentType = "application/json"` from `PhoneNumbersClient` POST request
* Remove `ContentType = "application/json"` from `SquadsClient`, `StructuredOutputsClient`, and `ToolsClient` POST requests
* 🌿 Generated with Fern

## 1.1.0 - 2026-04-22
### Added
* **`Call.SubscriptionLimits`** — new optional property that exposes the org's subscription and concurrency limit information at the time of the call.

## 1.0.1 - 2026-04-10
* fix: improve RFC 3986 compliant percent-encoding for query strings and path segments
* Update `QueryStringBuilder` to properly distinguish between three encoding
* contexts — query keys, query values, and path segments — per RFC 3986.
* Previously, only unreserved characters (A-Z, a-z, 0-9, `-`, `_`, `.`, `~`)
* were left unencoded, causing over-encoding of characters that are safe in
* query strings and path segments (e.g., `@`, `:`, `?`, `=` in values, etc.).
* Path parameter strings in `ValueConvert.ToPathParameterString` now use the
* new `EncodePathSegment` method instead of plain string passthrough, ensuring
* path segments are correctly encoded per RFC 3986 pchar rules.
* Key changes:
* Add `EncodePathSegment()` public method on `QueryStringBuilder` for RFC 3986 pchar-safe encoding
* Introduce `EncodingContext` enum (`QueryKey`, `QueryValue`, `Path`) to differentiate encoding rules
* Query values now allow `=`, `:`, `@`, `/`, `?`, and sub-delimiters (except `&`, `+`, `#`) unencoded
* Query keys allow the same set minus `=`; path segments allow unreserved + sub-delims + `:` + `@`
* `ValueConvert.ToPathParameterString(string)` now encodes path segments via `EncodePathSegment`
* Expand test coverage with new cases for path segment encoding, OData-style keys, and `+`/`=` handling
* 🌿 Generated with Fern

## 1.0.0 - 2026-04-07
* The `CallControllerFindAllPaginatedRequest` request class and the associated `CallControllerFindAllPaginatedRequestSortOrder` enum have been removed from the SDK. If your code references either of these types, you will need to update it accordingly. Please refer to the latest API documentation for the replacement request model.
* The following public types have been removed: `GenerateStructuredOutputSuggestionsDto`, `UpdateSupabaseCredentialDto`, and the `CreateVoicemailToolDtoType` enum. Additionally, `AnalyticsClient.GetAsync` now returns `WithRawResponseTask<IEnumerable<AnalyticsQueryResult>>` instead of `Task<IEnumerable<AnalyticsQueryResult>>`; callers must update to await `.Data` or use the `.WithRawResponse()` accessor. The `AnalyticsClient` now implements `IAnalyticsClient`.
* The `AssistantsClient` methods (`ListAsync`, `CreateAsync`, `GetAsync`, `DeleteAsync`, `UpdateAsync`) now return `WithRawResponseTask<T>` instead of `Task<T>`. Callers must update their code to await the result and access the data via `.Data`, or use `.RawResponse` to inspect the underlying HTTP response metadata (status code, URL, headers).
* A new `AssistantSpeechStarted` value has been added to the `UpdateAssistantDtoClientMessagesItem` enum.
* All `CallsClient` methods (`ListAsync`, `CreateAsync`, `GetAsync`, `DeleteAsync`, `UpdateAsync`) now return `WithRawResponseTask<T>` instead of `Task<T>`, providing access to raw HTTP response metadata (status code, headers, URL) alongside deserialized data. **Migration:** Await the returned `WithRawResponseTask<T>` and access `.Data` for the previously returned value, or use the implicit awaiter to get `T` directly. The `CallControllerFindAllPaginatedAsync` method has been removed from `CallsClient`. A new `AssistantSpeechStarted` value is available on the `UpdateAssistantDtoServerMessagesItem` enum.
* All `CampaignsClient` methods now return `WithRawResponseTask<T>` instead of `Task<T>`, giving consumers access to the raw HTTP response (status code, URL, and headers) in addition to the deserialized data. Callers that simply `await` these methods will continue to work, but any code that stores or passes the `Task<T>` return value directly will need to be updated to use `WithRawResponseTask<T>`.
* `CreateCampaignDto.PhoneNumberId` is now nullable (`string?`, previously `required string`) and `Customers` is now `IEnumerable<CreateCustomerDto>?` (previously a non-nullable collection with a default value). New optional `SquadId` and `DialPlan` properties are available on both `CreateCampaignDto` and `UpdateCampaignDto` to support squad-based and multi-number dial-plan campaigns.
* All `ChatsClient` async methods (`ListAsync`, `CreateAsync`, `GetAsync`, `DeleteAsync`, `CreateResponseAsync`) now return `WithRawResponseTask<T>` instead of `Task<T>`, providing access to raw HTTP response metadata (status code, URL, and headers) via the `.RawResponse` property alongside the deserialized `.Data`. Existing callers must be updated to `await` the task and access `.Data` for the result. `ListChatsRequest` also gains two new optional filter properties: `Id` and `AssistantIdAny`.
* The SDK now supports improved JSON serialization for `Optional<T>` and nullable fields, and HTTP retries now respect `Retry-After` and `X-RateLimit-Reset` response headers with jitter-based backoff. `VapiClientApiException` now accepts an optional `innerException` parameter for better error chaining.
* All `EvalClient` async methods now return `WithRawResponseTask<T>` instead of `Task<T>`, giving consumers access to both the deserialized response (`.Data`) and the raw HTTP response (`.RawResponse`, including status code, URL, and headers). Existing code that directly awaits these methods as `Task<T>` must be updated to use `.Result` (or `await` via the `WithRawResponseTask<T>` API) to retrieve the deserialized value. Additionally, `EvalClient` now implements the `IEvalClient` interface.
* The `ListAsync`, `CreateAsync`, `GetAsync`, `DeleteAsync`, and `UpdateAsync` methods on `FilesClient` now return `WithRawResponseTask<T>` instead of `Task<T>`. Callers can still `await` the result directly to get the deserialized data, but any code that stores or passes the return value as a `Task<T>` must be updated to use `WithRawResponseTask<T>` (or call `.AsTask()` if available). These methods also now expose the raw HTTP response — status code, URL, and headers — via the `.RawResponse` property on the awaited result.
* All `InsightClient` methods now return `WithRawResponseTask<T>` instead of `Task<T>`, allowing consumers to access the raw HTTP response (status code, headers, and request URL) via the `.RawResponse` property in addition to the deserialized data. `InsightClient` also now implements the `IInsightClient` interface. Callers that awaited results directly are unaffected; callers that stored results as explicit `Task<T>` variables will need to update their type declarations to `WithRawResponseTask<T>`.
* All `ObservabilityScorecardClient` async methods (`ScorecardControllerGetAsync`, `ScorecardControllerRemoveAsync`, `ScorecardControllerUpdateAsync`, `ScorecardControllerGetPaginatedAsync`, and `ScorecardControllerCreateAsync`) now return `WithRawResponseTask<T>` instead of `Task<T>`. Callers can await the result directly to get the deserialized data, or access `.RawResponse` for HTTP status code, URL, and headers. Update any code that assigns or passes the return value as a `Task<T>` to use `WithRawResponseTask<T>` (or simply `await` the call). Additionally, deserialization failures now throw `VapiClientApiException` instead of `VapiClientException`.
* The `PhoneNumbersClient` methods (`ListAsync`, `CreateAsync`, `GetAsync`, `DeleteAsync`, `UpdateAsync`, and `PhoneNumberControllerFindAllPaginatedAsync`) now return `WithRawResponseTask<T>` instead of `Task<T>`, giving callers access to the raw HTTP response (status code, headers, and URL) alongside the deserialized result. Callers must update their code to await `.Result` or use `.Data` to access the deserialized payload. Additionally, deserialization failures now throw `VapiClientApiException` instead of `VapiClientException`.
* All `ProviderResourcesClient` methods now return `WithRawResponseTask<T>` instead of `Task<T>`, providing access to the raw HTTP response (status code, headers, URL) alongside the deserialized result. Callers must update their `await` usage — use `.Result` or `await` the inner task to retrieve the typed data (e.g., `var result = await client.ProviderResourceControllerGetProviderResourceAsync(...); var data = result.Data;`). A new `Cartesia` provider value has also been added to the relevant request enums.
* The SDK now supports Cartesia as a provider option in all provider-resource request enums (`Get`, `GetPaginated`, and `Update`). `CreateSessionDto` gains two new optional properties — `AssistantOverrides` and `CustomerId` — for richer session creation. `ListSessionsRequest` also gains several new optional filter fields: `Id`, `AssistantIdAny`, `CustomerNumberAny`, `PhoneNumberId`, and `PhoneNumberIdAny`.
* All `SessionsClient` methods (`ListAsync`, `CreateAsync`, `GetAsync`, `DeleteAsync`, `UpdateAsync`) now return `WithRawResponseTask<T>` instead of `Task<T>`. Callers can await the result directly as before, but must update any code that assigns the return value to `Task<T>`. The raw HTTP response (status code, URL, and headers) is now accessible via the `.RawResponse` property on the awaited result. Additionally, `ListSessionsRequest` gains new optional filter fields: `Id`, `AssistantIdAny`, `CustomerNumberAny`, `PhoneNumberId`, and `PhoneNumberIdAny`.
* The `ListAsync`, `CreateAsync`, `GetAsync`, `DeleteAsync`, and `UpdateAsync` methods on `SquadsClient` now return `WithRawResponseTask<T>` instead of `Task<T>`. Callers must update their `await` expressions and can now access `.RawResponse` for HTTP status codes, headers, and the request URL. Additionally, `UpdateStructuredOutputDto` gains two new optional properties — `Type` and `Regex` — to support regex-based structured output extraction.
* All methods on `StructuredOutputsClient` now return `WithRawResponseTask<T>` instead of `Task<T>`, giving callers access to HTTP status codes, response headers, and the raw request URL alongside deserialized response data. The `StructuredOutputControllerSuggestAsync` method has been removed. Callers of any `StructuredOutputsClient` method must update their code to handle the new return type, and any calls to `StructuredOutputControllerSuggestAsync` must be removed.
* The `AdditionalProperties` property on all SDK model types has changed from `IDictionary<string, JsonElement>` to `ReadOnlyAdditionalProperties`. Code that wrote to or cast `AdditionalProperties` as a mutable dictionary must be updated to use the new read-only accessor.
* All `ToolsClient` methods (`ListAsync`, `CreateAsync`, `GetAsync`, `DeleteAsync`, `UpdateAsync`) now return `WithRawResponseTask<T>` instead of `Task<T>`. Callers can `await` the result directly to obtain the data as before, or access `.WithRawResponse` to inspect the raw HTTP status code, URL, and headers.
* New optional fields `CachedPromptTokens` and related cached-token breakdown fields have been added to `AnalysisCost` and `AnalysisCostBreakdown`.
* The `AdditionalProperties` property on all SDK record types (e.g. `AnalyticsQuery`, `AnthropicCredential`, `AnthropicModel`, etc.) has changed its type from `IDictionary<string, JsonElement>` to `ReadOnlyAdditionalProperties`. Code that previously assigned to or mutated this dictionary will no longer compile. If you only read from `AdditionalProperties`, no changes are required.
* Three new Anthropic Claude model enum values are now available on `AnthropicModelModel`: `ClaudeOpus4520251101`, `ClaudeOpus46`, and `ClaudeSonnet46`. A new `AnalyticsOperationColumn` value `CostBreakdownLlmCachedPromptTokens` has also been added.
* The `AdditionalProperties` property on all SDK record types has changed from `IDictionary<string, JsonElement>` (publicly writable) to `ReadOnlyAdditionalProperties` (read-only wrapper populated after deserialization). Any code that directly assigned or mutated `AdditionalProperties` will need to be updated — the property is now read-only and managed automatically by the deserializer.
* Several new optional properties have also been added across types, including `ApiRequestTool.EncryptedPaths`, `ApiRequestTool.Parameters`, `Artifact.AssistantActivations`, `ArtifactPlan.StructuredOutputs`, and `AssemblyAiTranscriber.VadAssistedEndpointingEnabled` / `SpeechModel`. A new `Multi` language option is available for `AssemblyAiTranscriberLanguage`, and a new `SessionCreatedHook` variant is available in the assistant hooks union.
* The `AdditionalProperties` property on several record types (e.g. `AssistantCustomEndpointingRule`, `AssistantMessage`, `AssistantOverrides`, and others) has changed from `IDictionary<string, JsonElement>` to `ReadOnlyAdditionalProperties`. Code that wrote to or cast `AdditionalProperties` as a mutable dictionary will need to be updated to use the new read-only type. Additionally, a new `AssistantSpeechStarted` value has been added to `AssistantClientMessagesItem`, a new optional `AutoIncludeMessageHistory` property has been added to `AssistantMessageJudgePlanAi`, and `SessionCreatedHook` is now included in the `AssistantOverrides.Hooks` union.
* The `AdditionalProperties` property on response record types (e.g. `AssistantPaginatedResponse`, `AssistantUserEditable`, `AssistantVersionPaginatedResponse`, `AutoReloadPlan`) has changed from `IDictionary<string, JsonElement>` to `ReadOnlyAdditionalProperties`. Callers that previously wrote to or iterated over `AdditionalProperties` as a mutable dictionary must update their code to use the new read-only type.
* Additionally, the `AssistantSpeechStarted` (`assistant.speechStarted`) value has been added to `AssistantClientMessagesItem`, `AssistantOverridesClientMessagesItem`, `AssistantServerMessagesItem`, and `AssistantOverridesServerMessagesItem` enums.
* The `AdditionalProperties` property on Azure credential and transcriber types (`AzureBlobStorageBucketPlan`, `AzureCredential`, `AzureOpenAiCredential`, `AzureSpeechTranscriber`) has changed from a mutable `IDictionary<string, JsonElement>` to a read-only `ReadOnlyAdditionalProperties` type. Code that writes to or assigns `AdditionalProperties` directly will no longer compile — update such code to read from the property only.
* Additionally, the `Australia` enum value in `AzureCredentialRegion` and `AzureOpenAiCredentialRegion` has been renamed to `Australiaeast`. Update any references from `.Australia` to `.Australiaeast`. Several new region values (`Centralus`, `Germanywestcentral`, `Polandcentral`, `Spaincentral`, `Westeurope`) and new GPT-5.x model values have been added to the respective enums.
* The `AdditionalProperties` property on record types (e.g. `AzureVoice`, `BackgroundSpeechDenoisingPlan`, `BackoffPlan`, `BarInsight`, `BarInsightFromCallTable`, and others) has changed from `IDictionary<string, JsonElement>` to `ReadOnlyAdditionalProperties`. Code that wrote to or relied on the mutable dictionary interface must be updated to use the new read-only type. Additionally, the `Queries` property on `BarInsight` and `BarInsightFromCallTable` now includes `JsonQueryOnEventsTable` as a new union variant — exhaustive pattern matches on this `OneOf` type will require a new case.
* The `AdditionalProperties` property on all SDK record types has changed from a mutable `IDictionary<string, JsonElement>` to a new read-only `ReadOnlyAdditionalProperties` type — any code that previously wrote to or cast this property will need to be updated. Additionally, `BotMessage.SpeakerLabel` has been removed. New `CustomerNumber` enum values have been added to `BarInsightFromCallTableGroupBy` and `BarInsightGroupBy`.
* The `AdditionalProperties` property on `Call`, `CallBatchError`, `CallBatchResponse`, and `ByoSipTrunkCredential` has changed from a mutable `IDictionary<string, JsonElement>` to a read-only `ReadOnlyAdditionalProperties` type — any code that wrote to or cast this property as a mutable dictionary will need to be updated. A new `EndedMessage` property has been added to the `Call` type to provide additional context when a call ends.
* The `CallEndedReason` enum has been expanded with over 60 new values covering additional provider failures (Wellsaid voice, Baseten LLM, Minimax LLM, Soniox transcriber, ElevenLabs/Google/OpenAI transcribers), new SIP connection error states (`CallInProgressErrorSipInboundCallFailedToConnect`, `CallRingingErrorSipInboundCallFailedToConnect`, `CallInProgressErrorProviderfaultOutboundSip408RequestTimeout`), and a new customer hangup reason (`CustomerEndedCallDuringTransfer`). The enum serializer has been replaced with a dedicated implementation that ensures deterministic wire-value round-tripping for all members.
* The `AdditionalProperties` property on `CallHookAssistantSpeechInterrupted`, `CallHookCallEnding`, `CallHookCustomerSpeechInterrupted`, `CallHookCustomerSpeechTimeout`, `CallHookFilter`, `CallHookModelResponseTimeout`, `CallPaginatedResponse`, and other record types has changed from `IDictionary<string, JsonElement>` to `ReadOnlyAdditionalProperties`. Callers that accessed this property via the dictionary interface must update their code to use the new `ReadOnlyAdditionalProperties` API. Additionally, `CallHookCallEnding.Do` has changed from `IEnumerable<ToolCallHookAction>` to `IEnumerable<object>`.
* The `AdditionalProperties` property on several record types (`Campaign`, `CampaignPaginatedResponse`, `CartesiaCredential`, `CartesiaExperimentalControls`, `CartesiaGenerationConfig`, `CartesiaGenerationConfigExperimental`, `CartesiaTranscriber`) has changed from a mutable `IDictionary<string, JsonElement>` to a read-only `ReadOnlyAdditionalProperties` type — code that writes to this dictionary must be updated. Additionally, `Campaign.PhoneNumberId` is now nullable (`string?` instead of `required string`) and `Campaign.Customers` is now `IEnumerable<CreateCustomerDto>?` instead of a required non-nullable collection. New optional properties `SquadId` and `DialPlan` have been added to `Campaign` to support squad-based and multi-number dial-plan campaigns.
* The `AdditionalProperties` property on `CartesiaVoice` and `CerebrasCredential` (and likely other record types) has changed from `IDictionary<string, JsonElement>` to `ReadOnlyAdditionalProperties`. Code that wrote to or cast `AdditionalProperties` as a mutable dictionary will need to be updated to use the new read-only API. Additionally, three new versioned model values (`Sonic320260112`, `Sonic320251027`, `Sonic220250611`) have been added to the `CartesiaVoiceModel` enum.
* The `AdditionalProperties` property on response record types (e.g. `CerebrasModel`, `Chat`, `ChatCost`, `ChatAssistantOverrides`, and related types) has changed its type from `IDictionary<string, JsonElement>` to `ReadOnlyAdditionalProperties`. Code that assigned to or called mutating methods on `AdditionalProperties` must be updated to use the new read-only API.
* The `AdditionalProperties` property on all SDK response record types has changed from `IDictionary<string, JsonElement>` to the new `ReadOnlyAdditionalProperties` type. Code that writes to or casts `AdditionalProperties` as a mutable dictionary will need to be updated to use the read-only API. A new `ClientMessageAssistantSpeech` variant has also been added to the `ClientMessage.Message` union type.
* The `AdditionalProperties` property on `ClientMessageChatCreated`, `ClientMessageChatDeleted`, `ClientMessageConversationUpdate`, `ClientMessageHang`, `ClientMessageLanguageChangeDetected`, `ClientMessageMetadata`, `ClientMessageModelOutput`, and `ClientMessageSessionCreated` has changed from `IDictionary<string, JsonElement>` to `ReadOnlyAdditionalProperties`. Code that assigns to or mutates `AdditionalProperties` directly will no longer compile. A new optional `TurnId` property has been added to `ClientMessageModelOutput` to identify and group LLM response tokens by turn.
* The `AdditionalProperties` property on `ClientMessageSessionDeleted`, `ClientMessageSessionUpdated`, `ClientMessageSpeechUpdate`, `ClientMessageToolCalls`, `ClientMessageToolCallsResult`, and `ClientMessageTranscript` has changed from `IDictionary<string, JsonElement>` to `ReadOnlyAdditionalProperties`. Callers that previously assigned to or mutated this property must remove those mutations — the property is now populated automatically after deserialization and exposes a read-only interface. Index-based read access (`record.AdditionalProperties["key"]`) continues to work.
* The `AdditionalProperties` property on response record types (e.g. `ClientMessageTransferUpdate`, `ClientMessageUserInterrupted`, `CloneVoiceDto`, `CloudflareCredential`, and others) has changed from `IDictionary<string, JsonElement>` (with an `internal set`) to `ReadOnlyAdditionalProperties` (with a `private set`). Code that writes to or casts `AdditionalProperties` as a mutable dictionary must be updated to use the new read-only type.
* A new optional `TurnId` property has been added to `ClientMessageUserInterrupted`, allowing clients to identify and discard tokens from an interrupted LLM response turn.
* The `AdditionalProperties` property on all response model types (e.g. `CostBreakdown`, `Condition`, `ConversationNode`, `CreateApiRequestToolDto`, and many others) has changed from `IDictionary<string, JsonElement>` with an `internal set` to `ReadOnlyAdditionalProperties` with a `private set`. Consumers who previously read, assigned, or mutated `AdditionalProperties` directly must update their code to use the new read-only accessor.
* Two new optional properties have also been added: `CostBreakdown.LlmCachedPromptTokens` for LLM cached prompt token tracking, and `CreateApiRequestToolDto.EncryptedPaths` / `CreateApiRequestToolDto.Parameters` for encrypted path and static parameter support on API request tools.
* The `AdditionalProperties` property on DTO records such as `CreateAssistantDto` and `CreateAzureCredentialDto` has changed type from `IDictionary<string, JsonElement>` (publicly settable) to `ReadOnlyAdditionalProperties` (read-only). Consumers that read from or write to `AdditionalProperties` as a dictionary must update their code to use the new `ReadOnlyAdditionalProperties` API.
* Additionally, the `Australia` enum member in `CreateAzureCredentialDtoRegion` has been renamed to `Australiaeast`; any code referencing `CreateAzureCredentialDtoRegion.Australia` must be updated to `Australiaeast`.
* New capabilities added include: `AssistantSpeechStarted` in `CreateAssistantDtoClientMessagesItem` and `CreateAssistantDtoServerMessagesItem`, `SessionCreatedHook` in the `CreateAssistantDto.Hooks` union, and several new Azure regions (`Centralus`, `Germanywestcentral`, `Polandcentral`, `Spaincentral`, `Westeurope`).
* The `AdditionalProperties` property on several DTO types (including `CreateAzureOpenAiCredentialDto`, `CreateBarInsightFromCallTableDto`, `CreateBashToolDto`, `CreateByoPhoneNumberDto`, `CreateByoSipTrunkCredentialDto`, and others) has changed its type from `IDictionary<string, JsonElement>` to `ReadOnlyAdditionalProperties`. Code that writes to or casts `AdditionalProperties` as a mutable dictionary will need to be updated.
* Additionally, the `Australia` enum value in `CreateAzureOpenAiCredentialDtoRegion` has been renamed to `Australiaeast`; any switch statements or direct references to `CreateAzureOpenAiCredentialDtoRegion.Australia` must be updated to `Australiaeast`.
* The `AdditionalProperties` property on DTO types has changed from `IDictionary<string, JsonElement>` (with an `internal` setter) to `ReadOnlyAdditionalProperties` (with a `private` setter). Any code that assigned to, cast, or mutated `AdditionalProperties` directly will need to be updated to use the new read-only API.
* Two new optional properties have also been added: `CreateCustomCredentialDto.EncryptionPlan` for specifying an encryption plan, and `CreateDtmfToolDto.SipInfoDtmfEnabled` for enabling DTMF tones via SIP INFO messages.
* The `AdditionalProperties` property on all DTO types (e.g. `CreateFunctionToolDto`, `CreateGcpCredentialDto`, `CreateGhlToolDto`, and many others) has changed from a mutable `IDictionary<string, JsonElement>` to a new `ReadOnlyAdditionalProperties` type. Code that previously wrote to or mutated `AdditionalProperties` will no longer compile. Read access is still available via the `ReadOnlyAdditionalProperties` API.
* `CreateFunctionToolDto` also gains two new optional properties: `VariableExtractionPlan` and `Parameters`.

