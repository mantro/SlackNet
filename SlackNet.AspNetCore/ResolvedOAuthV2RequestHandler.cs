using System;
using System.Threading.Tasks;
using SlackNet.Interaction;

namespace SlackNet.AspNetCore
{
    class ResolvedOAuthV2RequestHandler : ResolvedHandler<IOAuthV2RequestHandler>, IOAuthV2RequestHandler
    {
        public ResolvedOAuthV2RequestHandler(IServiceProvider serviceProvider, Func<IServiceProvider, IOAuthV2RequestHandler> getHandler)
            : base(serviceProvider, getHandler) { }

        public Task Handle(string code) => ResolvedHandle(h => h.Handle(code));
    }
}