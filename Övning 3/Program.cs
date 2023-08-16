namespace Övning_3
{
    internal class Program
    {
        static string LastFigure()
        {
            Console.WriteLine("Skriv in ditt nummer: ");
            string lastFigure = Console.ReadLine();
            char lastChar = lastFigure[lastFigure.Length - 1]; //Kollar på vad som finns på den sista index platsen och sparar det till variablen lastChar.
            
            switch (lastChar)
            {
                case '0':
                    return "Noll";

                case '1':
                    return "Ett";

                case '2':
                    return "Två";

                case '3':
                    return "Tre";

                case '4':
                    return "Fyra";

                case '5':
                    return "Fem";

                case '6':
                    return "Sex";

                case '7':
                    return "Sju";

                case '8':
                    return "Åtta";

                case '9':
                    return "Nio";

                default:
                    return "Din input var inte ett tal";

            }

        }

        static void Main(string[] args)
        {
            Console.Write(LastFigure());
        }
    }
}