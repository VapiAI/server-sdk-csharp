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

    private async Task<LogsPaginatedResponse> GetInternalAsync(
        LogsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Type != null)
        {
            _query["type"] = request.Type.Value.ToString();
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
            _query["sortOrder"] = request.SortOrder.Value.ToString();
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        if (request.CreatedAtGt != null)
        {
            _query["createdAtGt"] = request.CreatedAtGt.Value.ToString();
        }
        if (request.CreatedAtLt != null)
        {
            _query["createdAtLt"] = request.CreatedAtLt.Value.ToString();
        }
        if (request.CreatedAtGe != null)
        {
            _query["createdAtGe"] = request.CreatedAtGe.Value.ToString();
        }
        if (request.CreatedAtLe != null)
        {
            _query["createdAtLe"] = request.CreatedAtLe.Value.ToString();
        }
        if (request.UpdatedAtGt != null)
        {
            _query["updatedAtGt"] = request.UpdatedAtGt.Value.ToString();
        }
        if (request.UpdatedAtLt != null)
        {
            _query["updatedAtLt"] = request.UpdatedAtLt.Value.ToString();
        }
        if (request.UpdatedAtGe != null)
        {
            _query["updatedAtGe"] = request.UpdatedAtGe.Value.ToString();
        }
        if (request.UpdatedAtLe != null)
        {
            _query["updatedAtLe"] = request.UpdatedAtLe.Value.ToString();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
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
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<LogsPaginatedResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new VapiClientException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new VapiClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    public async Task<Pager<Log>> GetAsync(
        LogsGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        if (request is not null)
        {
            request = request with { };
        }
        var pager = await OffsetPager<
            LogsGetRequest,
            RequestOptions?,
            LogsPaginatedResponse,
            double?,
            object,
            Log
        >
            .CreateInstanceAsync(
                request,
                options,
                GetInternalAsync,
                request => request?.Page ?? 0,
                (request, offset) =>
                {
                    request.Page = offset;
                },
                null,
                response => response?.Results?.ToList(),
                null,
                cancellationToken
            )
            .ConfigureAwait(false);
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
            _query["type"] = request.Type.Value.ToString();
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
            .SendRequestAsync(
                new JsonRequest
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
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new VapiClientApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}
