namespace Advanced2;

public class Product 
{ 
    public int Id { get; set; } 
    public string Name { get; set; } 
    public string Category { get; set; } // "Electronics", "Clothing", "Food", "Books" 
    public double Price { get; set; } 
    public int Stock { get; set; }

    public static void SearchProducts(List<Product> products, Func<Product, bool> filter)
    {
        foreach (var product in products)
        {
            if (filter(product))
            {
                Console.WriteLine(product.Name + ", " + "$" + product.Price + " (Stock:" + product.Stock + ")");
            }
        }
    }

    public static void PrintReport(List<Product> products, Action<Product> action)
    {
        foreach (var product in products)
        {
            action(product);
        }
    }

    public static void TransformProducts(List<Product> products, Func<Product,string> func)
    {
        foreach (var product in products)
        {
            Console.WriteLine(func(product));
        }
    }

    public static void FilterProducts(List<Product> products, Predicate<Product> filter)
    {
        foreach (var product in products)
        {
            var alert = filter(product);
            if (alert)
            {
                Console.WriteLine($"[LOW STOCK] {product.Name}: only {product.Stock} left!");
            }
            
        }
    }
} 