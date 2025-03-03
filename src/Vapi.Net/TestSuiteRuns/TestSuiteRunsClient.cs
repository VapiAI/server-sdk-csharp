using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Vapi.Net.Core;

namespace Vapi.Net;

public partial class TestSuiteRunsClient
{
    private RawClient _client;

    internal TestSuiteRunsClient(RawClient client)
    {
        _client = client;
    }

    public async Task<TestSuiteRunsPaginatedResponse> TestSuiteRunControllerFindAllPaginatedAsync(
        string testSuiteId,
        TestSuiteRunControllerFindAllPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Page != null)
        {
            _query["page"] = request.Page.Value.ToString();
        }
        if (request.SortOrder != null)
        {
            _query["sortOrder"] = request.SortOrder.Value.Stringify();
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        if (request.CreatedAtGt != null)
        {
            _query["createdAtGt"] = request.CreatedAtGt.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.CreatedAtLt != null)
        {
            _query["createdAtLt"] = request.CreatedAtLt.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.CreatedAtGe != null)
        {
            _query["createdAtGe"] = request.CreatedAtGe.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.CreatedAtLe != null)
        {
            _query["createdAtLe"] = request.CreatedAtLe.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.UpdatedAtGt != null)
        {
            _query["updatedAtGt"] = request.UpdatedAtGt.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.UpdatedAtLt != null)
        {
            _query["updatedAtLt"] = request.UpdatedAtLt.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.UpdatedAtGe != null)
        {
            _query["updatedAtGe"] = request.UpdatedAtGe.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.UpdatedAtLe != null)
        {
            _query["updatedAtLe"] = request.UpdatedAtLe.Value.ToString(Constants.DateTimeFormat);
        }
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = $"test-suite/{JsonUtils.SerializeAsString(testSuiteId)}/run",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<TestSuiteRunsPaginatedResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new VapiClientException("Failed to deserialize response", e);
            }
        }

        throw new VapiClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    public async Task<TestSuiteRun> TestSuiteRunControllerCreateAsync(
        string testSuiteId,
        CreateTestSuiteRunDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = $"test-suite/{JsonUtils.SerializeAsString(testSuiteId)}/run",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<TestSuiteRun>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new VapiClientException("Failed to deserialize response", e);
            }
        }

        throw new VapiClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    public async Task<TestSuiteRun> TestSuiteRunControllerFindOneAsync(
        string testSuiteId,
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path =
                        $"test-suite/{JsonUtils.SerializeAsString(testSuiteId)}/run/{JsonUtils.SerializeAsString(id)}",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<TestSuiteRun>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new VapiClientException("Failed to deserialize response", e);
            }
        }

        throw new VapiClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    public async Task<TestSuiteRun> TestSuiteRunControllerRemoveAsync(
        string testSuiteId,
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Delete,
                    Path =
                        $"test-suite/{JsonUtils.SerializeAsString(testSuiteId)}/run/{JsonUtils.SerializeAsString(id)}",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<TestSuiteRun>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new VapiClientException("Failed to deserialize response", e);
            }
        }

        throw new VapiClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    public async Task<TestSuiteRun> TestSuiteRunControllerUpdateAsync(
        string testSuiteId,
        string id,
        UpdateTestSuiteRunDto request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethodExtensions.Patch,
                    Path =
                        $"test-suite/{JsonUtils.SerializeAsString(testSuiteId)}/run/{JsonUtils.SerializeAsString(id)}",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<TestSuiteRun>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new VapiClientException("Failed to deserialize response", e);
            }
        }

        throw new VapiClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
