namespace OOP3;

public sealed class IMAXTicket : Ticket
{
    public bool Is3D { get; set; }
    
    public IMAXTicket(string movieName, decimal price, bool is3D) : base(movieName, price)
    {
        Is3D = is3D;
        if (Is3D)
        {
            base.Price = price + 30;
        }
    }
    public override string ToString()
    {
        return base.ToString() + $" | 3D Availability: {Is3D}";
    }
}