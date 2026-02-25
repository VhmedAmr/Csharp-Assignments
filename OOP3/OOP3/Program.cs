namespace OOP3;

class Program
{
    static void Main(string[] args)
    {
        // Part one questions are answered down there
        // Part two questions are answered in the whole project
        string mName;
        string tType;
        char sRow;
        int sNum;
        double tPrice;
        string searchName;
        int numberOfTickets;
        Ticket[] ticket = new Ticket[3];
        Cinema Cinema = new Cinema();
        Console.WriteLine("====Ticket Booking====");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter data for the ticket{i}:");
            Console.Write("Enter Movie Name: ");
            mName = Console.ReadLine();
            Console.Write("Enter Ticket Type: ");
            tType = Console.ReadLine();
            Console.Write("Choose Seat-Row (A,B,C,D,...): ");
            sRow = char.Parse(Console.ReadLine());
            Console.Write("Choose Seat-Number (1,2,3,4,...): ");
            sNum = int.Parse(Console.ReadLine());
            Console.Write("Enter Price: ");
            tPrice = double.Parse(Console.ReadLine());
            ticket[i] = new(mName,
                (TicketType)Enum.Parse(typeof(TicketType), tType),
                new SeatLocation{SeatRow =  sRow,SeatNumber = sNum},
                tPrice);
            
            Cinema.AddTicket(ticket[i]);
        }
        
        Console.WriteLine("\n");
        
        Console.WriteLine("====All Tickets====");
        for (int i = 0; i < 3; i++)
        {
            Cinema[i].PrintTicket();
        }
        
        Console.WriteLine("\n");
        Console.WriteLine("====Search By Movie====");
        Console.Write("Enter Movie name to search:");
        searchName = Console.ReadLine();
        Ticket searchedTicket = Cinema.GetTicketMovieName(searchName);
        if (searchedTicket == null)
        {
            Console.WriteLine("Ticket Not Found");
        }
        else
        {
            Console.WriteLine($"Found :");
            searchedTicket.PrintTicket();
        }
        
        
        Console.WriteLine("\n");
        Console.WriteLine("====Statistics====");
        Console.Write($"Total Tickets Sold: {Ticket.GetTotalTicketsSold()}");
        
        Console.WriteLine("\n");
        Console.WriteLine($"{BookingHelper.GenerateBookingReference()}");
        Console.WriteLine($"{BookingHelper.GenerateBookingReference()}");
        
        Console.WriteLine("\n");
        double groupDiscount = BookingHelper.CalcGroupDiscount(5, 80);
        Console.WriteLine($"Group Discount (5 tickets * 80 EGP): {groupDiscount}");

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