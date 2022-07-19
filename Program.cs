// See https://aka.ms/new-console-template for more information
Console.WriteLine("-- Factory Method Design Pattern Project --");

FactoryMethodPattern.PizzaStore nyStore = new FactoryMethodPattern.NYPizzaStore();
FactoryMethodPattern.PizzaStore chicagoStore = new FactoryMethodPattern.ChicagoPizzaStore();

FactoryMethodPattern.Pizza pizza = nyStore.OrderPizza("cheese");
Console.WriteLine("Ethan ordered a " + pizza.getName());

Console.WriteLine("-----------------------------------");

pizza = chicagoStore.OrderPizza("cheese");
Console.WriteLine("Joel ordered a " + pizza.getName());
