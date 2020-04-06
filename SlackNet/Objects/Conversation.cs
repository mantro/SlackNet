namespace SlackNet
{
    public class Conversation : Hub
    {
        public bool IsIm { get; set; }
        public bool IsGroup { get; set; }
        public int Unlinked { get; set; }
        /// <summary>
        /// Means the conversation can't be written to by typical users. Admins may have the ability.
        /// </summary>
        public bool IsReadOnly { get; set; }
        /// <summary>
        /// Represents this conversation as being part of a Shared Channel with a remote organization.
        /// Your app should make sure the data it shares in such a channel is appropriate for both workspaces.
        /// <see cref="IsShared"/> will also be True.
        /// </summary>
        public bool IsExtShared { get; set; }
        public object[] PendingShared { get; set; }
        /// <summary>
        /// Is intriguing. It means the conversation is ready to become an <see cref="IsExtShared"/> channel but isn't quite ready yet
        /// and needs some kind of approval or sign off. Best to treat it as if it were a shared channel, even if it traverses only one workspace.
        /// </summary>
        public bool IsPendingExtShared { get; set; }
        public int NumMembers { get; set; }
        public string Locale { get; set; }
        /// <summary>
        /// Indicates the "host" of a shared channel. The value may contain a workspace's ID (beginning with T) or an enterprise grid organization's ID (beginning with E).
        /// </summary>
        public string ConversationHostId { get; set; }
        public int Priority { get; set; }
    }
}