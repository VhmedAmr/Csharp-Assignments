namespace OOP6;

public partial class Cinema
{
    public void Print()
    {
        Console.WriteLine("==== All Tickets: from Cinema.Reporting ====");
        foreach (var ticket in _tickets)
        {
            if (ticket != null)
            {
                ticket.Print();
            }
        }
    }
    
}