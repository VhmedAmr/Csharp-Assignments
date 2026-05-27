namespace LINQ1;

public class Customer
{
    public string CustomerId { get; set; }
    public List<Order> Orders { get; set; }
    
    public static List<Customer> GetCustomers()
    {
        return new List<Customer>
        {
            new Customer
            {
                CustomerId = "ALFKI",
                Orders = new List<Order>
                {
                    new Order { OrderId = 1001, OrderDate = new DateTime(1996, 8, 15) }, 
                    new Order { OrderId = 1002, OrderDate = new DateTime(1997, 10, 3) }  
                }
            },
            new Customer
            {
                CustomerId = "ANATR",
                Orders = new List<Order>
                {
                    new Order { OrderId = 1003, OrderDate = new DateTime(1998, 3, 4) },  
                    new Order { OrderId = 1004, OrderDate = new DateTime(1996, 12, 12) } 
                }
            },
            new Customer
            {
                CustomerId = "OCEAN",
                Orders = new List<Order>
                {
                    new Order { OrderId = 1005, OrderDate = new DateTime(1997, 1, 1) },  
                    new Order { OrderId = 1006, OrderDate = new DateTime(1999, 5, 20) }  
                }
            }
        };
    }
}