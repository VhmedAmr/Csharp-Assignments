namespace OOP4;

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
       return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
    }
    

    public static int GetTotalTickets()
    {
        return _ticketCounter;
    }

    public virtual void PrintTicket()
    {
        Console.Write($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
    }

    public void SetPrice(decimal price)
    {
        Price = price;
        Console.WriteLine($"Setting price directly to : {price}");
    }
    
    public void SetPrice(decimal basePrice, decimal multiplierPrice)
    {
        Price  = basePrice * multiplierPrice;
        Console.WriteLine($"Setting price with multiplier : {basePrice} * {multiplierPrice} = {Price}");
    }
    
}