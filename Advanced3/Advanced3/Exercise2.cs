namespace Advanced3;

public class Exercise2
{
    SortedList<int, string> leaderboard = new SortedList<int, string>();

    public void Ex2()
    {
        leaderboard.Add(500, "Ahmed");
        leaderboard.Add(200, "Sara");
        leaderboard.Add(800, "Ali");
        leaderboard.Add(350, "Mona");
        Console.WriteLine(String.Join(", ", leaderboard));
        Console.WriteLine($"First Key : {leaderboard.Keys[0]}");
        Console.WriteLine($"First Value : {leaderboard.Values[0]}");
        Console.WriteLine($"500 exists? {leaderboard.ContainsKey(500)}");
        if (leaderboard.TryGetValue(999, out string value))
        {
            Console.WriteLine($"Found Player : {value}");
        }
        else
        {
            Console.WriteLine($"No Player Found");
        }
        leaderboard.Remove(200);
        Console.WriteLine(String.Join(", ", leaderboard));
    }
}