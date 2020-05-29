namespace SlackNet.WebApi
{
    public class OAuthV2AccessResponse
    {
        public bool Ok { get; set; }
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
        public string Scope { get; set; }
        public string BotUserID { get; set; }
        public string AppId { get; set; }
        public OAuthV2Team Team { get; set; }
        public OAuthV2User AuthedUser { get; set; }
        public OAuthV2Enterprise Enterprise { get; set; }

    }
}