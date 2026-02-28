namespace OOP3;

public class Cinema
{
    public string cinemaName { get; set; }
    private Ticket[] _tickets = new Ticket[20];
    private Projector _projector;

    public Ticket? this[int index]
    {
        get
        {
            if (index >= _tickets.Length || index < 0)
            {
                return null;
            }
            return _tickets[index];
        }
        set
        {
            if (index >= _tickets.Length || index < 0)
            {
                return;
            }
            _tickets[index] = value;
        }
    }

    public Cinema(string name)
    {
        cinemaName = name;
        _projector = new Projector();
    }
    
    public bool AddTicket(Ticket ticket)
    {
        for (int i = 0; i < _tickets.Length; i++)
        {
            if (_tickets[i] == null)
            {
                _tickets[i] = ticket;
                return true;
            }
        }
        return false;
    }

    public void PrintAllTickets()
    {
        Console.WriteLine("==== All Tickets: ====");
        foreach (var ticket in _tickets)
        {
            if (ticket != null)
            {
                Console.WriteLine(ticket); 
            }
        }
        
    }

    public void OpenCinema()
    {
        Console.WriteLine("==== Cinema Opened ====");
        _projector.ProjectorStart();
    }
    public void CloseCinema()
    {
        Console.WriteLine("==== Cinema Closed ====");
        _projector.ProjectorStop();
    }

}