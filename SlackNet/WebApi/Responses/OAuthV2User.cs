namespace SlackNet.WebApi
{
    public class OAuthV2User
    {
        public string Id { get; set; }
        public string Scope { get; set; }
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
    }
}