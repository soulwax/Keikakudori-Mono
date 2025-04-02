using System;

namespace Keika
{

    /// <summary>
    /// This is the main entry point for the application.
    /// </summary>
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            Console.WriteLine("Hello, MonoGame!");
            Console.WriteLine("This is a simple MonoGame program.");

            using var game = new Keikakudori();
            game.Run();
            Console.WriteLine("Game has started. Press any key to exit...");
            Console.WriteLine("Exiting...");
            Console.WriteLine("Goodbye!");
        }
    }
}
