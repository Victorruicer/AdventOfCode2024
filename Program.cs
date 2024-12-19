namespace AdventOfCode2024
{
    public class Program
    {
        static void Main(string[] args)
        {
            Day3 Exercise = new Day3();
            Exercise.day3();

            #region CONSOLE CONTROL
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(intercept: true);

                    //If the key pressed is Escape exit the loop and close the terminal
                    if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
            }
            #endregion
        }
    }
}

