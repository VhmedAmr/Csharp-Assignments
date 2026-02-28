namespace OOP3;

public sealed class VIPTicket : Ticket
{
    public bool LoungeAccess { get; set; }
    public decimal ServiceFee { get; set; } = 50;
    
    public VIPTicket(string movieName, decimal price, bool loungeAccess) : base(movieName, price)
    {
        LoungeAccess = loungeAccess;
        
    }
    public override string ToString()
    {
        return base.ToString() + $" | LoungeAccess: {LoungeAccess} | ServiceFee: {ServiceFee}";
    }
}