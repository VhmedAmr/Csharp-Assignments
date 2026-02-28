namespace OOP3;

class Program
{
    static void Main(string[] args)
    {
        // Part one questions are answered down there
        // Part two questions are answered in the whole project
        
        Cinema cinema = new Cinema("Cinema Amir");
        cinema.OpenCinema();

        Ticket ticket1 = new StandardTicket("Inception", 120m, "2B");
        cinema.AddTicket(ticket1);
        Ticket ticket2 = new VIPTicket("HarryPotter", 200m, true);
        cinema.AddTicket(ticket2);
        Ticket ticket3 = new IMAXTicket("Batman", 300m, true);
        cinema.AddTicket(ticket3);
        
        cinema.PrintAllTickets();
        
        Console.WriteLine("\n");
        Console.WriteLine("====Statistics====");
        Console.Write($"Total Tickets Sold: {Ticket.GetTotalTicketsSold()}");

        Console.WriteLine("\n");
        Console.WriteLine($"{BookingHelper.GenerateBookingReference()}");
        Console.WriteLine($"{BookingHelper.GenerateBookingReference()}");

        Console.WriteLine("\n");
        double groupDiscount = BookingHelper.CalcGroupDiscount(5, 80);
        Console.WriteLine($"Group Discount (5 tickets * 80 EGP): {groupDiscount}");

        cinema.CloseCinema();
    }

    #region Part1

    #region Q1

        // A) composition
        // B) Association
        // C) Inheritance
        // D) Aggregation
        // E) Dependency

    #endregion
    
    #region Q2
    
     // A) yes it can be accessed out from the assembly, no it needs to be inherited.
     // B) Protected internal without inheritance can be accessed inside the assembly only
     //                       With inheritance can be accessed normally in a derived class in another assembly
     //    Private protected without inheritance can be accessed inside same class only
     //                      With inheritance inside the same class or derived class in the same assembly
     // C) Makes the class cant be inherited, makes the method cant be overridden
     // D) Yes, sealed affect only the inheritance not the object intialization.
    
    #endregion

    #endregion
    
    
}