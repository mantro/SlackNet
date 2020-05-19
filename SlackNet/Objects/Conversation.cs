using System;
using Newtonsoft.Json;

namespace SlackNet
{
    public class Conversation : Hub
    {

        /// <summary>
        /// The name of the channel-like thing, without a leading hash sign. Don't get too attached to that name. It might change.
        /// Don't bother storing it even. When thinking about channel-like things, think about their IDs and their type and the team/workspace they belong to.
        /// </summary>
        public string Name { get; set; }

        [JsonIgnore]
        public DateTime CreatedDate => Created.ToDateTime().GetValueOrDefault();

        /// <summary>
        /// The user ID of the member that created this channel.
        /// </summary>
        public string Creator { get; set; }

        /// <summary>
        /// Indicates the "host" of a shared channel. The value may contain a workspace's ID (beginning with T) or an enterprise grid organization's ID (beginning with E).
        /// </summary>
        public string ConversationHostId { get; set; }
        
        /// <summary>
        /// Indicates a conversation is archived. Frozen in time.
        /// </summary>
        public bool IsArchived { get; set; }

        public int Unlinked { get; set; }

        public string NameNormalized { get; set; }

        /// <summary>
        /// Means the conversation is in some way shared between multiple workspaces. Look for <see cref="IsExtShared"/> and <see cref="IsOrgShared"/>
        /// to learn which kind it is, and if that matters, act accordingly. Have we mentioned how great <see cref="IsPrivate"/> is yet?
        /// </summary>
        public bool IsShared { get; set; }

        /// <summary>
        /// Represents this conversation as being part of a Shared Channel with a remote organization.
        /// Your app should make sure the data it shares in such a channel is appropriate for both workspaces.
        /// <see cref="IsShared"/> will also be True.
        /// </summary>
        public bool IsExtShared { get; set; }


        /// <summary>
        /// Is intriguing. It means the conversation is ready to become an <see cref="IsExtShared"/> channel but isn't quite ready yet
        /// and needs some kind of approval or sign off. Best to treat it as if it were a shared channel, even if it traverses only one workspace.
        /// </summary>
        public bool IsPendingExtShared { get; set; }

        /// <summary>
        /// Means the conversation is privileged between two or more members. Meet their privacy expectations.
        /// </summary>
        public bool IsPrivate { get; set; }

        public Topic Topic { get; set; }

        public Purpose Purpose { get; set; }

        public string[] PreviousNames { get; set; }

        public int Priority { get; set; }

        /// <summary>
        /// Means the conversation can't be written to by typical users. Admins may have the ability.
        /// </summary>
        public bool IsReadOnly { get; set; }

        public int NumMembers { get; set; }

        public string Locale { get; set; }
    }
}