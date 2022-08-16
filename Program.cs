using System;
using System.Timers;

class Program
{
    private static System.Timers.Timer blinkTimer;
    private static Screen screen;

    static private void SetTimer()
    {
        // Create a timer with a two second interval.
        blinkTimer = new System.Timers.Timer(300);
        // Hook up the Elapsed event for the timer. 
        blinkTimer.Elapsed += BlinkEvent;
        blinkTimer.AutoReset = true;
        blinkTimer.Enabled = true;
    }
    static private void BlinkEvent(Object source, ElapsedEventArgs e)
    {
        
        screen.toggleBlink();
    }

    static void Main(string[] args)
    {
        bool gameOver = false;
        screen = new Screen();
        screen.Clear();
        SetTimer();
        var watch = System.Diagnostics.Stopwatch.StartNew();
        SetTimer();

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