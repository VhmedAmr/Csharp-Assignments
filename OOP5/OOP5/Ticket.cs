namespace OOP5;

public class Ticket : IPrintable,IBookable,ICloneable
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

    public bool IsBooked { get; private set; }

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

    public object Clone()
    {
        // i used MemberwiseClone because here it will act exactly like deep copy.
        Ticket cloned = (Ticket)this.MemberwiseClone();
        cloned.IsBooked = false;
        _ticketCounter++;
        cloned.TicketId = _ticketCounter;
        return cloned;
    }

    public string Booking()
    {
        if (IsBooked)
        {
            return "Yes";
        }
        else
        {
            return "No";
        }
    }
    public virtual void Print()
    {
        
        Console.Write($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP | Booked: {Booking()}");
    }


    public static int GetTotalTickets()
    {
        return _ticketCounter;
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

    public void Book()
    {
        if (IsBooked)
        {
            Console.WriteLine("Already Booked");
        }
        else
        {
            IsBooked =  true;
        }
    }

    public void Cancel()
    {
        if (!IsBooked)
        {
            Console.WriteLine("Its not Booked");
        }
        else
        {
            IsBooked =  false;
        }
    }
}