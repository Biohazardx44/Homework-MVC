﻿using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp
{
    public static class StaticDb
    {
        public static List<Pizza> Pizzas = new List<Pizza>
        {
            new Pizza 
            {
                Id = 1,
                Name = "Capri",
                Price = 300,
                IsOnPromotion = true,
                HasExtras = true,
                PizzaSize = PizzaSize.Normal
            },
            new Pizza
            {
                Id = 2,
                Name = "Pepperoni",
                Price = 400,
                IsOnPromotion = false,
                HasExtras = false,
                PizzaSize = PizzaSize.Family
            },
        };

        public static List<User> Users = new List<User>
        {
            new User 
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Bobsky",
                PhoneNumber = "12345",
                Address = "St.1 Potato Residence"
            },
            new User
            {
                Id = 2,
                FirstName = "Kate",
                LastName = "Katesy",
                PhoneNumber = "67890",
                Address = "St.2 Tomato Residence"
            },
        };

        public static List<Order> Orders = new List<Order>
        {
            new Order 
            {
                Id = 1,
                PizzaId = 1,
                UserId = 2,
                Pizza = Pizzas.First(),
                User = Users.First(user => user.Id == 2),
                PaymentMethod = PaymentMethod.Cash
            },
            new Order
            {
                Id = 2,
                PizzaId = 1,
                UserId = 1,
                Pizza = Pizzas.First(),
                User = Users.First(user => user.Id == 1),
                PaymentMethod = PaymentMethod.Card
            }
        };
    }
}
