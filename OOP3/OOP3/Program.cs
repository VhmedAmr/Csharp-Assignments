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
}