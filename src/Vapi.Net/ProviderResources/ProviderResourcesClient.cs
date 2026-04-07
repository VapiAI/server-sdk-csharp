using global::System.Text.Json;
using Vapi.Net.Core;

namespace Vapi.Net;

public partial class ProviderResourcesClient : IProviderResourcesClient
{
    private readonly RawClient _client;

    internal ProviderResourcesClient(RawClient client)
    {
        _client = client;
    }

    private async Task<
        WithRawResponse<ProviderResourcePaginatedResponse>
    > ProviderResourceControllerGetProviderResourcesPaginatedAsyncCore(
        ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider provider,
        ProviderResourceControllerGetProviderResourcesPaginatedRequestResourceName resourceName,
        ProviderResourceControllerGetProviderResourcesPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Vapi.Net.Core.QueryStringBuilder.Builder(capacity: 13)
            .Add("id", request.Id)
            .Add("resourceId", request.ResourceId)
            .Add("page", request.Page)
            .Add("sortOrder", request.SortOrder)
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
                        "provider/{0}/{1}",
                        ValueConvert.ToPathParameterString(provider),
                        ValueConvert.ToPathParameterString(resourceName)
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
                var responseData = JsonUtils.Deserialize<ProviderResourcePaginatedResponse>(
                    responseBody
                )!;
                return new WithRawResponse<ProviderResourcePaginatedResponse>()
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
        WithRawResponse<ProviderResource>
    > ProviderResourceControllerCreateProviderResourceAsyncCore(
        ProviderResourceControllerCreateProviderResourceRequestProvider provider,
        ProviderResourceControllerCreateProviderResourceRequestResourceName resourceName,
        ProviderResourceControllerCreateProviderResourceRequest request,
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
                        "provider/{0}/{1}",
                        ValueConvert.ToPathParameterString(provider),
                        ValueConvert.ToPathParameterString(resourceName)
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
                var responseData = JsonUtils.Deserialize<ProviderResource>(responseBody)!;
                return new WithRawResponse<ProviderResource>()
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
        WithRawResponse<ProviderResource>
    > ProviderResourceControllerGetProviderResourceAsyncCore(
        ProviderResourceControllerGetProviderResourceRequestProvider provider,
        ProviderResourceControllerGetProviderResourceRequestResourceName resourceName,
        string id,
        ProviderResourceControllerGetProviderResourceRequest request,
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
                        "provider/{0}/{1}/{2}",
                        ValueConvert.ToPathParameterString(provider),
                        ValueConvert.ToPathParameterString(resourceName),
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
                var responseData = JsonUtils.Deserialize<ProviderResource>(responseBody)!;
                return new WithRawResponse<ProviderResource>()
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
        WithRawResponse<ProviderResource>
    > ProviderResourceControllerDeleteProviderResourceAsyncCore(
        ProviderResourceControllerDeleteProviderResourceRequestProvider provider,
        ProviderResourceControllerDeleteProviderResourceRequestResourceName resourceName,
        string id,
        ProviderResourceControllerDeleteProviderResourceRequest request,
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
                        "provider/{0}/{1}/{2}",
                        ValueConvert.ToPathParameterString(provider),
                        ValueConvert.ToPathParameterString(resourceName),
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
                var responseData = JsonUtils.Deserialize<ProviderResource>(responseBody)!;
                return new WithRawResponse<ProviderResource>()
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
        WithRawResponse<ProviderResource>
    > ProviderResourceControllerUpdateProviderResourceAsyncCore(
        ProviderResourceControllerUpdateProviderResourceRequestProvider provider,
        ProviderResourceControllerUpdateProviderResourceRequestResourceName resourceName,
        string id,
        ProviderResourceControllerUpdateProviderResourceRequest request,
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
                        "provider/{0}/{1}/{2}",
                        ValueConvert.ToPathParameterString(provider),
                        ValueConvert.ToPathParameterString(resourceName),
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
                var responseData = JsonUtils.Deserialize<ProviderResource>(responseBody)!;
                return new WithRawResponse<ProviderResource>()
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

    public WithRawResponseTask<ProviderResourcePaginatedResponse> ProviderResourceControllerGetProviderResourcesPaginatedAsync(
        ProviderResourceControllerGetProviderResourcesPaginatedRequestProvider provider,
        ProviderResourceControllerGetProviderResourcesPaginatedRequestResourceName resourceName,
        ProviderResourceControllerGetProviderResourcesPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ProviderResourcePaginatedResponse>(
            ProviderResourceControllerGetProviderResourcesPaginatedAsyncCore(
                provider,
                resourceName,
                request,
                options,
                cancellationToken
            )
        );
    }

    public WithRawResponseTask<ProviderResource> ProviderResourceControllerCreateProviderResourceAsync(
        ProviderResourceControllerCreateProviderResourceRequestProvider provider,
        ProviderResourceControllerCreateProviderResourceRequestResourceName resourceName,
        ProviderResourceControllerCreateProviderResourceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ProviderResource>(
            ProviderResourceControllerCreateProviderResourceAsyncCore(
                provider,
                resourceName,
                request,
                options,
                cancellationToken
            )
        );
    }

    public WithRawResponseTask<ProviderResource> ProviderResourceControllerGetProviderResourceAsync(
        ProviderResourceControllerGetProviderResourceRequestProvider provider,
        ProviderResourceControllerGetProviderResourceRequestResourceName resourceName,
        string id,
        ProviderResourceControllerGetProviderResourceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ProviderResource>(
            ProviderResourceControllerGetProviderResourceAsyncCore(
                provider,
                resourceName,
                id,
                request,
                options,
                cancellationToken
            )
        );
    }

    public WithRawResponseTask<ProviderResource> ProviderResourceControllerDeleteProviderResourceAsync(
        ProviderResourceControllerDeleteProviderResourceRequestProvider provider,
        ProviderResourceControllerDeleteProviderResourceRequestResourceName resourceName,
        string id,
        ProviderResourceControllerDeleteProviderResourceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ProviderResource>(
            ProviderResourceControllerDeleteProviderResourceAsyncCore(
                provider,
                resourceName,
                id,
                request,
                options,
                cancellationToken
            )
        );
    }

    public WithRawResponseTask<ProviderResource> ProviderResourceControllerUpdateProviderResourceAsync(
        ProviderResourceControllerUpdateProviderResourceRequestProvider provider,
        ProviderResourceControllerUpdateProviderResourceRequestResourceName resourceName,
        string id,
        ProviderResourceControllerUpdateProviderResourceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ProviderResource>(
            ProviderResourceControllerUpdateProviderResourceAsyncCore(
                provider,
                resourceName,
                id,
                request,
                options,
                cancellationToken
            )
        );
    }
}
