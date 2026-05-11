namespace Advanced3;

public class Exercise6
{
    Stack<string> history = new Stack<string>();
    
    public void Ex6()
    {
        history.Push("google.com");
        history.Push("github.com");
        history.Push("stackoverflow.com");
        history.Push("youtube.com");
        history.Push("claude.ai");
        
        Console.WriteLine($"[Peek] Current Page: {history.Peek()}");
        
        for (int i = 0; i < 3; i++)
        {
            string leavingPage = history.Pop();
            Console.WriteLine($"Poped: {leavingPage}");
        }
        
        Console.WriteLine($"\n[Peek] Current Page: {history.Peek()}\n");
        
        history.Pop(); 
        history.Pop(); 
        
        Console.WriteLine("--- Testing Empty History ---");
        bool canGoBack = history.TryPop(out string previousPage);
        
        Console.WriteLine($"TryPop Success? {canGoBack}");
        if (!canGoBack)
        {
            Console.WriteLine("The 'Back' button is disabled. You are at the start of your session");
        }
    }
}