using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class Kitchen
    {
        private PizzaBuilder pizzaBuilder;
        public void SetPizzaBuilder(PizzaBuilder pb) { pizzaBuilder = pb; }
        public Pizza GetPizza() { return pizzaBuilder.GetPizza(); }
        public void ConstructPizza() {
            pizzaBuilder.CreateNewPizza();
            pizzaBuilder.BuildDough();
            pizzaBuilder.BuildSauce();
            pizzaBuilder.BuildTopping();
        }
    }
}
