using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programowanie__Obiektowe
{
    class Program
    {
        static void Main(string[] args)
        {

            Operacja op1 = new Operacja(2000000);
            
            DateTime startTime = DateTime.Now;
            op1.QuickSort(op1.initlistOfValues(), 0, op1.ListOfValuesSize - 1);
            op1.findLargestValue();
            DateTime stopTime = DateTime.Now;
            TimeSpan roznica = stopTime - startTime;
            Console.WriteLine("Czas pracy:" + roznica.Milliseconds);
            Console.ReadKey();
        }
    }
}
