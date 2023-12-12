namespace UselessChat;
internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {

            Console.WriteLine("Bitte Nachricht eingeben.");
            Random r = new Random();
            string text = Console.ReadLine();
            DisplayMessage(text, r.NextDouble());
            Console.WriteLine();
            Console.ReadKey(true);

        }
    }


    public static void DisplayMessage(string msg, double percentage)
    {


        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        int removedChars = (int)Math.Floor(msg.Length * percentage);

        Random r = new Random();

        foreach (char c in msg)
        {
            if (r.Next(0, 100) <= 30 && removedChars > 0)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                removedChars--;
            }
            Console.Write(c);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }

}

