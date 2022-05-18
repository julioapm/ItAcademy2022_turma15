public static class PizzasServices
{
    private static List<Pizza> Pizzas {get;}
    static PizzasServices()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza {Id=1,Name="Napolitana", IsGlutenFree=false, Price=35.90M},
            new Pizza {Id=2,Name="Veggie", IsGlutenFree=true, Price=42.50M}
        };
    }
    public static IEnumerable<Pizza> GetAll()
    {
        return Pizzas.OrderBy(p => p.Name).ToArray();
    }
    public static Pizza? Get(int id)
    {
        return Pizzas.FirstOrDefault(p => p.Id == id);
    }
    public static void Add(Pizza pizza)
    {
        Pizzas.Add(pizza);
    }
    public static void Delete(int id)
    {
        var pizza = Get(id);
        if (pizza is null) return;
        Pizzas.Remove(pizza);
    }
}