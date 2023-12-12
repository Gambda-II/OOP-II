namespace Minesweeper;

internal class Program
{
    private static int posX, posY;

    #region Properties
    public static int Width { get; set; } = 8;
    public static int Height { get; set; } = 6;

    public static int Difficulty { get; set; } = 20;

    public static int PosX
    {
        get
        {
            return posX;
        }
        set
        {
            if (value < 0)
            {
                posX = 0;
                return;
            };

            if (value >= Width)
            {
                posX = Width - 1;
                return;
            }

            posX = value;
        }
    }

    public static int PosY
    {
        get
        {
            return posY;
        }
        set
        {
            if (value < 0)
            {
                posY = 0;
                return;
            };

            if (value >= Height)
            {
                posY = Height - 1;
                return;
            }

            posY = value;
        }
    }

    public static int[,] GameGrid { get; set; } = new int[Width, Height];
    public static int[,] GameGridValues { get; set; } = new int[Width, Height];
    #endregion

    static void Main()
    {
        

        Menue();
        int[] emptyArray = new int[0];
        CreateGrid(emptyArray);
        UpdateValues();

        PosX = Width / 2;
        PosY = Height / 2;

        Console.SetCursorPosition(PosX, PosY);

        while (true)
            GetInput();
    }

    private static void Menue()
    {
        Console.WriteLine("Bitte eine Schwierigkeit auswählen.\n");
        Console.WriteLine("1: Leicht (48 Felder, 12 Minen)");
        Console.WriteLine("2: Mittel (70 Felder, 21 Minen)");
        Console.WriteLine("3: Schwer (120 Felder, 45 Minen)");
        Console.WriteLine("4: Benutzerdefiniert ");
        GetDifficulty();
    }

    private static void GetDifficulty()
    {
        char key = Console.ReadKey().KeyChar;

        switch (key)
        {
            case '1':
                Width = 8;
                Height = 6;
                Difficulty = 12;
                break;

            case '2':
                Width = 10;
                Height = 7;
                Difficulty = 25;
                break;

            case '3':
                Width = 12;
                Height = 10;
                Difficulty = 45;
                break;
            case '4':
                Width = SetWidth();
                Height = SetHeight();
                Difficulty = SetDifficulty();
                break;

            default:
                Console.Clear();
                Menue();
                break;
        }
        GameGrid = new int[Width, Height];
        GameGridValues = new int[Width, Height];
        Console.Clear();
    }

    private static int SetDifficulty()
    {
        int mines = 1;
        Console.Clear();
        Console.WriteLine($"Anzazhl der Minen eingeben. Muss zwischen 0 und {Width * Height} liegen!");
        while (!int.TryParse(Console.ReadLine(), out mines) || mines >= Width * Height || mines < 1)
        {
            Console.WriteLine("Bitte Eingabe wiederholen.");
        }
        return mines;
    }

    private static int SetHeight()
    {
        int ht = 1;
        Console.Clear();
        Console.WriteLine($"Spielfeldhöhe eingeben.");
        while (!int.TryParse(Console.ReadLine(), out ht) || ht < 2)
        {
            Console.WriteLine("Bitte Eingabe wiederholen.");
        }
        return ht;
    }

    private static int SetWidth()
    {
        int wd = 1;
        Console.Clear();
        Console.WriteLine($"Spielfeldbreite eingeben.");
        while (!int.TryParse(Console.ReadLine(), out wd) || wd < 2)
        {
            Console.WriteLine("Bitte Eingabe wiederholen.");
        }
        return wd;
    }

    public static void CreateGrid(int[] failedArray)
    {
        int[] array;
        if (failedArray.Length < 1)
            array = RandomArray();
        else
        {
            array = failedArray;
        }

        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                GameGrid[x, y] = RandomizeGrid(x, y, array);
                Console.Write("?");

            }
            Console.WriteLine();
        }
    }

    private static int RandomizeGrid(int x, int y, int[] array)
    {
        int index = x + y * (Width);
        return array[index];
    }

    private static int[] RandomArray()
    {
        int counter = Difficulty;
        int[] tmpArray = new int[Width * Height];

        while (counter > 0)
        {
            int r = new Random().Next(0, tmpArray.Length);
            if (tmpArray[r] == 0)
            {
                tmpArray[r] = 1;
                counter--;
            }
        }
        return tmpArray;
    }

    private static void UpdateValues()
    {

        for (int j = 0; j < Height; j++)
        {
            for (int i = 0; i < Width; i++)
            {
                //GameGridValues[i, j] = 
                LoopAroundInit(i, j);
                //Console.Write(GameGridValues[i, j] == 9? "X" : GameGridValues[i, j]);
            }
            Console.WriteLine();
        }
    }

    private static void LoopAroundInit(int i, int j)
    {


        int sum = 0;
        int counter = 0;

        if (GameGrid[i, j] == 1)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            GameGridValues[i, j] = 9;
            Console.BackgroundColor = ConsoleColor.Black;
            return;
        }

        for (int y = j - 1; y <= j + 1; y++)
        {
            for (int x = i - 1; x <= i + 1; x++)
            {
                if (x >= 0 && x < Width && y >= 0 && y < Height)
                {
                    bool hasBomb = GameGrid[x, y] == 1;

                    //if (hasBomb && x != i && y != j)
                    if (hasBomb)
                    {

                        sum++;
                    }
                    counter++;
                }
            }
        }
        GameGridValues[i, j] = sum;
    }


    public static void GetInput()
    {
        //Console.SetCursorPosition(0, Height + 2);
        ConsoleKey pressedKey = Console.ReadKey(true).Key;
        bool finished = false;
        switch (((int)pressedKey))
        {
            case (int)KeyPresses.Quit:
                break;

            case (int)KeyPresses.Space:
                int fieldValue = GameGridValues[PosX, PosY];
                if (fieldValue == 9)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    finished = true;
                    Console.WriteLine("\nTaste drücken um neuzustarten");
                    Console.ReadKey();
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Main();
                }

                Difficulty++;
                if (Difficulty == Width * Height)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    Console.Write("Gewonnen");
                    finished = true;
                    Console.WriteLine("\nTaste drücken um neuzustarten");
                    Console.ReadKey();
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Main();
                }

                if (finished)
                    return;

                Console.Write(fieldValue);
                Console.BackgroundColor = ConsoleColor.Black;
                break;

            case (int)KeyPresses.Left:
                PosX--;
                break;

            case (int)KeyPresses.Right:
                PosX++;
                break;

            case (int)KeyPresses.Up:
                PosY--;
                break;

            case (int)KeyPresses.Down:
                PosY++;
                break;

            default:
                break;

        }
        Console.SetCursorPosition(PosX, PosY);

    }

    public enum KeyPresses
    {
        Left = 37,
        Up,
        Right,
        Down,
        Space = 32,
        Quit = 27
    }
}
