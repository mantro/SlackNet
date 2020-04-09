namespace SlackNet.WebApi
{
    public class OauthV2User
    {
        public string Id { get; set; }
        public string Scope { get; set; }
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
    }
}