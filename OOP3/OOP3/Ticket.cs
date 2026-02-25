namespace OOP3;

public class Ticket
{
    //Fields
    private string _movieName;
    //private TicketType _type;    // no need for them i have assigned them as props
    //private SeatLocation _seat;
    private double _price;
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

    public TicketType Type { get; set; }

    public SeatLocation Seat { get; set; }
    
    public double Price
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

    public double PriceAfterTax
    {
        get
        {
            return Price + (Price * 0.14);
        }
    }

    public int TicketId { get; private set; }

    //Constructors
    public Ticket(string movieName, TicketType type, SeatLocation seat, double price)
    {
        MovieName = movieName;
        Type = type;
        Seat = seat;
        Price = price;
        _ticketCounter++;
        TicketId = _ticketCounter;

    }

    public Ticket(string movieName) : this(movieName, TicketType.Standard, new SeatLocation{SeatRow = 'A', SeatNumber = 1}, 50)
    {

    }

    
    //Methods
    //public double CalcTotal(double taxPercent)
    //{
    //    return _price + (_price * (taxPercent / 100));
    //}

    public double ApplyDiscount(double discountAmount)
    {
        if (discountAmount > 0 && discountAmount <= Price)
        {
            Price = Price - discountAmount;
            discountAmount = 0;
            return discountAmount;
        }
        else
        {
            return 0;
        }
    }

    public void PrintTicket()
    {
        Console.WriteLine($"Ticket {TicketId} | {MovieName} | {Type} | Seat: {Seat.SeatRow}{Seat.SeatNumber} | Price: {Price} | After Tax: {PriceAfterTax}");
    }

    public static int GetTotalTicketsSold()
    {
        return _ticketCounter;
    }
}