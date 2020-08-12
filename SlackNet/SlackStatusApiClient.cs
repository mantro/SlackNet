using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SlackNet.StatusApi.Responses;

namespace SlackNet
{
    public interface ISlackStatusApiClient
    {
  

        /// <summary>
        /// Calls a Slack API method.
        /// </summary>
        /// <param name="cancellationToken"></param>
        Task<CurrentStatusResponse> Current(CancellationToken? cancellationToken = null);
    }

    public class SlackStatusApiClient : ISlackStatusApiClient
    {
        private readonly IHttp _http;
        private readonly SlackJsonSettings _jsonSettings;
        

        public SlackStatusApiClient(IHttp http, SlackJsonSettings jsonSettings)
        {
            _http = http;
            _jsonSettings = jsonSettings;
        }
        
        /// <summary>
        /// Calls a Slack API method.
        /// </summary>>
        /// <param name="cancellationToken"></param>
        public async Task<CurrentStatusResponse> Current(CancellationToken? cancellationToken = null)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://status.slack.com/api/v2.0.0/current");
            return Deserialize<CurrentStatusResponse>(await _http.Execute<JObject>(requestMessage, cancellationToken ?? CancellationToken.None).ConfigureAwait(false));
        }

        private T Deserialize<T>(JObject response) where T : class =>
            response?.ToObject<T>(JsonSerializer.Create(_jsonSettings.SerializerSettings));
    }
}