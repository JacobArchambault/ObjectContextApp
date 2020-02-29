using static System.Console;
namespace ObjectContextApp
{
    class Program
    {
        static void Main()
        {
            WriteLine("***** Fun with Object Context *****\n");

            // Objects will display contextual info upon creation.
            _ = new SportsCar();
            WriteLine();
            _ = new SportsCar();
            WriteLine();
            _ = new SportsCarThreadSafe();
            ReadLine();

        }
    }
}