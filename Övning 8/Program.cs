namespace Övning_8
{
    internal class Program
    {
        
        static int[] Addition(int[] arrayOne, int[] arrayTwo)
        {
            List<int> result = new List<int>(); //Skapar en lista för att lägga resultatet i
            int carry = 0;

            int i = 0;
            while (i < arrayOne.Length || i < arrayTwo.Length || carry > 0)
            {
                int sum = carry;
                if (i < arrayOne.Length)
                    sum += arrayOne[i];
                if (i < arrayTwo.Length)
                    sum += arrayTwo[i];

                result.Add(sum % 10); //Lägger till sista siffran av additionen till resultatet
                carry = sum / 10; //uppdaterar rest till nästa varv 

                i++;
            }

            result.Reverse(); //vänder resultatet 
            return result.ToArray();
        }
        
        
        static void Main(string[] args)
        {
            int[] arrayOne = { 1, 2, 3 }; //Detta är talet 321 
            int[] arrayTwo = { 1, 2, 3 }; //Detta är talet 321

            int[] result = Addition(arrayOne, arrayTwo);
            Console.WriteLine($"Sum: {string.Join("", result)}");
        }
    }
}