using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutovDenis
{ 
    namespace CSharpBasev3
    {
        class Program
        {
            static void Main()
            {
                WindowPreset();

                //ВНИМАНИЕ!!!   Ниже необходимо менять по очереди одну цифру Х в методе DZ2_X(); до 5
                
                //DZ2_5();

                Console.ReadKey();
            }


            static void WindowPreset()
            {
                Console.Title = "Шутов Денис Москва 37";
                Console.SetWindowSize(50, 10);
                Console.SetBufferSize(50, 20);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
            }






            /*        
            Сначала первые 5 потом если останется время после уровня 2 доделаешь бонусы.

            6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр. Реализовать подсчет времени выполнения программы, используя структуру DateTime.
            7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);

            б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
            Достаточно решить 4 задачи. Разбивайте программы на подпрограммы. Переписывайте в начало программы условие и свою фамилию. Все программы делайте в одном решении.
            */
        }

    }
}
 
 
 
 