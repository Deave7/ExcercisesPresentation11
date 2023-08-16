namespace Övning_5
{
    internal class Program
    {

        static void CheckElement(int num, int[] array) //Metoden tar ett heltal och ett heltalsfält som input
        {
            try
            {
                if (array[num] > array[num + 1] && array[num] > array[num - 1])
                {
                    Console.WriteLine($"The element on index {num} is greater than it's neighbors");
                    Console.WriteLine($"Specified element: {array[num]}, neighbors: {array[num - 1]} & {array[num + 1]}");
                }
                else if (array[num] < array[num + 1] || array[num] < array[num - 1])
                {
                    Console.WriteLine($"The element on index {num} isn't greater than it's neighbors");
                    Console.WriteLine($"Specified element: {array[num]}, neighbors: {array[num - 1]} & {array[num + 1]}");
                }
            }
            catch
            {
                Console.WriteLine($"The element on index {num} does not have two neighbors");
            }
            
           


        }

        static void Main(string[] args)
        {
            //Utan userinput denna gång 
            int number = 1;
            int[] array = new int[5] { 1, 2, 10, 4, 5 };

            CheckElement(number, array);
        }
    }
}