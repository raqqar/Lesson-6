using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6__2_
{
    class Program
    {
        //Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
        //Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом
        //без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).
        static void Main(string[] args)
        {
            ///Вводим с клавиатуры предложение
            Console.WriteLine("Введите предложение");
            string startString = Console.ReadLine();
            string b = "";
            bool flag =false;

            //Приводим к одному регистр
            b = startString.ToLower();

            //Убираем пробелы
            b = b.Replace(" ",string.Empty);
            
            //Определяем является ли строка палиндромом
            for (int i = 0; i < b.Length/2; i++)
            {
                //Сравнивем символы первый с последним и т.д.
                if (b[i] == b[b.Length - i - 1])
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            switch (flag)
            {
                case true:
                    {
                        Console.WriteLine("Предложение полиндром");
                        break;
                    }
                case false:
                    {
                        Console.WriteLine("Предложение не полиндром");
                        break;
                    }
                default:
                    break; 
            }
            Console.ReadKey();
        }  
    }
}
