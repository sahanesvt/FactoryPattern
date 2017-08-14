using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        internal string name;
        internal string dough;
        internal string sauce;
        internal List<string> toppings = new List<string>();



        internal void prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings:");
            foreach (var topping in toppings)
            {
                Console.WriteLine("   " + topping);
            }
        }

        internal void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350 ");
        }

        internal virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        internal void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string getName()
        {
            return name;
        }
    }
}
