using System;

using CA.Common.Enum;

namespace CA.Common.Model
{
    public class OrderDish
    {
        public Guid Id { get; set; }

        public Order Order { get; set; }

        public Dish Dish { get; set; }

        public PreparingStatus Status { get; set; }
    }
}
