using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    internal class SpicyPizzaBuilder:PizzaBuilder
    {
        public override void BuildDough(){ pizza.Dough = "Cooked"; }
        public override void BuildSauce(){ pizza.Sauce = "spicy"; }
        public override void BuildTopping(){ pizza.Topping = "pepper+sausage"; }
    }
}
