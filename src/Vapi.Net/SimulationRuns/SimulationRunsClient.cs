using global::System.Text.Json;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

public partial class SimulationRunsClient : ISimulationRunsClient
{
    private readonly RawClient _client;

    internal SimulationRunsClient(RawClient client)
    {
        _client = client;
    }

    private async Task<
        WithRawResponse<OneOf<IEnumerable<SimulationRun>, SimulationRunsPaginatedResponse>>
    > SimulationRunControllerFindAllAsyncCore(
        SimulationRunControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Vapi.Net.Core.QueryStringBuilder.Builder(capacity: 16)
            .Add("status", request.Status)
            .Add("filterStatus", request.FilterStatus)
            .Add("targetType", request.TargetType)
            .Add("targetId", request.TargetId)
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
                    Path = "eval/simulation/run",
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
                    OneOf<IEnumerable<SimulationRun>, SimulationRunsPaginatedResponse>
                >(responseBody)!;
                return new WithRawResponse<
                    OneOf<IEnumerable<SimulationRun>, SimulationRunsPaginatedResponse>
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

    private async Task<
        WithRawResponse<CreateSimulationRunResponse>
    > SimulationRunControllerCreateAsyncCore(
        CreateSimulationRunDto request,
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
                    Path = "eval/simulation/run",
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
                var responseData = JsonUtils.Deserialize<CreateSimulationRunResponse>(
                    responseBody
                )!;
                return new WithRawResponse<CreateSimulationRunResponse>()
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
                    case 402:
                        throw new PaymentRequiredError(
                            JsonUtils.Deserialize<SimulationRunPaymentRequiredResponse>(
                                responseBody
                            )
                        );
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

    private async Task<WithRawResponse<SimulationRun>> SimulationRunControllerFindOneAsyncCore(
        string id,
        SimulationRunControllerFindOneRequest request,
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
                        "eval/simulation/run/{0}",
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
                var responseData = JsonUtils.Deserialize<SimulationRun>(responseBody)!;
                return new WithRawResponse<SimulationRun>()
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

    private async Task<WithRawResponse<SimulationRun>> SimulationRunControllerCancelGroupAsyncCore(
        string id,
        SimulationRunControllerCancelGroupRequest request,
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
                        "eval/simulation/run/{0}",
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
                var responseData = JsonUtils.Deserialize<SimulationRun>(responseBody)!;
                return new WithRawResponse<SimulationRun>()
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
        WithRawResponse<IEnumerable<SimulationRunItem>>
    > SimulationRunControllerFindItemsAsyncCore(
        string id,
        SimulationRunControllerFindItemsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Vapi.Net.Core.QueryStringBuilder.Builder(capacity: 15)
            .Add("simulationId", request.SimulationId)
            .Add("runId", request.RunId)
            .Add("status", request.Status)
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
                    Path = string.Format(
                        "eval/simulation/run/{0}/item",
                        ValueConvert.ToPathParameterString(id)
                    ),
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
                var responseData = JsonUtils.Deserialize<IEnumerable<SimulationRunItem>>(
                    responseBody
                )!;
                return new WithRawResponse<IEnumerable<SimulationRunItem>>()
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

    private async Task<WithRawResponse<SimulationRunItem>> SimulationRunControllerFindItemAsyncCore(
        string id,
        string itemId,
        SimulationRunControllerFindItemRequest request,
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
                        "eval/simulation/run/{0}/item/{1}",
                        ValueConvert.ToPathParameterString(id),
                        ValueConvert.ToPathParameterString(itemId)
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
                var responseData = JsonUtils.Deserialize<SimulationRunItem>(responseBody)!;
                return new WithRawResponse<SimulationRunItem>()
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
        WithRawResponse<SimulationRunItem>
    > SimulationRunControllerCancelItemAsyncCore(
        string id,
        string itemId,
        SimulationRunControllerCancelItemRequest request,
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
                        "eval/simulation/run/{0}/item/{1}",
                        ValueConvert.ToPathParameterString(id),
                        ValueConvert.ToPathParameterString(itemId)
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
                var responseData = JsonUtils.Deserialize<SimulationRunItem>(responseBody)!;
                return new WithRawResponse<SimulationRunItem>()
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

    /// <summary>
    /// Returns the simulation runs for the authenticated organization.
    /// </summary>
    public WithRawResponseTask<
        OneOf<IEnumerable<SimulationRun>, SimulationRunsPaginatedResponse>
    > SimulationRunControllerFindAllAsync(
        SimulationRunControllerFindAllRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<
            OneOf<IEnumerable<SimulationRun>, SimulationRunsPaginatedResponse>
        >(SimulationRunControllerFindAllAsyncCore(request, options, cancellationToken));
    }

    /// <summary>
    /// Starts a simulation run against a target assistant or squad.
    /// </summary>
    public WithRawResponseTask<CreateSimulationRunResponse> SimulationRunControllerCreateAsync(
        CreateSimulationRunDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<CreateSimulationRunResponse>(
            SimulationRunControllerCreateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Returns the specified simulation run, including its status and item counts.
    /// </summary>
    public WithRawResponseTask<SimulationRun> SimulationRunControllerFindOneAsync(
        string id,
        SimulationRunControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SimulationRun>(
            SimulationRunControllerFindOneAsyncCore(id, request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Cancels the specified simulation run.
    /// </summary>
    public WithRawResponseTask<SimulationRun> SimulationRunControllerCancelGroupAsync(
        string id,
        SimulationRunControllerCancelGroupRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SimulationRun>(
            SimulationRunControllerCancelGroupAsyncCore(id, request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Returns the run items for the specified simulation run.
    /// </summary>
    public WithRawResponseTask<
        IEnumerable<SimulationRunItem>
    > SimulationRunControllerFindItemsAsync(
        string id,
        SimulationRunControllerFindItemsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<IEnumerable<SimulationRunItem>>(
            SimulationRunControllerFindItemsAsyncCore(id, request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Returns the specified run item, including its evaluation results and the ID of the call that ran it.
    /// </summary>
    public WithRawResponseTask<SimulationRunItem> SimulationRunControllerFindItemAsync(
        string id,
        string itemId,
        SimulationRunControllerFindItemRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SimulationRunItem>(
            SimulationRunControllerFindItemAsyncCore(
                id,
                itemId,
                request,
                options,
                cancellationToken
            )
        );
    }

    /// <summary>
    /// Cancels the specified run item.
    /// </summary>
    public WithRawResponseTask<SimulationRunItem> SimulationRunControllerCancelItemAsync(
        string id,
        string itemId,
        SimulationRunControllerCancelItemRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SimulationRunItem>(
            SimulationRunControllerCancelItemAsyncCore(
                id,
                itemId,
                request,
                options,
                cancellationToken
            )
        );
    }

    /// <summary>
    /// Generates AI suggestions for improving the assistant or squad's system prompt, tools, and scenarios, based on the specified run item.
    /// </summary>
    public async Task SimulationRunControllerGenerateSuggestionsAsync(
        string id,
        string itemId,
        SimulationRunControllerGenerateSuggestionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Vapi.Net.Core.QueryStringBuilder.Builder(capacity: 2)
            .Add("force", request.Force)
            .Add("persist", request.Persist)
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
                    Method = HttpMethod.Post,
                    Path = string.Format(
                        "eval/simulation/run/{0}/item/{1}/generate",
                        ValueConvert.ToPathParameterString(id),
                        ValueConvert.ToPathParameterString(itemId)
                    ),
                    QueryString = _queryString,
                    Headers = _headers,
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
}
