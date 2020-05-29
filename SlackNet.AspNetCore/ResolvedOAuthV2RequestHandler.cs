using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SlackNet.Interaction;

namespace SlackNet.AspNetCore
{
    class ResolvedOAuthV2RequestHandler : IOAuthV2RequestHandler
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Func<IServiceProvider, IOAuthV2RequestHandler> _getHandler;

        public ResolvedOAuthV2RequestHandler(IServiceProvider serviceProvider, Func<IServiceProvider, IOAuthV2RequestHandler> getHandler)
        {
            _serviceProvider = serviceProvider;
            _getHandler = getHandler;
        }

        public Task Handle(string code)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var handler = _getHandler(scope.ServiceProvider);
                return handler.Handle(code);
            }
        }
    }
}