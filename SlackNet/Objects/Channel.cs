using SlackNet.Events;
using System.Collections.Generic;

namespace SlackNet
{
    public class Channel : Hub
    {
        public bool IsChannel { get; set; }
        public int Unlinked { get; set; }
        public bool IsReadOnly { get; set; }
        /// <summary>
        /// The latest message in the channel.
        /// </summary>
        public MessageEvent Latest { get; set; }
        /// <summary>
        /// Full count of visible messages that the calling user has yet to read.
        /// </summary>
        public int UnreadCount { get; set; }
        /// <summary>
        /// Count of messages that the calling user has yet to read that matter to them (this means it excludes things like join/leave messages).
        /// </summary>
        public int UnreadCountDisplay { get; set; }

        /// <summary>
        /// A list of user IDs for all users in this channel. This includes any disabled accounts that were in this channel when they were disabled.
        /// </summary>
        public IList<string> Members { get; set; } = new List<string>();
        public override string ToString() => Link.Hub(Id).ToString();
    }
}