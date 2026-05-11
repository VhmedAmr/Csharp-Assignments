namespace Advanced3;

public class Exercise5
{
    Queue<string> printQueue = new Queue<string>();
    
    public void Ex5()
    {
        
        printQueue.Enqueue("Report.pdf");
        printQueue.Enqueue("Invoice.pdf");
        printQueue.Enqueue("Letter.docx");
        printQueue.Enqueue("Resume.pdf");
        printQueue.Enqueue("Photo.jpg");
        
        Console.WriteLine($"Items in Queue: {printQueue.Count}");
        Console.WriteLine($"Current Queue: {string.Join(",", printQueue)}");
        
 
        string nextUp = printQueue.Peek();
        Console.WriteLine($"[Peek] Up Next: {nextUp}");
        Console.WriteLine($"Queue size after Peek is still: {printQueue.Count}");


        Console.WriteLine("--- Processing Queue ---");
        while (printQueue.Count > 0)
        {
            string document = printQueue.Dequeue();
            Console.WriteLine($"Printing: {document}");
        }
        
        Console.WriteLine("\n--- Testing Empty Queue ---");
        bool tryDequeue = printQueue.TryDequeue(out string missingDoc);
        
        Console.WriteLine($"tryDequeue. Success? {tryDequeue}");
        if (!tryDequeue)
        {
            Console.WriteLine("Error avoided The printer queue is completely empty!");
        }
    }
}