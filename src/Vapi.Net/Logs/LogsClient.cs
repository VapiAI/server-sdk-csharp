using System.Net.Http;
using System.Text.Json;
using System.Threading;
using global::System.Threading.Tasks;
using Vapi.Net.Core;

namespace Vapi.Net;

public partial class LogsClient
{
    private RawClient _client;

    internal LogsClient(RawClient client)
    {
        _client = client;
    }

    public Pager<Log> GetAsync(LogsGetRequest request, RequestOptions? options = null)
    {
        if (request is not null)
        {
            request = request with { };
        }
        var pager = new OffsetPager<
            LogsGetRequest,
            RequestOptions?,
            LogsPaginatedResponse,
            double?,
            object,
            Log
        >(
            request,
            options,
            GetAsync,
            request => request?.Page ?? 0,
            (request, offset) =>
            {
                request.Page = offset;
            },
            null,
            response => response?.Results?.ToList(),
            null
        );
        return pager;
    }

    public async global::System.Threading.Tasks.Task LoggingControllerLogsDeleteQueryAsync(
        LoggingControllerLogsDeleteQueryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Type != null)
        {
            _query["type"] = request.Type.Value.Stringify();
        }
        if (request.AssistantId != null)
        {
            _query["assistantId"] = request.AssistantId;
        }
        if (request.PhoneNumberId != null)
        {
            _query["phoneNumberId"] = request.PhoneNumberId;
        }
        if (request.CustomerId != null)
        {
            _query["customerId"] = request.CustomerId;
        }
        if (request.SquadId != null)
        {
            _query["squadId"] = request.SquadId;
        }
        if (request.CallId != null)
        {
            _query["callId"] = request.CallId;
        }
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Delete,
                    Path = "logs",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        throw new VapiClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    private async Task<LogsPaginatedResponse> GetAsync(
        LogsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Type != null)
        {
            _query["type"] = request.Type.Value.Stringify();
        }
        if (request.WebhookType != null)
        {
            _query["webhookType"] = request.WebhookType;
        }
        if (request.AssistantId != null)
        {
            _query["assistantId"] = request.AssistantId;
        }
        if (request.PhoneNumberId != null)
        {
            _query["phoneNumberId"] = request.PhoneNumberId;
        }
        if (request.CustomerId != null)
        {
            _query["customerId"] = request.CustomerId;
        }
        if (request.SquadId != null)
        {
            _query["squadId"] = request.SquadId;
        }
        if (request.CallId != null)
        {
            _query["callId"] = request.CallId;
        }
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
                    Path = "logs",
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
                return JsonUtils.Deserialize<LogsPaginatedResponse>(responseBody)!;
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
