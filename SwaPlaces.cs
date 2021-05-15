using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapPlacesArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //В массиве случайных целых чисел поменять местами минимальный и максимальный элементы.
            int[] numberChanges = new int[10];
            Random random = new Random();
            foreach (var item in numberChanges)
            {
                Console.Write(item + " ");
            }
            for (int i = 0; i < numberChanges.Length / 2; i++)
            {
                numberChanges[i] = random.Next(0, 100);
                int tmp = numberChanges[i];
                numberChanges[i] = numberChanges[numberChanges.Length - i - 1];
                numberChanges[numberChanges.Length - i - 1] = tmp;
            }
                foreach (var item in numberChanges)
                {
                    Console.Write(item + " ");
                }
            Console.ReadLine();
        }
    }
}
