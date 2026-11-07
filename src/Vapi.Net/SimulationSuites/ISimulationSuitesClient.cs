using OneOf;

namespace Vapi.Net;

public partial interface ISimulationSuitesClient
{
    /// <summary>
    /// Returns the simulation suites for the authenticated organization.
    /// </summary>
    WithRawResponseTask<
        OneOf<IEnumerable<SimulationSuite>, SimulationSuitesPaginatedResponse>
    > SimulationSuiteControllerFindAllAsync(
        SimulationSuiteControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a simulation suite, a group of simulations that run together.
    /// </summary>
    WithRawResponseTask<SimulationSuite> SimulationSuiteControllerCreateAsync(
        CreateSimulationSuiteDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SimulationSuite> SimulationSuiteControllerDuplicateAsync(
        string id,
        SimulationSuiteControllerDuplicateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns the specified simulation suite.
    /// </summary>
    WithRawResponseTask<SimulationSuite> SimulationSuiteControllerFindOneAsync(
        string id,
        SimulationSuiteControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the specified simulation suite.
    /// </summary>
    WithRawResponseTask<SimulationSuite> SimulationSuiteControllerRemoveAsync(
        string id,
        SimulationSuiteControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the specified simulation suite.
    /// </summary>
    WithRawResponseTask<SimulationSuite> SimulationSuiteControllerUpdateAsync(
        string id,
        UpdateSimulationSuiteDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate draft test requirements from an assistant's prompt, tools, and handoff configuration. The response includes numbered requirements describing expected behavior and open questions about behavior that needs clarification. Use this endpoint before generating a simulation suite.
    ///
    /// Review the requirements and resolve any open questions. To revise a draft, send it as `previousDraft` together with natural-language `feedback` describing the changes or answers. Once the requirements are ready, pass them to `POST /eval/simulation/onboarding/suite`.
    ///
    /// Requests can take up to 2 minutes. Each organization can draft requirements 60 times per UTC day, shared with the dashboard. A 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED` response means the daily limit has been reached. Wait until the limit resets at 00:00 UTC before retrying.
    /// </summary>
    WithRawResponseTask<SimulationOnboardingRequirementsDraftDto> SimulationOnboardingControllerRequirementsDraftAsync(
        SimulationOnboardingRequirementsCreateDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Generate and save a simulation suite from reviewed test requirements, and assign it to an assistant. First draft requirements with `POST /eval/simulation/onboarding/requirements`. The response includes the saved suite, its simulations, and requirement coverage, including any gaps.
    ///
    /// Requests can take up to 3 minutes. Set a client timeout of at least 200 seconds.
    ///
    /// Use a unique `idempotencyKey` for each suite generation request. Retrying with the same key does not create a duplicate suite:
    /// - On a timeout or a 5xx (502, 504, 524), retry with the same key. You get the saved suite, a 409 while it is still generating, or a fresh generation if the first one never saved.
    /// - On a 409 `SIMULATION_ONBOARDING_GENERATION_IN_PROGRESS`, the first request is still generating. Wait `Retry-After` seconds (15) and retry with the same key.
    /// - On a 409 `SIMULATION_ONBOARDING_IDEMPOTENCY_KEY_REUSED`, the key was used for a different assistant or requirements. Send a new key.
    ///
    /// Review the generated simulations and coverage gaps. Revise the suite with `PATCH /eval/simulation/onboarding/suite/{suiteId}`, then run it with `POST /eval/simulation/run`.
    ///
    /// Each organization can generate 20 suites per UTC day, shared with the dashboard, and 2 at a time. A retry that returns a saved suite does not count toward these limits. On a 429 `SIMULATION_ONBOARDING_CONCURRENCY_LIMITED`, wait `Retry-After` seconds (30) before retrying. On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, wait until the daily limit resets at 00:00 UTC before retrying.
    /// </summary>
    WithRawResponseTask<SimulationOnboardingSuiteViewDto> SimulationOnboardingControllerSuiteCreateAsync(
        SimulationOnboardingSuiteCreateDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Revise a suite created by `POST /eval/simulation/onboarding/suite`. Remove simulations, rewrite scenarios using natural-language instructions, or set `retryFailed` to regenerate scenarios that failed or exceeded generation limits. The response includes the updated suite and requirement coverage.
    ///
    /// Requests can take up to 2 minutes.
    ///
    /// Send a new `patchKey` for each edit. Replaying an applied key changes nothing and returns the current suite, with `failedEditSimulationIds` listing the simulations that edit could not rewrite, so retry a timeout or a 5xx with the same key. A suite remembers its last 50 keys, so never reuse one.
    ///
    /// Each organization can make 60 edits per UTC day, shared with the dashboard. Requests that only remove simulations and replays of applied edits do not count toward this limit. On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, wait until the daily limit resets at 00:00 UTC before retrying.
    /// </summary>
    WithRawResponseTask<SimulationOnboardingSuiteViewDto> SimulationOnboardingControllerSuiteUpdateAsync(
        string suiteId,
        SimulationOnboardingSuiteUpdateDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
