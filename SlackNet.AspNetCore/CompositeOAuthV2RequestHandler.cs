using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SlackNet.Interaction;

namespace SlackNet.AspNetCore
{
    class CompositeOAuthV2RequestHandler : IOAuthV2RequestHandler
    {
        private readonly List<CompositeItem<IOAuthV2RequestHandler>> _handlers;
        public CompositeOAuthV2RequestHandler(IEnumerable<CompositeItem<IOAuthV2RequestHandler>> handlers) => _handlers = handlers.ToList();

        public Task Handle(string code) => Task.WhenAll(_handlers.Select(h => h.Item.Handle(code)));
    }
}