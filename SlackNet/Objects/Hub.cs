using System;
using Newtonsoft.Json;

namespace SlackNet
{
    public class Hub
    {
        public string Id { get; set; }
        /// <summary>
        /// The name of the conversation or channel, without a leading hash sign.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Indicates a channel is archived. Frozen in time.
        /// </summary>
        public bool IsArchived { get; set; }
        /// <summary>
        /// True if this channel is the "general" channel that includes all regular team members.
        /// </summary>
        public bool IsGeneral { get; set; }
        public string NameNormalized { get; set; }
        /// <summary>
        /// Means the conversation is in some way shared between multiple workspaces. Have we mentioned how great <see cref="IsPrivate"/> is yet?
        /// </summary>
        public bool IsShared { get; set; }
        public bool IsOrgShared { get; set; }
        /// <summary>
        /// True if the calling member is part of the channel.
        /// </summary>
        public bool IsMember { get; set; }
        /// <summary>
        /// Means the conversation is privileged between two or more members. Meet their privacy expectations.
        /// </summary>
        public bool IsPrivate { get; set; }
        public bool? IsIm { get; set; }
        public bool? IsGroup { get; set; }
        public bool IsMpim { get; set; }
        /// <summary>
        /// Timestamp for the last message the calling user has read in this channel.
        /// </summary>
        public string LastRead { get; set; }
        public Topic Topic { get; set; }
        public Topic Purpose { get; set; }
        public string[] PreviousNames { get; set; }
        public int Created { get; set; }
        [JsonIgnore]
        public DateTime CreatedDateTime => Created.ToDateTime().GetValueOrDefault();
        /// <summary>
        /// The user ID of the member that created this channel.
        /// </summary>
        public string Creator { get; set; }

        public string User { get; set; }
    }
}