namespace SlackNet
{
    public class Im : Hub
    {
        public string User { get; set; }
        public bool IsUserDeleted { get; set; }
        public override string ToString() => Link.User(User).ToString();
    }
}