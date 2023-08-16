namespace Övning_4
{
    internal class Program
    {
        static void countOccurance(int num, int[] array) //metoden tar ett heltal och ett heltalsfält som input 
        {
            int counter = 0;

            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] == num)
                {
                    counter++;
                }
            }


            Console.WriteLine($"The number {num} occured {counter.ToString()} times");

            
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter the amount of numbers you want to input: ");
            int amountNumbers = Convert.ToInt32(Console.ReadLine());
            
            
            int[] array = new int[amountNumbers];

            for (int i = 0; i < amountNumbers; i++)
            {
                Console.WriteLine($"Number {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Please enter the number you want to count the occurance of: ");
            int num = Convert.ToInt32(Console.ReadLine());

            countOccurance(num, array);

            
        }
    }
}