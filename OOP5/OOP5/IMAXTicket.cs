namespace OOP5;

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
    public override void Print()
    {
        string _3D;
        if (Is3D)
        {
            _3D = "Yes";
        }
        else
        {
            _3D = "No";
        }
        base.Print();
        Console.WriteLine($" | IMAX 3D : {_3D}");
    }
}