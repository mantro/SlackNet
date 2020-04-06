namespace SlackNet
{
    public class Im
    {
        public string Id { get; set; }
        public bool IsIm { get; set; }
        public string User { get; set; }
        public string Created { get; set; }
        public bool IsUserDeleted { get; set; }
        public override string ToString() => Link.User(User).ToString();
    }
}