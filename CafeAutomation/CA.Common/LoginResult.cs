using CA.Common.Enum;
using CA.Common.Model;

namespace CA.Common
{
    public class LoginResult
    {
        public LoginResult(LoginResultEnum result, Man man, string message)
        {
            Result = result;
            Man = man;
            Message = message;
        }

        public LoginResult()
            : this(LoginResultEnum.None, null, string.Empty)
        {
        }

        public LoginResultEnum Result { get; set; }

        public Man Man { get; set; }

        public string Message { get; set; }
    }
}
