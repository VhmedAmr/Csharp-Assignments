namespace Advanced3;

public class Exercise3
{
    Dictionary<string, string> Contacts = new Dictionary<string, string>
    {
        {"Ahmed","01200162559"},
        {"Ali","01234567891"},
        {"Samir","01234567892"},
        {"Saeed","01234567893"}
    };

    public void Ex3()
    {
        Contacts["Omar"] = "01234567899";
        try
        {
            Contacts.Add("Ahmed", "01200162559");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        bool tryAdd = Contacts.TryAdd("Omar", "01200000000");
        Console.WriteLine($"Is TryAdd Worked : {tryAdd}");
        
        bool trySearch = Contacts.ContainsKey("Mohamed");
        Console.WriteLine($"Is Search Worked : {trySearch}");

        if (trySearch)
        {
            Console.WriteLine("Is Search Worked Successfully");
        }
        else
        {
            Console.WriteLine("Fallback : Not Found");
        }
        
        Console.WriteLine($"Keys : {String.Join(",", Contacts.Keys)}");
        Console.WriteLine($"Values : {String.Join(",", Contacts.Values)}");
    }
}