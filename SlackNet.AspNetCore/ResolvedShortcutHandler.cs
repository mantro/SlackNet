using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SlackNet.Interaction;

namespace SlackNet.AspNetCore
{
    class ResolvedShortcutHandler<T> : IShortcutHandler
        where T : IShortcutHandler
    {
        private readonly IServiceProvider _serviceProvider;

        public ResolvedShortcutHandler(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task Handle(Shortcut request)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var handler = scope.ServiceProvider.GetRequiredService<T>();
                await handler.Handle(request).ConfigureAwait(false);
            }
        }
    }
}