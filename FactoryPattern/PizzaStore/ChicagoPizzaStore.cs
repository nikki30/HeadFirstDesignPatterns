namespace FactoryPattern
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            switch (item)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory) { Name = "Chicago Style Cheese Pizza" };
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory) { Name = "Chicago Style Veggie Pizza" };
                    break;
            }

            return pizza;
        }
    }
}