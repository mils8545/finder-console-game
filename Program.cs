class Program
{
    static void Main(string[] args)
    {
        bool gameOver = false;
        Screen screen = new Screen();
        screen.Clear();
        var watch = System.Diagnostics.Stopwatch.StartNew();

        while (!gameOver)
        {

        	if (Console.KeyAvailable)
        	{
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        screen.yCursor--;
                        break;
                    case ConsoleKey.DownArrow:
                        screen.yCursor++;
                        break;
                    case ConsoleKey.LeftArrow:
                        screen.xCursor--;
                        break;
                    case ConsoleKey.RightArrow:
                        screen.xCursor++;
                        break;
                    case ConsoleKey.Escape:
                        gameOver = true;
                        break;
                }
            }
            screen.Draw();
        }
        Console.CursorVisible = true;
        Console.WriteLine("Hello World!");
    }
}