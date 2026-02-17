namespace Assignment5;

public class Ticket
{
    //Fields
    public string MovieName;
    public TicketType Type;
    public SeatLocation Seat;
    private double _Price;

    //Constructors
    public Ticket(string movieName, TicketType type, SeatLocation seat, double price)
    {
        MovieName = movieName;
        Type = type;
        Seat = seat;
        _Price = price;

    }

    public Ticket(string movieName) : this(movieName, TicketType.Standard, new SeatLocation{SeatRow = 'A', SeatNumber = 1}, 50)
    {

    }

    
    //Methods
    public double CalcTotal(double taxPercent)
    {
        return _Price + (_Price * (taxPercent / 100));
    }

    public double ApplyDiscount(double discountAmount)
    {
        if (discountAmount > 0 && discountAmount <= _Price)
        {
            _Price = _Price - discountAmount;
            discountAmount = 0;
            return discountAmount;
        }
        else
        {
            return 0;
        }
    }

    public void PrintTicket(double taxPercent, double discountAmount)
    {
        Console.WriteLine("====Ticket Details====");
        Console.WriteLine($"Movie Name : {MovieName}");
        Console.WriteLine($"TicketType : {Type}");
        Console.WriteLine($"Seat : {Seat.SeatRow}{Seat.SeatNumber}");
        Console.WriteLine($"Price : {_Price}");
        double tax = CalcTotal(taxPercent);
        Console.WriteLine($"Total ({taxPercent}% Tax) : {tax}");
        
        Console.WriteLine("====After Discount====");
        Console.WriteLine($"Discount Amount Before: {discountAmount}");
        double discount = ApplyDiscount(discountAmount);
        Console.WriteLine($"Discount Amount After: {discount}");
        Console.WriteLine($"Movie Name : {MovieName}");
        Console.WriteLine($"TicketType : {Type}");
        Console.WriteLine($"Seat : {Seat.SeatRow}{Seat.SeatNumber}");
        Console.WriteLine($"Price : {(_Price -  discount)}");
        

        double newTotal = CalcTotal(taxPercent);
        Console.WriteLine($"Total ({taxPercent}% Tax) : {newTotal}");
    }
}