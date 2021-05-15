using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] height = new int[25];
            for (int i = 0; i < height.Length; i++)
            {
                height[i] = random.Next(125, 200 + 1);
                Console.Write(height[i] + " ");
            }


                Console.WriteLine();

                Console.WriteLine("Введите индекс роста ученеика ,которого надо удалить");
                int deleteIndex = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine();

                if (deleteIndex >= 0 && deleteIndex < height.Length)
                {
                    int[] tempArray = new int[height.Length];
                    for (int i = 0; i < height.Length; i++)
                    {
                        if (i < deleteIndex)
                        {
                            tempArray[i] = height[i];
                        }
                        else if (i > deleteIndex)
                        {
                            tempArray[i - 1] = height[i];
                        }
                    height = tempArray;
                    }
                    Console.Write(height + " ");
                }
            #region
            //for (int j = 0; j < height.Length; j++)
            //    {
            //    position = j;
            //    Console.WriteLine("Введите индекс роста ученика ,которого нужно удалить");
            //    char ouT = Convert.ToChar(Console.ReadLine());
            //        if ( Convert.ToInt32(ouT)  = height.Length || ouT = char.IsDigit )
            //        {
            //            Console.WriteLine("Ошибка ,вы ввели неправильное число !!!");
            //        }
            //        else if (ouT < height.Length)
            //        {
            //            int [] tempArray =new int [height.Length - ouT];
            //            Console.Write(tempArray + " ");
            //        }
            //    }
            #endregion 
            Console.ReadKey();
        }
    }
}
