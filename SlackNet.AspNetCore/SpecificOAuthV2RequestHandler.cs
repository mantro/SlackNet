using System.Threading.Tasks;
using SlackNet.Interaction;

namespace SlackNet.AspNetCore
{
    class SpecificOAuthV2RequestHandler : IOAuthV2RequestHandler
    {
        private readonly string _responseUrl;
        private readonly IOAuthV2RequestHandler _handler;

        public SpecificOAuthV2RequestHandler(string responseUrl, IOAuthV2RequestHandler handler)
        {
            _responseUrl = responseUrl;
            _handler = handler;
        }

        public Task Handle(string code)
        {
            return _handler.Handle(code);
        }
    }
}