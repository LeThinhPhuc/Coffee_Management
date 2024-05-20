namespace CoffeeShopApi.Exceptions
{
    public class IngredientInUseException : Exception
    {
        public IngredientInUseException(string message) : base(message)
        {
        }
    }
}
