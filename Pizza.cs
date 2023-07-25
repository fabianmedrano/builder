using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Topping { get; set; }

        public override string ToString() {
            return $"pizza with {Dough} dough, {Sauce} sauce and {Topping} topping";
        }
    }
}
