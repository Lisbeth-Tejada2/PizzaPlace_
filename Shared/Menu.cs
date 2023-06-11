
using PizzaPlace_.Shared;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace_.Shared
{
    public class Menu
    {
        public List<Pizzas> Pizzas { get; set; }
        = new List<Pizzas>();

        public void Add(Pizzas pizza)
        => Pizzas.Add(pizza);

        public Pizzas? GetPizza(int id)
        => Pizzas.SingleOrDefault(pizza => pizza.Id == id);
    }
}