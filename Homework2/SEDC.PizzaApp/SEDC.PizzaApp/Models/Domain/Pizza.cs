using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp.Models.Domain
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsOnPromotion { get; set; }
        public bool HasExtras { get; set; }
        public PizzaSize PizzaSize { get; set; }
    }
}