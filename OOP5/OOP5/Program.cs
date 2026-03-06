namespace OOP5;

class Program
{
    public static void ProcessTicket(Ticket ticket)
    {
        Console.WriteLine("==== Process Single Ticket ====");
        ticket.Print();
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
        ticket1.Book();
        ticket2.Book();
        ticket3.Book();
        
        cinema.AddTicket(ticket1);
        cinema.AddTicket(ticket2);
        cinema.AddTicket(ticket3);

        cinema.Print();
        
        Console.WriteLine("==== Clone Test ====");
        Ticket ticket4 = (Ticket)ticket2.Clone();
        ticket4.MovieName = "Dune";
        Console.Write("Original : ");
        ticket1.Print();
        Console.Write("Cloned : ");
        ticket4.Print();
        
        Console.WriteLine("==== After Cancellation ====");
        ticket1.Cancel();
        ticket1.Print();
        
        Console.WriteLine("==== BookingHelper PrintAll ====");
        BookingHelper.PrintAllItems(new IPrintable[] {cinema});
        

        cinema.CloseCinema();
    }

    #region Part1

    #region Q1

    // Interface is a contract with methods or properties to all classes that will implement it,
    // to achieve loosecoupling not like classes you need to inherit it.
    // 1- abstraction , 2- Easy testing, 3- Multiple interfaces can be implemented.

    #endregion

    #region Q2

    // a) the problem is that you made a multiple interface into one class with the same name of the method,
    //    which will cause the compiler to not know which one of them you want to implement so it will send the
    //    Method data into both methods, and this is will cause logical error for you.
    // b) to fix this you need to call and implement each method with its interface name like : IEnglishSpeaker.Greet()
    //    its called explicit implementation
    // c) No you can't, because each method now have its implementation which you need to specify which one
    //    of them you want to run because it now doesn't belong to the class it belongs to the interface,
    //    you can call it with the name of the interface before the name of the method with cast.
    

    #endregion
    
    #region Q3

    // Shallow copy : creates a new object and copies all the value types like int, but copies the references
    //                of reference types (same addresses).
    // Deep copy : creates a new object and copies all the value types, and copies all the data of the reference
    //             types but puts them inside another addresses.
    // use shallow copy to copy only value types it will be safe, and use deep copy when your class have reference
    //   types data which you need to copy
    // the risk of shallow copy is when you use it with reference types it will point to the same old address, any
    //   change on the new data will replace the old data too
    
    #endregion
    
    #region Q4

    // e1 title will be "Dev", Name will be "Testing"
    // e2 title will be "QA", Name will be "Testing"
    //because string type is immutable, not like normal object from normal class.
    #endregion
    
    #endregion
}