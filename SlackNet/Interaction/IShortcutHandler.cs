using System.Threading.Tasks;

namespace SlackNet.Interaction
{
    public interface IShortcutHandler
    {
        Task Handle(Shortcut request);
    }
}
