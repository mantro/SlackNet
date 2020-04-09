using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using SlackNet.Events;
using Args = System.Collections.Generic.Dictionary<string, object>;

namespace SlackNet.WebApi
{
    public interface IOAuthV2Api
    {
        /// <summary>
        /// Allows you to exchange a temporary OAuth code for an API access token. This is used as part of the OAuth authentication flow.
        /// See https://api.slack.com/methods/oauth.v2.access for more information.
        /// </summary>
        /// <param name="clientId">Issued when you created your application.</param>
        /// <param name="clientSecret">Issued when you created your application.</param>
        /// <param name="code">The code param returned via the OAuth callback.</param>
        /// <param name="redirectUrl">This must match the originally submitted URI (if one was sent).</param>
        /// <param name="cancellationToken"></param>
        Task<OAuthV2AccessResponse> Access(string clientId, string clientSecret, string code, string redirectUrl = null,
            CancellationToken? cancellationToken = null);
    }

    public class OAuthV2Api : IOAuthV2Api
    {
        private readonly ISlackApiClient _client;
        public OAuthV2Api(ISlackApiClient client) => _client = client;

        /// <summary>
        /// Allows you to exchange a temporary OAuth code for an API access token. This is used as part of the OAuth authentication flow.
        /// See https://api.slack.com/methods/oauth.access for more information.
        /// </summary>
        /// <param name="clientId">Issued when you created your application.</param>
        /// <param name="clientSecret">Issued when you created your application.</param>
        /// <param name="code">The code param returned via the OAuth callback.</param>
        /// <param name="redirectUrl">This must match the originally submitted URI (if one was sent).</param>
        /// <param name="cancellationToken"></param>
        public Task<OAuthV2AccessResponse> Access(string clientId, string clientSecret, string code,
            string redirectUrl = null, CancellationToken? cancellationToken = null) =>
            _client.Get<OAuthV2AccessResponse>("oauth.v2.access", new Args
            {
                {"client_id", clientId},
                {"client_secret", clientSecret},
                {"code", code},
                {"redirect_uri", redirectUrl}
            }, cancellationToken);

        // var args = new List<KeyValuePair<string, string>>
        // {
        //     new KeyValuePair<string, string>("client_id", clientId),
        //     new KeyValuePair<string, string>("client_secret", clientSecret),
        //     new KeyValuePair<string, string>("code", code),
        //     new KeyValuePair<string, string>("redirect_uri", redirectUrl),
        // };
        // var content = new FormUrlEncodedContent(args);
        // var requestMessage = new HttpRequestMessage(HttpMethod.Post, "https://slack.com/api/oauth.v2.access?token=xoxb-1026439339031-1054960914048-6AHHsm3TqsL3wiNEBPxsIOaX") { Content = content};
        // var response =  await _http.Execute<WebApiResponse>(requestMessage);
        // return new OAuthV2AccessResponse();
    }
}