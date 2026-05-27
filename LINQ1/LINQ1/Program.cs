namespace LINQ1;

class Program
{
    static void Main(string[] args)
    {
        var Seafood = new List<Product>
        {
            new Product() { Name = "Salmon Fillet", Price = 15.99, Category = "Seafood", UnitsInStock = 10 },
            new Product { Name = "Whole Wheat Bread", Price = 3.49, Category = "Bakery", UnitsInStock = 17 },
            new Product { Name = "Jumbo Shrimp", Price = 22.50, Category = "Seafood", UnitsInStock = 6 },
            new Product { Name = "Ribeye Steak", Price = 28.99, Category = "Meat", UnitsInStock = 34 },
            new Product { Name = "Canned Tuna", Price = 2.99, Category = "Seafood", UnitsInStock = 0 },
            new Product { Name = "Gala Apples", Price = 4.50, Category = "Produce", UnitsInStock = 20 },
            new Product { Name = "Yellow Mustard", Price = 1.89, Category = "Condiments", UnitsInStock = 10 },
            new Product { Name = "Hot Sauce", Price = 3.75, Category = "Condiments", UnitsInStock = 0 },
            new Product { Name = "Green Tea", Price = 2.50, Category = "Beverages", UnitsInStock = 28 },
            new Product { Name = "Orange Juice", Price = 4.20, Category = "Beverages", UnitsInStock = 56 },
            new Product { Name = "Sparkling Water", Price = 1.50, Category = "Beverages", UnitsInStock = 5 },
            new Product { Name = "Whole Bean Coffee", Price = 12.00, Category = "Beverages", UnitsInStock = 0 }
        };

        var SeafoodItems = Seafood
            .Where(x => x.Category == "Seafood")
            .Select(x => new
            {
                ItemName = x.Name,
                Cost = x.Price,
            });

        //Q1
        foreach (var item in SeafoodItems)
        {
            Console.WriteLine($"Name: {item.ItemName} , Price {item.Cost}");
        }

        //Q2
        var objName = Seafood.Select(x => x.Name);
        Console.WriteLine(string.Join(",", objName));


        //Q3
        var sorted = Seafood
            .OrderBy(x => x.Price)
            .Select(x => new
                {
                    Name = x.Name,
                    Price = x.Price
                }
            );
        foreach (var item in sorted)
        {
            Console.WriteLine($"Name: {item.Name} , Price: {item.Price}");
        }

        //Q4
        var selectedPortion = Seafood
            .Where(x => x.Price > 10 && x.Price < 30)
            .Select(x => x.Name);
        Console.WriteLine(string.Join(",", selectedPortion));

        //Q5
        var inStock = Seafood.Where(x => x.UnitsInStock > 0 && x.Category == "Condiments");
        foreach (var item in inStock)
        {
            Console.WriteLine(
                $"Name: {item.Name} , Price {item.Price},  UnitsInStock {item.UnitsInStock}, Category {item.Category}");
        }

        //Q6
        var Anon = Seafood.Select(x => new
        {
            Name = x.Name,
            Price = x.Price,
            StockStatus = x.UnitsInStock > 0 ? "Available" : "OutOfStock"
        });
        foreach (var item in Anon)
        {
            Console.WriteLine($"Name: {item.Name} , Price: {item.Price}, StockStatus: {item.StockStatus}");
        }

        //Q7
        var NameAndPos = Seafood.Select((x, index) => new
        {
            Name = x.Name,
            Position = index + 1
        });

        foreach (var item in NameAndPos)
        {
            Console.WriteLine($"{item.Position}. {item.Name}");
        }

        //Q8
        var sort2 = Seafood.OrderBy(x => x.Category).ThenByDescending(x => x.Price);
        foreach (var item in sort2)
        {
            Console.WriteLine($"Name : {item.Name}, Category:{item.Category}, Price:{item.Price}");
        }

        //Q9
        var sort3 = Seafood
            .Where(x => x.Category == "Beverages")
            .OrderByDescending(x => x.UnitsInStock)
            .Select(x => new
            {
                Name = x.Name,
                Stock = x.UnitsInStock
            });

        foreach (var item in sort3)
        {
            Console.WriteLine($"Name : {item.Name}, Stock:{item.Stock}");
        }
        
        //Q10
        var customers = Customer.GetCustomers();
        var query = from c in customers
            from o in c.Orders
            where o.OrderDate.Year > 1997
            select new
            {
                CustomerId = c.CustomerId,
                OrderDate = o.OrderDate
            };
        foreach (var item in query)
        {
            Console.WriteLine($"CustomerID : {item.CustomerId}, OrderDate : {item.OrderDate}");
        }
        
        //Q11
        var Position = Seafood.Select((x, index) => new
        {
            Name = x.Name,
            Position = index + 1
        });

        foreach (var item in Position)
        {
            Console.WriteLine($"{item.Position}. {item.Name}");
        }

        //Q12
        String [] Arr = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
        var sort4 = Arr
            .OrderBy(x => x.Length)
            .ThenBy(x => x, StringComparer.OrdinalIgnoreCase);
        foreach (var item in sort4)
        {
            Console.WriteLine($"ArrayItem : {item}");
        }
        
        //Q13
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        var list = digits.Where(x => x[1] == 'i').Reverse().ToList();
        foreach (var item in list)
        {
            Console.WriteLine($"ReversedList Item : {item}");
        }
    }
}