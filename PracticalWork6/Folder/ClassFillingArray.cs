using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork6.Folder
{
    class ClassFillingArray
    {
        /// <summary>
        /// Заполнение массива рандомными числами
        /// </summary>
        /// <returns>возвращается заполненный массив</returns>
        public static string[,] FillingArray()
        {
            Random rn = new Random();
            string[,] stringArray = new string[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    stringArray[i, j] = rn.Next(1,50).ToString();
                }
            }
            return stringArray;
        }
    }
}
