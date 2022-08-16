class Screen 
{
    public int xCursor = 0;
    public int yCursor = 0;
    public int width = 10;
    public int height = 10;
    public char[,] screen = new char[20, 20];
    public bool blink = false;
    public void toggleBlink()
    {
        blink = !blink;
    }
    public void Clear()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                screen[i, j] = '.';
            }
        }
        Console.Clear();
    }
    public void Draw()
    {
        Console.SetCursorPosition(0,0);
        Console.CursorVisible = false;
        xCursor = Math.Clamp(xCursor, 0, width - 1);
        yCursor = Math.Clamp(yCursor, 0, height - 1);
        for (int i = 0; i < width; i++)
        {
            string lineString = "";
            for (int j = 0; j < height; j++)
            {
                if ((i == yCursor && j == xCursor) && blink)
                {
                    lineString += "X" + " ";
                }
                else
                {
                    lineString += screen[i, j] + " ";
                }
            }

            Console.WriteLine(lineString);
        }
    }
}