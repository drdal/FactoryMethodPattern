using System;
namespace FactoryMethodPattern
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public ChicagoPizzaStore()
        {
        }

        // implementing the abstract method from PizzaStore
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            // Concrete Object creation
            if (type.Equals("cheese"))
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            //else if (type.Equals("pepperoni"))
            //{
            //    pizza = new PepperoniPizza();
            //}
            //else if (type.Equals("clam"))
            //{
            //    pizza = new ClamPizza();
            //}
            //else if (type.Equals("veggie"))
            //{
            //    pizza = new VeggiePizza();
            //}

            return pizza;
        }
    }
}

