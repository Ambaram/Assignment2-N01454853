using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment2_N01454853.Controllers
{
    [ApiController]
    [Route("api/J1/Menu/{Burger}/{Drink}/{Side}/{Dessert}")]
    public class J1Controller : Controller
    {
        /// <summary>
        /// This code computes the total calorie value of the meal.
        /// Menu contains burgers,drinks,side orders,dessert.
        /// Input provided in form of digit choice.
        /// </summary>
        /// <param name="Burger">Burger Choice</param>
        /// <param name="Drink">Drink Choice</param>
        /// <param name="Side">Side Order Choice</param>
        /// <param name="Dessert">Dessert Choice</param>
        /// <returns>This code returns the total calorie count of the meal.</returns>
        [HttpGet]
        public string Menu(int Burger, int Drink, int Side, int Dessert)
        {
            Dictionary<string, int> Burgers =
              new Dictionary<string, int>();
            Burgers.Add("CheeseBurger", 461);
            Burgers.Add("Fish Burger", 431);
            Burgers.Add("Veggie Burger", 420);
            Burgers.Add("No Burger", 0);

            Dictionary<string, int> Drinks =
              new Dictionary<string, int>();
            Drinks.Add("Soft Drink", 130);
            Drinks.Add("Orange Juice", 160);
            Drinks.Add("Milk", 118);
            Drinks.Add("no drink", 0);

            Dictionary<string, int> Sides =
              new Dictionary<string, int>();
            Sides.Add("Fries", 100);
            Sides.Add("Baked Potato", 57);
            Sides.Add("Chef Salad", 70);
            Sides.Add("no side order", 0);

            Dictionary<string, int> Desserts =
              new Dictionary<string, int>();
            Desserts.Add("Apple Pie", 167);
            Desserts.Add("Sundae", 266);
            Desserts.Add("Fruit Cup", 75);
            Desserts.Add("No Dessert", 0);

            int sum = Burgers.ElementAt(Burger-1).Value + Drinks.ElementAt(Drink-1).Value
              + Sides.ElementAt(Side-1).Value + Desserts.ElementAt(Dessert-1).Value;

            return ("Your total calorie count is "+ sum);
        }
    }
}