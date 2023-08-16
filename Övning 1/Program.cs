namespace Övning_1
{
    internal class Program
    {
        static void YourName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}");
        }

        static void Main(string[] args)
        {
            YourName();
        }
    }
}