namespace FactoryPattern
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            switch (item)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory) { Name = "New York Style Cheese Pizza" };
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory) { Name = "New York Style Veggie Pizza" };
                    break;
            }

            return pizza;
        }
    }
}