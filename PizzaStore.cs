using System;
namespace FactoryMethodPattern
{

    // THIS CLASS AND ITS SUBCLASSES ARE THE CREATOR CLASSES IN FACTORY METHOD
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(String type)
        {
            Pizza pizza;

            // Call for Abstract method
            // This Creator class has no idea which Concrete subclass will create the actual pizza
            // It's decoupled
            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        // abstract method
        // implemented in the real concrete PizzaStore-X classes
        // This is why it is called Factory method
        public abstract Pizza CreatePizza(String type);
        
    }
}

