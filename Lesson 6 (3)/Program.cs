using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6__3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string strt = Console.ReadLine();
            string[] strtArray = strt.Split();
            int i = 0;
            foreach (string a in strtArray)
            {
               
               Console.WriteLine(a);

            }
            Console.ReadKey();
        }
    }
}
