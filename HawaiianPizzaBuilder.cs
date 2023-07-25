using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class HawaiianPizzaBuilder: PizzaBuilder
    {

        public override void BuildDough(){ pizza.Dough = "soft"; }
        public override void BuildSauce(){ pizza.Sauce = "sweet"; }
        public override void BuildTopping(){ pizza.Topping = "ham+pineapple"; }
    }
}
