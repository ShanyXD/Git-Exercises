namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
              switch (choice)
            {
                case "a":
                    OptionsManager.Add(a, b);
                    break;
                case "s":
                    OptionsManager.Subtract(a, b);
                    break;
                case "m":
                    OptionsManager.Multiply(a, b);
                    break;
                case "dr":
                    OptionsManager.DivideRemainder(a, b);
                    break;
                case "ex":
                    Console.Clear();
                    Console.WriteLine("Goodbye");
                    Console.Readkey(true);
                    return;
            }
            Console.WritLine("Press any key to continue...");
            Console.Readkey(true);
        }
    }
}
