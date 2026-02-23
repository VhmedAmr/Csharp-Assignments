namespace OOP2;

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

            // A)
            //  First the balance field is public so anywhere in the program an one can edit on it
            //  Second the bank account shouldn't hold the balance - withdrawal functions 
            
            // B)
            //  We can fix it by creating a new class for balance, adding a property to appy getter and setter
            //  Options, making the fileds private so enhancing security and making sure that no where in the program
            //  will make an issue.
            
            // C)
            //  First : any change on the public field you will not be able to track where the variable has been over ridden
            //  Second : any one working on the same project can over ride the value of the field
            //  Third : you lost the encapsulation idea of making every field works only in its desired purpose

        #endregion
        
        #region Q2

        // 1) the field can only have a value , the property is how to get it or edit on it
        // 2) yes and its almost used in validation
        // 3) Ex :

        public int Width { get; set; }
        public int Height { get; set; }

        public int Area
        {
            get { return Width * Height; }
        }
        
        #endregion
        
        #region Q3

        // A) Indexer, its purpose is to give indexes to values like arrays
        // B) it will throw an out of range error, to make it safe you need to add validation code inside the get.
        // C) YES , that would be useful in some cases like players and teams, you may need to search with jersey 
        // Number or the player name, at both cases you want to find the player here two indexers will be useful
        
        #endregion

        #region Q4

        // A) this means that it doesn't need an object and its doesn't belong to any instance
        // B) No, because it will need an object of the item field and this is not possible in the static methods

        #endregion
    #endregion
}