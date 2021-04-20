using System;

namespace PracticalWork6
{
    class Program
    {        

        static void Main(string[] args)
        {
            //Folder.ClassTaskManager classTaskManager = new Folder.ClassTaskManager();
            //classTaskManager.RunWorkProcess();

            Console.WriteLine("----------------Задание 2----------------");
            Console.WriteLine("Массив:");
            string[,] array = Folder.ClassFillingArray.FillingArray();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
                        
            try
            {
                Console.WriteLine("Сумма массива: "+Folder.ClassSumArray.SumArray(array));
            }
            catch (Folder.MySizeArrayException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            catch (Folder.MyArrayDataException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            

        }
    }
}
