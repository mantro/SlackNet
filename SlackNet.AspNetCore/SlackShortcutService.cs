using System.Collections.Generic;
using System.Threading.Tasks;
using SlackNet.Interaction;

namespace SlackNet.AspNetCore
{
    class SlackShortcutService : ISlackShortcuts
    {
        private readonly ISlackShortcuts _actions = new SlackShortcuts();

        public SlackShortcutService(IEnumerable<IShortcutHandler> handlers)
        {
            foreach (var handler in handlers)
                AddHandler(handler);
        }

        public Task Handle(Shortcut request) => _actions.Handle(request);
        public void AddHandler(IShortcutHandler handler) => _actions.AddHandler(handler);
    }
}