using System;
namespace FactoryMethodPattern
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Ekstra thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }

        // Override a virtual method from the abstract Pizza class
        public override void Cut() {
            Console.WriteLine("Cutting {0} into square slices", name);
        }
         
    }
}

