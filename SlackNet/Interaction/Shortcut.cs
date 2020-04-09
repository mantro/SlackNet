using SlackNet.Events;

namespace SlackNet.Interaction
{
    public class Shortcut : InteractionRequest
    {
        public string CallbackId { get; set; }
        public string TriggerId { get; set; }
    }
}