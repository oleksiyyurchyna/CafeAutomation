namespace CA.Common.Model
{
    public class Client : Man
    {
        public Client(string login)
            : base(login, string.Empty)
        {
        }

        public Client(string login, string displayName)
            : base(login, displayName)
        {
        }

        public long CardNumber { get; set; }
    }
}
