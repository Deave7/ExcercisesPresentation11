namespace Övning_6
{
    internal class Program
    {
        static void CheckElement(int[] array) //Metoden tar ett heltal och ett heltalsfält som input
        {
            try
            {
               for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > array[i + 1] && array[i] > array[i - 1])
                    {
                        Console.WriteLine($"The element on index {i} is greater than it's neighbors");
                        Console.WriteLine($"Specified element: {array[i]}, neighbors: {array[i - 1]} & {array[i + 1]}");
                        break;
                    }
                } 
            }
            catch
            {
                Console.WriteLine("-1"); 
            }

        }
        static void Main(string[] args)
        {
            
            int[] array = new int[5] { 1, 2, 10, 4, 5 };

            CheckElement(array);
        }
    }
}