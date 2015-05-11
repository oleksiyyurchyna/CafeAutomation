using System;

namespace CA.Common.Model
{
    public class Dish
    {
        public Dish(string displayName, string description)
        {
            DisplayName = displayName;
            Description = description;
        }

        public Guid Id { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }
    }
}