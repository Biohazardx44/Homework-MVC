using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel ToPizzaViewModel(this Pizza pizza)
        {
            decimal Price = pizza.Price;
            if (pizza.HasExtras)
            {
                Price += 10;
            }

            return new PizzaViewModel()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = Price,
                PizzaSize = pizza.PizzaSize,
                HasExtras = pizza.HasExtras
            };
        }
    }
}