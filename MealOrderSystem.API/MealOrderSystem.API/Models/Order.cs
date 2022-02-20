using System;

namespace MealOrderSystem.API.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public Meal Meal { get; set; }

        public DateTime MealRequiredDate { get; set; }

        public int LocationId { get; set; }

        public string LocationCode { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
