namespace SlackNet
{
    public class Im : Hub
    {
        public Im() => IsMember = true;
        public bool IsUserDeleted { get; set; }

        public override string ToString() => Link.User(User).ToString();
    }
}