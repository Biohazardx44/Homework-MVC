using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        [Route("ListOrders")]
        public IActionResult Index()
        {
            //List<Order> ordersFromDb = StaticDb.Orders;

            //==MAPPING WITH EXTENSION METHOD AND LINQ==
            //List<OrderViewModel> orderViewModels = ordersFromDb.Select(order => order.ToOrderViewModelExtension()).ToList();

            //return View(orderViewModels);
            return View();
        }

        [Route("[controller]/Details/{id?}")]
        public IActionResult Details(int? id)
        {
            //if (id == null)
            //{
            //    return RedirectToAction("Error", "Pizza");
            //}

            //Order order = StaticDb.Orders.FirstOrDefault(order => order.Id == id);

            //if (order == null)
            //{
            //    return RedirectToAction("Error", "Pizza");
            //}

            //OrderViewModel orderViewModel = order.ToOrderViewModelExtension();

            //return View(orderViewModel);

            if (id == null)
            {
                return new EmptyResult();
            }

            return View();
        }

        public IActionResult JsonData()
        {
            var model = new ExampleModel
            {
                Id = 1,
                Name = "Example Name",
                Description = "Example Description"
            };

            return new JsonResult(model);
        }

        public IActionResult RedirectToHomeIndex()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}