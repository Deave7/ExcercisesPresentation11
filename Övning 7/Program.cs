namespace Övning_7
{
    internal class Program
    {
        static void RearrangeNumber(int num)
        {

            string numString = num.ToString(); //Gör om vårat nummer till en sträng ie 1234 = "1234"
            char[] charArray = numString.ToCharArray(); //Gör om våran sträng till en char[]
            Array.Reverse(charArray); //Metoden Array.reverse ändrar ordningen på alla separata karaktärer
            numString = new string(charArray); //Skapar en ny sträng av det som finns i charArray
            Convert.ToInt32(numString); //Konverterar strängen till siffror igen ie "4321" = 4321

            Console.WriteLine($"Your number: {num} has been reversed to: {numString}");
        }


        static void Main(string[] args)
        {
            int num = 1234;
            RearrangeNumber(num);         
        }
    }
}