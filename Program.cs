using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitchen kitchen = new Kitchen();
            kitchen.SetPizzaBuilder(new HawaiianPizzaBuilder());
            kitchen.ConstructPizza();
            Pizza hawaiianPizza = kitchen.GetPizza();

            kitchen.SetPizzaBuilder(new SpicyPizzaBuilder());
            kitchen.ConstructPizza();
            Pizza SpacyPizza = kitchen.GetPizza();

            Console.WriteLine(hawaiianPizza);
            Console.WriteLine(SpacyPizza);

        }
    }
}
