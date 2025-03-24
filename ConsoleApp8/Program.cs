namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Document> printQueue = new Queue<Document>();  
            Stack<Document> printHistory = new Stack<Document>(); 

            while (true)
            {
                Console.WriteLine("Commanda: ");
                string command = Console.ReadLine();
                string[] parts = command.Split(' ');

                switch (parts[0].ToLower())
                {
                    case "add":
                        if (parts.Length == 3 && int.TryParse(parts[2], out int pages))
                        {
                            Document document = new Document(parts[1], pages);
                            printQueue.Enqueue(document);  
                            Console.WriteLine($"Dobaven dokument: {document}");
                        }
                        else
                        {
                            Console.WriteLine("Nevalidno vuvejdane na komanda. Izpolzvaite shablona add <title> <pages>");
                        }
                        break;

                    case "print":
                        if (printQueue.Count > 0)
                        {
                            Document document = printQueue.Dequeue();  
                            printHistory.Push(document);  
                            Console.WriteLine($"Printiran dokument: {document}");
                        }
                        else
                        {
                            Console.WriteLine("Nqma dokumenti za printirane.");
                        }
                        break;

                    case "history":
                        if (printHistory.Count > 0)
                        {
                            Console.WriteLine("Poslednite 3 printirai dokumenta:");
                            int count = 0;
                            foreach (var doc in printHistory)
                            {
                                Console.WriteLine(doc);
                                count++;
                                if (count == 3) break;  
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nqma printirani dokumenti.");
                        }
                        break;

                    case "exit":
                        Console.WriteLine("CHAO!"); 
                        return;

                    default:
                        Console.WriteLine("Nevalidna komanda.");
                        break;
                }
            }
        }
    }
}
