namespace OOP6;

public static class TicketExtension
{
    public static void Receipt(this Ticket ticket)
    {
        Console.WriteLine("==== Receipt ====");
        Console.WriteLine($"Movie : {ticket.MovieName}");
        Console.WriteLine($"Type : {ticket.GetType().Name}");
        Console.WriteLine($"Price : {ticket.Price}");
        Console.WriteLine($"Final : {ticket.SetPrice(ticket.Price)}");
        Console.WriteLine($"Status : {ticket.Booking()}");
        Console.WriteLine("=================");
        
    }

    public static void TotalRevenue(this Ticket[] tickets)
    {
        decimal totalRevenue = 0;
        if (tickets != null)
        {
            foreach (var ticket in tickets)
            {
                totalRevenue += ticket.PriceAfterTax;
            }
        }
        Console.WriteLine($"Total Revenue : {totalRevenue}");
    }
}