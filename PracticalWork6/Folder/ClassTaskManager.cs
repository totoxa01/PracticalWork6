using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PracticalWork6.Folder
{
    class ClassTaskManager
    {
        //private int Scaner(Program[] a, int id)
        //{


        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i].Id == id)
        //        {
        //            Console.WriteLine($"ID процесса {a[i].Id}   {a[i].Name}");
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        //private void Exit(Program[] a, int b, int i)
        //{
        //    switch (i)
        //    {
        //        case 1:
        //            Process[] kill = Process.GetProcessesByName(a[b].Name);
        //            foreach (Process worker in kill)
        //            {
        //                worker.Kill();
        //            }
        //            break;
        //        case 2:
        //            Process[] kill2 = Process.GetProcessesByName(a[b].Name);
        //            foreach (Process worker in kill2)
        //            {
        //                worker.CloseMainWindow();
        //            }
        //            break;
        //    }
        //}

        //public void RunWorkProcess()
        //{
        //    Console.WriteLine("------------Задание 1------------");
        //    Program[] prArray = new Program[Process.GetProcesses().Length];
        //    int a = 0;
        //    foreach (Process pro in Process.GetProcesses())
        //    {
        //        prArray[a] = new Program(pro.Id, pro.ProcessName);
        //        a++;
        //    }
        //    for (int i = 0; i < prArray.Length; i++)
        //    {
        //        Console.WriteLine($"ID процесса {prArray[i].Id} {prArray[i].Name}");
        //    }
        //    Console.WriteLine("Введите ID процесса: ");
        //    int id = Int32.Parse(Console.ReadLine());

        //    int innum = Scaner(prArray, id);
        //    if (innum == -1) Console.WriteLine("Процесс с таким ID не найдет");
        //    Console.WriteLine();
        //}
    }
}
