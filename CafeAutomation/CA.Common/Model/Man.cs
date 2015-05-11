using System;

namespace CA.Common.Model
{
    public class Man
    {
        public Man(string login, string displayName)
        {
            Id = Guid.NewGuid();
            Login = login;
            DisplayName = displayName;
        }

        public Man()
            : this(string.Empty, string.Empty)
        {
        }

        public Guid Id { get; set; }

        public string Login { get; set; }

        public string DisplayName { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
