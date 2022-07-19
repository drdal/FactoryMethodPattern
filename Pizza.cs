using System;
namespace FactoryMethodPattern
{

    // THIS CLASS AND ITS SUBCLASSES ARE THE PRODUCT CLASSES IN FACTORY METHOD
    public abstract class Pizza
    {
        protected String? name;
        protected String? dough;
        protected String? sauce;
        protected List<string> toppings = new();

        // Methods in C# can only be overridden in a derived class if they are virtual

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing {0}", name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings:");
            foreach (string topping in toppings)
            {
                Console.WriteLine("     " + topping);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting {0} into diagonal slices", name);
        }

        public void Box()
        {
            Console.WriteLine("Boxing {0} in a official PizzaStore box", name);
        }

        public String getName()
        {
            return name;
        }


    }

}

