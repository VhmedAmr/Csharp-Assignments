namespace OOP3;

public class Ticket
{
    //Fields
    private string _movieName;
    private decimal _price;
    private static int _ticketCounter = 0;
    
    
    //Properties
    public string MovieName
    {
        get
        {
            return _movieName;
        }
        
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                Console.WriteLine("Movie Name is required");
                return ;
            }
            _movieName = value;
        }
    }
    
    
    public decimal Price
    {
        get
        {
            return _price;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Price must be greater than zero");
                return;
            }
            _price = value;
        }
    }

    public decimal PriceAfterTax
    {
        get
        {
            return Price + (Price * 0.14m);
        }
    }

    public int TicketId { get; private set; }

    //Constructors
    public Ticket(string movieName, decimal price)
    {
        MovieName = movieName;
        Price = price;
        decimal afterTax = PriceAfterTax;
        _ticketCounter++;
        TicketId = _ticketCounter;

    }

    //public Ticket(string movieName) : this(movieName, TicketType.Standard, new SeatLocation{SeatRow = 'A', SeatNumber = 1}, 50)
    //{
    //
    //}

    
    //Methods


    public override string ToString()
    {
       return $"Ticket {TicketId} | {MovieName} | Price: {Price} | After Tax: {PriceAfterTax}";
    }
    

    public static int GetTotalTicketsSold()
    {
        return _ticketCounter;
    }
}