namespace OOP3;

public class Cinema
{
    private Ticket[] _tickets = new Ticket[20];

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

    public Ticket? GetTicketMovieName(string movieName)
    {
        foreach (var ticket in _tickets)
        {
            if (ticket != null && movieName == ticket.MovieName)
            {
                return ticket;
            }
        }
        return null;
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

}