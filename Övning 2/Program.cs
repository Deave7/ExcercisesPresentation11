namespace Övning_2
{
    internal class Program
    {
        static int GetMax(int compareOne, int compareTwo) //Övning 2 
        {
            if (compareOne > compareTwo)
            {
                return compareOne;
            }
            else
            {
                return compareTwo;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please input the first number");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the second number");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the third number");
            int numThree = Convert.ToInt32(Console.ReadLine());

            int resultOne = GetMax(numOne, numTwo);
            int resultTwo = GetMax(numTwo, numThree);
            int resultEnd = GetMax(resultOne, resultTwo);

            //Med metoden jag använde kan man också ta bort en rad.. genom att skriva andra raden så här: int = resultEnd GetMax(resultOne, numThree)

            //Man kan göra allt på en rad: resultEnd = GetMax(GetMax(numOne, numTwo) numThree);

            Console.WriteLine($"The largets number is {resultEnd}");
        }
    }
}