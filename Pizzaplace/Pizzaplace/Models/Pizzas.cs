namespace Pizzaplace.Models
{
    public class Pizzas
    {
        public int Id { get; set; }
        public string? PizzaName { get; set; }
        public int PrepareTime { get; set; }
        public decimal PizzaPrice { get; set; }
    }
}
