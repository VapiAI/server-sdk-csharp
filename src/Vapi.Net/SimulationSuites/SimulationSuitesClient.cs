using global::System.Text.Json;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

public partial class SimulationSuitesClient : ISimulationSuitesClient
{
    private readonly RawClient _client;

    internal SimulationSuitesClient(RawClient client)
    {
        _client = client;
    }

    private async Task<
        WithRawResponse<OneOf<IEnumerable<SimulationSuite>, SimulationSuitesPaginatedResponse>>
    > SimulationSuiteControllerFindAllAsyncCore(
        SimulationSuiteControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Vapi.Net.Core.QueryStringBuilder.Builder(capacity: 15)
            .Add("assistantId", request.AssistantId)
            .Add("squadId", request.SquadId)
            .Add("name", request.Name)
            .Add("page", request.Page)
            .Add("sortOrder", request.SortOrder)
            .Add("sortBy", request.SortBy)
            .Add("limit", request.Limit)
            .Add("createdAtGt", request.CreatedAtGt)
            .Add("createdAtLt", request.CreatedAtLt)
            .Add("createdAtGe", request.CreatedAtGe)
            .Add("createdAtLe", request.CreatedAtLe)
            .Add("updatedAtGt", request.UpdatedAtGt)
            .Add("updatedAtLt", request.UpdatedAtLt)
            .Add("updatedAtGe", request.UpdatedAtGe)
            .Add("updatedAtLe", request.UpdatedAtLe)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new Vapi.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Get,
                    Path = "eval/simulation/suite",
                    QueryString = _queryString,
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<
                    OneOf<IEnumerable<SimulationSuite>, SimulationSuitesPaginatedResponse>
                >(responseBody)!;
                return new WithRawResponse<
                    OneOf<IEnumerable<SimulationSuite>, SimulationSuitesPaginatedResponse>
                >()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new VapiClientApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new VapiClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async Task<WithRawResponse<SimulationSuite>> SimulationSuiteControllerCreateAsyncCore(
        CreateSimulationSuiteDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Vapi.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = "eval/simulation/suite",
                    Body = request,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<SimulationSuite>(responseBody)!;
                return new WithRawResponse<SimulationSuite>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new VapiClientApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new VapiClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async Task<
        WithRawResponse<SimulationSuite>
    > SimulationSuiteControllerDuplicateAsyncCore(
        string id,
        SimulationSuiteControllerDuplicateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Vapi.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = string.Format(
                        "eval/simulation/suite/{0}/duplicate",
                        ValueConvert.ToPathParameterString(id)
                    ),
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<SimulationSuite>(responseBody)!;
                return new WithRawResponse<SimulationSuite>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new VapiClientApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                switch (response.StatusCode)
                {
                    case 404:
                        throw new NotFoundError(JsonUtils.Deserialize<object>(responseBody));
                    case 409:
                        throw new ConflictError(JsonUtils.Deserialize<object>(responseBody));
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new VapiClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async Task<WithRawResponse<SimulationSuite>> SimulationSuiteControllerFindOneAsyncCore(
        string id,
        SimulationSuiteControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Vapi.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "eval/simulation/suite/{0}",
                        ValueConvert.ToPathParameterString(id)
                    ),
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<SimulationSuite>(responseBody)!;
                return new WithRawResponse<SimulationSuite>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new VapiClientApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new VapiClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async Task<WithRawResponse<SimulationSuite>> SimulationSuiteControllerRemoveAsyncCore(
        string id,
        SimulationSuiteControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Vapi.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "eval/simulation/suite/{0}",
                        ValueConvert.ToPathParameterString(id)
                    ),
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<SimulationSuite>(responseBody)!;
                return new WithRawResponse<SimulationSuite>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new VapiClientApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new VapiClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async Task<WithRawResponse<SimulationSuite>> SimulationSuiteControllerUpdateAsyncCore(
        string id,
        UpdateSimulationSuiteDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Vapi.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "eval/simulation/suite/{0}",
                        ValueConvert.ToPathParameterString(id)
                    ),
                    Body = request,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<SimulationSuite>(responseBody)!;
                return new WithRawResponse<SimulationSuite>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new VapiClientApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new VapiClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async Task<
        WithRawResponse<SimulationOnboardingRequirementsDraftDto>
    > SimulationOnboardingControllerRequirementsDraftAsyncCore(
        SimulationOnboardingRequirementsCreateDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Vapi.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = "eval/simulation/onboarding/requirements",
                    Body = request,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<SimulationOnboardingRequirementsDraftDto>(
                    responseBody
                )!;
                return new WithRawResponse<SimulationOnboardingRequirementsDraftDto>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new VapiClientApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                switch (response.StatusCode)
                {
                    case 400:
                        throw new BadRequestError(JsonUtils.Deserialize<object>(responseBody));
                    case 403:
                        throw new ForbiddenError(JsonUtils.Deserialize<object>(responseBody));
                    case 404:
                        throw new NotFoundError(JsonUtils.Deserialize<object>(responseBody));
                    case 429:
                        throw new TooManyRequestsError(
                            JsonUtils.Deserialize<SimulationOnboardingErrorDto>(responseBody)
                        );
                    case 502:
                        throw new BadGatewayError(JsonUtils.Deserialize<object>(responseBody));
                    case 503:
                        throw new ServiceUnavailableError(
                            JsonUtils.Deserialize<object>(responseBody)
                        );
                    case 504:
                        throw new GatewayTimeoutError(JsonUtils.Deserialize<object>(responseBody));
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new VapiClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async Task<
        WithRawResponse<SimulationOnboardingSuiteViewDto>
    > SimulationOnboardingControllerSuiteCreateAsyncCore(
        SimulationOnboardingSuiteCreateDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Vapi.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethod.Post,
                    Path = "eval/simulation/onboarding/suite",
                    Body = request,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<SimulationOnboardingSuiteViewDto>(
                    responseBody
                )!;
                return new WithRawResponse<SimulationOnboardingSuiteViewDto>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new VapiClientApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                switch (response.StatusCode)
                {
                    case 400:
                        throw new BadRequestError(JsonUtils.Deserialize<object>(responseBody));
                    case 403:
                        throw new ForbiddenError(JsonUtils.Deserialize<object>(responseBody));
                    case 404:
                        throw new NotFoundError(JsonUtils.Deserialize<object>(responseBody));
                    case 409:
                        throw new ConflictError(JsonUtils.Deserialize<object>(responseBody));
                    case 422:
                        throw new UnprocessableEntityError(
                            JsonUtils.Deserialize<object>(responseBody)
                        );
                    case 429:
                        throw new TooManyRequestsError(
                            JsonUtils.Deserialize<SimulationOnboardingErrorDto>(responseBody)
                        );
                    case 502:
                        throw new BadGatewayError(JsonUtils.Deserialize<object>(responseBody));
                    case 503:
                        throw new ServiceUnavailableError(
                            JsonUtils.Deserialize<object>(responseBody)
                        );
                    case 504:
                        throw new GatewayTimeoutError(JsonUtils.Deserialize<object>(responseBody));
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new VapiClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async Task<
        WithRawResponse<SimulationOnboardingSuiteViewDto>
    > SimulationOnboardingControllerSuiteUpdateAsyncCore(
        string suiteId,
        SimulationOnboardingSuiteUpdateDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Vapi.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "eval/simulation/onboarding/suite/{0}",
                        ValueConvert.ToPathParameterString(suiteId)
                    ),
                    Body = request,
                    Headers = _headers,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<SimulationOnboardingSuiteViewDto>(
                    responseBody
                )!;
                return new WithRawResponse<SimulationOnboardingSuiteViewDto>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new VapiClientApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                switch (response.StatusCode)
                {
                    case 400:
                        throw new BadRequestError(JsonUtils.Deserialize<object>(responseBody));
                    case 403:
                        throw new ForbiddenError(JsonUtils.Deserialize<object>(responseBody));
                    case 404:
                        throw new NotFoundError(JsonUtils.Deserialize<object>(responseBody));
                    case 422:
                        throw new UnprocessableEntityError(
                            JsonUtils.Deserialize<object>(responseBody)
                        );
                    case 429:
                        throw new TooManyRequestsError(
                            JsonUtils.Deserialize<SimulationOnboardingErrorDto>(responseBody)
                        );
                    case 502:
                        throw new BadGatewayError(JsonUtils.Deserialize<object>(responseBody));
                    case 503:
                        throw new ServiceUnavailableError(
                            JsonUtils.Deserialize<object>(responseBody)
                        );
                    case 504:
                        throw new GatewayTimeoutError(JsonUtils.Deserialize<object>(responseBody));
                }
            }
            catch (JsonException)
            {
                // unable to map error response, throwing generic error
            }
            throw new VapiClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Returns the simulation suites for the authenticated organization.
    /// </summary>
    public WithRawResponseTask<
        OneOf<IEnumerable<SimulationSuite>, SimulationSuitesPaginatedResponse>
    > SimulationSuiteControllerFindAllAsync(
        SimulationSuiteControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<
            OneOf<IEnumerable<SimulationSuite>, SimulationSuitesPaginatedResponse>
        >(SimulationSuiteControllerFindAllAsyncCore(request, options, cancellationToken));
    }

    /// <summary>
    /// Creates a simulation suite, a group of simulations that run together.
    /// </summary>
    public WithRawResponseTask<SimulationSuite> SimulationSuiteControllerCreateAsync(
        CreateSimulationSuiteDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SimulationSuite>(
            SimulationSuiteControllerCreateAsyncCore(request, options, cancellationToken)
        );
    }

    public WithRawResponseTask<SimulationSuite> SimulationSuiteControllerDuplicateAsync(
        string id,
        SimulationSuiteControllerDuplicateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SimulationSuite>(
            SimulationSuiteControllerDuplicateAsyncCore(id, request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Returns the specified simulation suite.
    /// </summary>
    public WithRawResponseTask<SimulationSuite> SimulationSuiteControllerFindOneAsync(
        string id,
        SimulationSuiteControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SimulationSuite>(
            SimulationSuiteControllerFindOneAsyncCore(id, request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Deletes the specified simulation suite.
    /// </summary>
    public WithRawResponseTask<SimulationSuite> SimulationSuiteControllerRemoveAsync(
        string id,
        SimulationSuiteControllerRemoveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SimulationSuite>(
            SimulationSuiteControllerRemoveAsyncCore(id, request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Updates the specified simulation suite.
    /// </summary>
    public WithRawResponseTask<SimulationSuite> SimulationSuiteControllerUpdateAsync(
        string id,
        UpdateSimulationSuiteDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SimulationSuite>(
            SimulationSuiteControllerUpdateAsyncCore(id, request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Generate draft test requirements from an assistant's prompt, tools, and handoff configuration. The response includes numbered requirements describing expected behavior and open questions about behavior that needs clarification. Use this endpoint before generating a simulation suite.
    ///
    /// Review the requirements and resolve any open questions. To revise a draft, send it as `previousDraft` together with natural-language `feedback` describing the changes or answers. Once the requirements are ready, pass them to `POST /eval/simulation/onboarding/suite`.
    ///
    /// Requests can take up to 2 minutes. Each organization can draft requirements 60 times per UTC day, shared with the dashboard. A 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED` response means the daily limit has been reached. Wait until the limit resets at 00:00 UTC before retrying.
    /// </summary>
    public WithRawResponseTask<SimulationOnboardingRequirementsDraftDto> SimulationOnboardingControllerRequirementsDraftAsync(
        SimulationOnboardingRequirementsCreateDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SimulationOnboardingRequirementsDraftDto>(
            SimulationOnboardingControllerRequirementsDraftAsyncCore(
                request,
                options,
                cancellationToken
            )
        );
    }

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
    public WithRawResponseTask<SimulationOnboardingSuiteViewDto> SimulationOnboardingControllerSuiteCreateAsync(
        SimulationOnboardingSuiteCreateDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SimulationOnboardingSuiteViewDto>(
            SimulationOnboardingControllerSuiteCreateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Revise a suite created by `POST /eval/simulation/onboarding/suite`. Remove simulations, rewrite scenarios using natural-language instructions, or set `retryFailed` to regenerate scenarios that failed or exceeded generation limits. The response includes the updated suite and requirement coverage.
    ///
    /// Requests can take up to 2 minutes.
    ///
    /// Send a new `patchKey` for each edit. Replaying an applied key changes nothing and returns the current suite, with `failedEditSimulationIds` listing the simulations that edit could not rewrite, so retry a timeout or a 5xx with the same key. A suite remembers its last 50 keys, so never reuse one.
    ///
    /// Each organization can make 60 edits per UTC day, shared with the dashboard. Requests that only remove simulations and replays of applied edits do not count toward this limit. On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, wait until the daily limit resets at 00:00 UTC before retrying.
    /// </summary>
    public WithRawResponseTask<SimulationOnboardingSuiteViewDto> SimulationOnboardingControllerSuiteUpdateAsync(
        string suiteId,
        SimulationOnboardingSuiteUpdateDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SimulationOnboardingSuiteViewDto>(
            SimulationOnboardingControllerSuiteUpdateAsyncCore(
                suiteId,
                request,
                options,
                cancellationToken
            )
        );
    }
}
