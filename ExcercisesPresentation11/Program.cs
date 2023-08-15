using System;
using System.Collections;

namespace ExcercisesPresentation11
{
    internal class Program
    {
        static void YourName() //Övning 1
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}");
        }

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

        static string LastFigure()
        {
            Console.WriteLine("Skriv in ditt nummer: ");
            string lastFigure = Console.ReadLine();
            int lastChar = lastFigure[lastFigure.Length - 1];
            //Fortsätt här! Och gör alla uppgifter till nya projekt i samma solution :))))))
            switch (lastChar)
            {
                case 0:
                    return "Noll";

                case 1:
                    return "Ett";
                    
                case 2:
                    return "Två";
           
                case 3:
                    return "Tre";

                case 4:
                    return "Fyra";

                case 5:
                    return "Fem";

                case 6:
                    return "Sex";

                case 7:
                    return "Sju";

                case 8:
                    return "Åtta";

                case 9:
                    return "Nio";

                default:
                    return "Din input var inte ett tal";

            }


        }
        
        static void Main(string[] args)
        {
            //Övning 2
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

            string lastNumber = LastFigure();
            Console.WriteLine(lastNumber);
            
            
        }
    }
}