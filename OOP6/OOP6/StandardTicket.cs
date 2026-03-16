namespace OOP6;

public sealed class StandardTicket : Ticket
{

    public string SeatNumber { get; set; }
    
    public StandardTicket(string movieName, decimal price, string seatNumber) : base(movieName, price)
    {
        SeatNumber = seatNumber;
    }
    public override string ToString()
    {
        return base.ToString() + $" | SeatNumber: {SeatNumber}";
    }
    public override void Print()
    {
        base.Print();
        Console.WriteLine($" SeatNumber : {SeatNumber}");
    }

    public override decimal SetPrice(decimal price)
    {
        Price = price;
        return price;
    }
}