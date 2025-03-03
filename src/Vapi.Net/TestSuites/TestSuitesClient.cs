using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Vapi.Net.Core;

namespace Vapi.Net;

public partial class TestSuitesClient
{
    private RawClient _client;

    internal TestSuitesClient(RawClient client)
    {
        _client = client;
    }

    public async Task<TestSuitesPaginatedResponse> TestSuiteControllerFindAllPaginatedAsync(
        TestSuiteControllerFindAllPaginatedRequest request,
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
                    Path = "test-suite",
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
                return JsonUtils.Deserialize<TestSuitesPaginatedResponse>(responseBody)!;
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

    public async Task<TestSuite> TestSuiteControllerCreateAsync(
        CreateTestSuiteDto request,
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
                    Path = "test-suite",
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
                return JsonUtils.Deserialize<TestSuite>(responseBody)!;
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

    public async Task<TestSuite> TestSuiteControllerFindOneAsync(
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
                    Path = $"test-suite/{JsonUtils.SerializeAsString(id)}",
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
                return JsonUtils.Deserialize<TestSuite>(responseBody)!;
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

    public async Task<TestSuite> TestSuiteControllerRemoveAsync(
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
                    Path = $"test-suite/{JsonUtils.SerializeAsString(id)}",
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
                return JsonUtils.Deserialize<TestSuite>(responseBody)!;
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

    public async Task<TestSuite> TestSuiteControllerUpdateAsync(
        string id,
        UpdateTestSuiteDto request,
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
                    Path = $"test-suite/{JsonUtils.SerializeAsString(id)}",
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
                return JsonUtils.Deserialize<TestSuite>(responseBody)!;
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
