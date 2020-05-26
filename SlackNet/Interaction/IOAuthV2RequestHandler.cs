using System.Threading.Tasks;

namespace SlackNet.Interaction
{
    public interface IOAuthV2RequestHandler
    {
        Task Handle(string code);
    }
}