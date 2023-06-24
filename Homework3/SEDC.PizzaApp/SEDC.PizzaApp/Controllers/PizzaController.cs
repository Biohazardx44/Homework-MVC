using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult GetPizzas() 
        {
            var pizzas = StaticDb.Pizzas;
            var pizzaViewModel = pizzas.Select(p => p.ToPizzaListViewModel()).ToList();

            return View(pizzaViewModel);
        }

        public IActionResult Details(int? id) 
        {
            if (id == null) 
            {
                return RedirectToAction("Error");
            }

            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(pizza => pizza.Id == id);

            if (pizza == null) 
            {
                return RedirectToAction("Error");
            }

            PizzaViewModel viewModel = pizza.ToPizzaViewModel();

            return View(viewModel);
        }

        public IActionResult Error() 
        {
            return View();
        }
    }
}