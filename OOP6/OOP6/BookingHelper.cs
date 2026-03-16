namespace OOP6;

public static class BookingHelper
{
    
    private static int _bookingCounter = 0;
    
    public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
    {
        if (numberOfTickets >= 5)
        {
            return (numberOfTickets * pricePerTicket) - ((numberOfTickets * pricePerTicket) * 0.10);
        }
        else
        {
            return (numberOfTickets * pricePerTicket);
        }
    }

    public static string GenerateBookingReference()
    {
        _bookingCounter++;
        return $"BK-{_bookingCounter}";
    }

    public static void PrintAllItems(IPrintable[] items)
    {
        foreach (var item in items)
        {
            item.Print();
        }
    }
}