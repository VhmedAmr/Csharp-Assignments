namespace OOP4;

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
    public override void PrintTicket()
    {
        base.PrintTicket();
        Console.WriteLine($" SeatNumber : {SeatNumber}");
    }
}