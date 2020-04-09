using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlackNet.Interaction
{
    public interface ISlackShortcuts
    {
        Task Handle(Shortcut request);
        void AddHandler(IShortcutHandler handler);
    }

    public class SlackShortcuts : ISlackShortcuts
    {
        private readonly List<IShortcutHandler> _handlers = new List<IShortcutHandler>();

        public Task Handle(Shortcut request) => Task.WhenAll(_handlers.Select(h => h.Handle(request)));

        public void AddHandler(IShortcutHandler handler) => _handlers.Add(handler);
    }
}