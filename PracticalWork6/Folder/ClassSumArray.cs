using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork6.Folder
{
    class ClassSumArray
    {
        /// <summary>
        /// Сумма массива
        /// </summary>
        /// <param name="stringArray">строковый массив</param>
        /// <returns>возвращается сумма</returns>
        public static int SumArray(string[,] stringArray)
        {
            int summa = 0;
            if (stringArray.GetLength(0) != 4)
            {
                throw new MySizeArrayException();
            }
            for (int i = 0; i < stringArray.GetLength(0); i++)
            {                
                for (int j = 0; j < stringArray.GetLength(1); j++)
                {
                    try
                    {
                        summa += Int32.Parse(stringArray[i,j]);
                    }
                    catch
                    {
                        throw new MyArrayDataException(i, j);
                    }
                }
            }
            return summa;

        }
    }
}
