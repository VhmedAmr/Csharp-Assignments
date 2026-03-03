namespace OOP4;

class Program
{
    public static void ProcessTicket(Ticket ticket)
    {
        Console.WriteLine("==== Process Single Ticket ====");
        ticket.PrintTicket();
    }
    
    static void Main(string[] args)
    {
        // Part one questions are answered down there
        // Part two questions are answered in the whole project
        
        Cinema cinema = new Cinema("Cinema Amir");
        cinema.OpenCinema();

        Ticket ticket1 = new StandardTicket("Inception", 120m, "2B");
        Ticket ticket2 = new VIPTicket("HarryPotter", 200m, true);
        Ticket ticket3 = new IMAXTicket("Batman", 300m, true);
        
        Console.WriteLine("==== SetPrice Test ====");
        ticket1.SetPrice(200m);
        ticket1.SetPrice(100m, 5m);
        
        cinema.AddTicket(ticket1);
        cinema.AddTicket(ticket2);
        cinema.AddTicket(ticket3);
        
        cinema.PrintAllTickets();
        
        ProcessTicket(ticket2);
        
        

        cinema.CloseCinema();
    }

    #region Part1

    #region Q1

    //Static : Happens at compile time in method overloading
    //Dynamic : Happens at runtime in method overriding

    #endregion
    
    #region Q2
    
    // Method overloading is changing parameters or types or count of the parameters with the same method name inside same class
    // Method overriding is inheriting the method into a child that overrides the whole data of the method with the same name and same parameters
    
    #endregion
    
    #region Q3
    
    // Virtual : it tells the compiler that the child can be able to change the content of the method
    // override : it tells the compiler that the child content replaces the base content
    // new : hides the base class method
    
    #endregion
    
    #endregion
}