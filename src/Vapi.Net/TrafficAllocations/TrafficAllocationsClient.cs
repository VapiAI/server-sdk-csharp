using global::System.Text.Json;
using Vapi.Net.Core;

namespace Vapi.Net;

public partial class TrafficAllocationsClient : ITrafficAllocationsClient
{
    private readonly RawClient _client;

    internal TrafficAllocationsClient(RawClient client)
    {
        _client = client;
    }

    private async Task<
        WithRawResponse<TrafficAllocationPaginatedResponse>
    > TrafficAllocationControllerFindAllPaginatedAsyncCore(
        TrafficAllocationControllerFindAllPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Vapi.Net.Core.QueryStringBuilder.Builder(capacity: 4)
            .Add("assistantId", request.AssistantId)
            .Add("page", request.Page)
            .Add("limit", request.Limit)
            .Add("sortOrder", request.SortOrder)
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
                    Path = "traffic-allocations",
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
                var responseData = JsonUtils.Deserialize<TrafficAllocationPaginatedResponse>(
                    responseBody
                )!;
                return new WithRawResponse<TrafficAllocationPaginatedResponse>()
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
                    case 403:
                        throw new ForbiddenError(JsonUtils.Deserialize<object>(responseBody));
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
        WithRawResponse<TrafficAllocation>
    > TrafficAllocationControllerCreateAsyncCore(
        CreateTrafficAllocationDto request,
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
                    Path = "traffic-allocations",
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
                var responseData = JsonUtils.Deserialize<TrafficAllocation>(responseBody)!;
                return new WithRawResponse<TrafficAllocation>()
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
        WithRawResponse<TrafficAllocationLatestResponseDto>
    > TrafficAllocationControllerLatestGetAsyncCore(
        TrafficAllocationControllerLatestGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Vapi.Net.Core.QueryStringBuilder.Builder(capacity: 1)
            .Add("assistantId", request.AssistantId)
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
                    Path = "traffic-allocations/latest",
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
                var responseData = JsonUtils.Deserialize<TrafficAllocationLatestResponseDto>(
                    responseBody
                )!;
                return new WithRawResponse<TrafficAllocationLatestResponseDto>()
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
        WithRawResponse<TrafficTabMetricsDto>
    > TrafficAllocationControllerMetricsGetAsyncCore(
        TrafficAllocationControllerMetricsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Vapi.Net.Core.QueryStringBuilder.Builder(capacity: 5)
            .Add("assistantId", request.AssistantId)
            .Add("from", request.From)
            .Add("to", request.To)
            .Add("bucket", request.Bucket)
            .Add("structuredOutputIds", request.StructuredOutputIds)
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
                    Path = "traffic-allocations/metrics",
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
                var responseData = JsonUtils.Deserialize<TrafficTabMetricsDto>(responseBody)!;
                return new WithRawResponse<TrafficTabMetricsDto>()
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
        WithRawResponse<TrafficAllocation>
    > TrafficAllocationControllerFindOneAsyncCore(
        string id,
        TrafficAllocationControllerFindOneRequest request,
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
                        "traffic-allocations/{0}",
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
                var responseData = JsonUtils.Deserialize<TrafficAllocation>(responseBody)!;
                return new WithRawResponse<TrafficAllocation>()
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
                    case 403:
                        throw new ForbiddenError(JsonUtils.Deserialize<object>(responseBody));
                    case 404:
                        throw new NotFoundError(JsonUtils.Deserialize<object>(responseBody));
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
    /// The append-only history of an assistant's allocations, newest first.
    /// </summary>
    public WithRawResponseTask<TrafficAllocationPaginatedResponse> TrafficAllocationControllerFindAllPaginatedAsync(
        TrafficAllocationControllerFindAllPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<TrafficAllocationPaginatedResponse>(
            TrafficAllocationControllerFindAllPaginatedAsyncCore(
                request,
                options,
                cancellationToken
            )
        );
    }

    /// <summary>
    /// Creates a new traffic allocation for an assistant, replacing the one currently in effect. To start or adjust a split, send targets naming published versions (such as "v7") with percentages totaling 100; allocationIntent is inferred as 'explicit'. To stop splitting and send every call to the newest published version, send allocationIntent 'follow-latest' with no targets field; stopping always names its intent, so a dropped targets field can never end a split by accident.
    /// </summary>
    public WithRawResponseTask<TrafficAllocation> TrafficAllocationControllerCreateAsync(
        CreateTrafficAllocationDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<TrafficAllocation>(
            TrafficAllocationControllerCreateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// The allocation currently in effect for the assistant, with its targets. The response carries no allocation field when traffic splitting has never been configured.
    /// </summary>
    public WithRawResponseTask<TrafficAllocationLatestResponseDto> TrafficAllocationControllerLatestGetAsync(
        TrafficAllocationControllerLatestGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<TrafficAllocationLatestResponseDto>(
            TrafficAllocationControllerLatestGetAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Per-assistant-version call metrics over a time window: call counts, configured vs actual traffic share, duration, cost per minute, latency, ended reasons, a bucketed timeseries, and optional structured output aggregations. Calls with no assistant version are reported as an 'unversioned' row.
    /// </summary>
    public WithRawResponseTask<TrafficTabMetricsDto> TrafficAllocationControllerMetricsGetAsync(
        TrafficAllocationControllerMetricsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<TrafficTabMetricsDto>(
            TrafficAllocationControllerMetricsGetAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Returns a single allocation by id, including its targets and actor attribution.
    /// </summary>
    public WithRawResponseTask<TrafficAllocation> TrafficAllocationControllerFindOneAsync(
        string id,
        TrafficAllocationControllerFindOneRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<TrafficAllocation>(
            TrafficAllocationControllerFindOneAsyncCore(id, request, options, cancellationToken)
        );
    }
}
