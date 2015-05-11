using System;

namespace CA.Common.Model
{
    public class Bill
    {
        public Guid Id { get; set; }

        public double Summary { get; set; }

        public bool IsPaid { get; set; }

        public Client Client { get; set; }

        public Waiter Waiter { get; set; }
    }
}
