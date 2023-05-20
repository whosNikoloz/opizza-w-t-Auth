using Microsoft.AspNetCore.Mvc;
using MVCPizza.Context;
using MVCPizza.Models;

namespace MVCPizza.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderDbContext _context;
        private readonly PizzaDbContext _Context;

        public OrderController(OrderDbContext context, PizzaDbContext context1)
        {
            _context = context;
            _Context = context1;
        }

        [HttpPost]
        public IActionResult Create(int id)
        {
            Pizza pizza = _Context.Pizzas.Find(id);

            if (pizza == null)
            {
                // Handle the case where the pizza with the specified ID was not found
                return NotFound();
            }

            var newOrder = new OrderModel
            {
                PizzaName = pizza.PizzaName,
                FinalPrice = pizza.FinalPrice,
                TomatoSauce = pizza.TomatoSauce,
                Ham = pizza.Ham,
                Pepperoni = pizza.Pepperoni,
                Mushrooms = pizza.Mushrooms,
                Olives = pizza.Olives,
                CheeseType = pizza.CheeseType,
                Bacon = pizza.Bacon,
                Onions = pizza.Onions,
                GreenPeppers = pizza.GreenPeppers,
                Pineapple = pizza.Pineapple,
                Jalapenos = pizza.Jalapenos,
                Anchovies = pizza.Anchovies,

                OrderDate = DateTime.Now
            };

            _context.Orders.Add(newOrder);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public IActionResult Custom(OrderModel model)
        {

            var newOrder = new OrderModel
            {
                PizzaName = model.PizzaName,
                FinalPrice = model.FinalPrice,
                TomatoSauce = model.TomatoSauce,
                Ham = model.Ham,
                Pepperoni = model.Pepperoni,
                Mushrooms = model.Mushrooms,
                Olives = model.Olives,
                CheeseType = model.CheeseType,
                Bacon = model.Bacon,
                Onions = model.Onions,
                GreenPeppers = model.GreenPeppers,
                Pineapple = model.Pineapple,
                Jalapenos =model.Jalapenos,
                Anchovies = model.Anchovies,

                OrderDate = DateTime.Now
            };

            _context.Orders.Add(newOrder);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public IActionResult CustomEdit(OrderModel model)
        {

            var newOrder = new OrderModel
            {
                PizzaName = model.PizzaName,
                FinalPrice = model.FinalPrice,
                TomatoSauce = model.TomatoSauce,
                Ham = model.Ham,
                Pepperoni = model.Pepperoni,
                Mushrooms = model.Mushrooms,
                Olives = model.Olives,
                CheeseType = model.CheeseType,
                Bacon = model.Bacon,
                Onions = model.Onions,
                GreenPeppers = model.GreenPeppers,
                Pineapple = model.Pineapple,
                Jalapenos = model.Jalapenos,
                Anchovies = model.Anchovies,

                OrderDate = DateTime.Now
            };

            _context.Orders.Add(newOrder);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}
