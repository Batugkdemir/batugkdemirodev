namespace Batugkdemirodev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Enter The First Number:");
            int bas = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The End Number:");
            int bit = int.Parse(Console.ReadLine());
            Console.WriteLine("How Many Numbers Should Be Entered?:");
            int adet = int.Parse(Console.ReadLine());

            int[] numbers = new int[adet];
            int num;
            for (int i = 0; i < numbers.Length; i++)
            {
                num = rnd.Next(bas, bit);
                if (i == 0)
                {
                    numbers[i] = num;
                }
                for (int b = 0; b < i; b++)
                {
                    if (numbers[b] == num)
                    {
                        i--;
                        break;
                    }
                    else
                    {
                        numbers[i] = num;
                    }
                }
            }

            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}