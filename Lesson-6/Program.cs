using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
            //Знаки препинания не используются. Найти самое длинное слово в строке.
            Console.WriteLine("Введите предложение");
            string startString = Console.ReadLine();
            int m = 0;
            string W="";
            //разделяем строку на массив строк
            string[] stringArray = startString.Split();
            //Перебор строк
            foreach (string a in stringArray)
            {
                
            //Находим самое длинное слово
                if (a.Length>m)
                {
                    m = a.Length;
                    W = a;
                }
            }
            Console.WriteLine("Cамое длинное слово в строке {0}",W);
            Console.ReadKey();
        }
    }
}
