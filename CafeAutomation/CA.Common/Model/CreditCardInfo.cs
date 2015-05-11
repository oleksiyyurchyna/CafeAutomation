using System;

namespace CA.Common.Model
{
    public class CreditCardInfo
    {
        public byte[] NumberHash { get; set; }

        public byte[] CvvCodeHash { get; set; }

        public DateTime ExpirationDate { get; set; }

        public Client Client { get; set; }
    }
}
