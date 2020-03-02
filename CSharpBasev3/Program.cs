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

                DZ3_3();
                


                Console.ReadKey();
            }


            static void WindowPreset()
            {
                Console.Title = "Шутов Денис Москва 37";
                Console.SetWindowSize(100, 30);
                Console.SetBufferSize(100, 30);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
            }
            static void DZ3_1()
            {
                ComplexNum a = new ComplexNum(1.1, 5.4);
                ComplexNum b = new ComplexNum(3.2, 3.5);

                ComplexNum sum = a + b;
                ComplexNum ext = a - b;

                Console.WriteLine($"Дано\nКомплексное число a({ a.Re }; { a.Im }); \nКомплексное число b({ b.Re }; { b.Im }).");
                Console.WriteLine($"a - b будет  ({ ext.Re }; { ext.Im }), \na + b будет ({ sum.Re }, { sum.Im }).");

            }

            class ComplexNum
            {
                public Double Re { get; set; }
                public Double Im { get; set; }

                public ComplexNum(double re, double im)
                {
                    Re = re;
                    Im = im;
                }

                public static ComplexNum operator -(ComplexNum a, ComplexNum b) => new ComplexNum(a.Re - b.Re, a.Im - b.Im);
                public static ComplexNum operator +(ComplexNum a, ComplexNum b) => new ComplexNum(a.Re + b.Re, a.Im + b.Im);

            }


            /*
             * 2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;

                   б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
            */
            static void DZ3_2()
            {
                
                Console.WriteLine("Вводите целые числа, для остановки введите 0 ");
                string KeyEnter;
                int summator = 0;
                int x;
                bool flag = true;
                do
                {
                    KeyEnter = Console.ReadLine();
                    flag = int.TryParse(KeyEnter, out x);

                    if (IsEven(x) == false & IsPositive(x) == true)
                        summator += x;

                }
                while (flag == true & x != 0);
                Console.WriteLine("Сумма положительных нечетных чисел равна =" + summator);
                
            }

            static bool IsEven(int number)
            {
                bool x;
                return x = (number % 2 == 0) ? true : false;
            }
            static bool IsPositive(int number)
            {
                bool x;
                return x = (number > 0) ? true : false;
            }

            /*
             * 3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса. Достаточно решить 2 задачи. Все программы сделать в одном решении.

            ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
            ArgumentException("Знаменатель не может быть равен 0");
            Добавить упрощение дробей.
            */
            static void DZ3_3()
            {
                Drob Dr1 = new Drob(1, 3);
                Drob Dr2 = new Drob(4, 6);
                Drob DrSum = Drob.SummDrob(Dr1, Dr2);
                Drob DrMult = Drob.MultiDrob(Dr1, Dr2);
                Drob DrRazn = Drob.RaznDrob(Dr1, Dr2);
                Drob DrDelen = Drob.DelenDrob(Dr1, Dr2);


                Console.WriteLine($"Имеются дроби {Dr1.X}/{Dr1.Y} и {Dr2.X}/{Dr2.Y} \n сумма их равна {DrSum.X}/{DrSum.Y} \n произведение их равно {DrMult.X}/{DrMult.Y} \n разность их равна { DrRazn.X}/{ DrRazn.Y}, \n деление их равно { DrDelen.X}/{ DrDelen.Y}.");
            }

            public class Drob
            {
                public int X { get; set; }
                public int Y { get; set; }

                public Drob(int x, int y)
                {
                    X = x;
                    Y = y;
                }

                public static Drob MultiDrob(Drob a, Drob b)
                {
                    int x = a.X * b.X;
                    int y = a.Y * b.Y;

                    Drob c = new Drob(x, y);
                 
                    return c;
                }

                public static Drob SummDrob(Drob a, Drob b)
                {
                    int x;
                    int y;

                    if (a.Y == b.Y)
                    {
                        x = a.X + b.X;
                        y = a.Y;
                    }
                    else if (a.Y > b.Y)
                    {
                        if (DelBezOst(a.Y, b.Y) == true)
                        {
                            y = a.Y;
                            x = a.X + b.X * Kratnost(a.Y, b.Y);
                        }
                        else
                        {
                            y = a.Y * b.Y;
                            x = a.X * b.Y + b.X * a.Y;
                        }
                    }
                    else
                    {
                        if (DelBezOst(b.Y, a.Y) == true)
                        {
                            y = b.Y;
                            x = b.X + a.X * Kratnost(b.Y, a.Y);
                        }
                        else
                        {
                            y = a.Y * b.Y;
                            x = a.X * b.Y + b.X * a.Y;
                        }
                    }
                                     
                    Drob c = new Drob(x, y);
                    return c;
                }
                public static Drob RaznDrob(Drob a, Drob b)
                {
                    int x;
                    int y;

                    if (a.Y == b.Y)
                    {
                        x = a.X - b.X;
                        y = a.Y;
                    }
                    else if (a.Y > b.Y)
                    {
                        if (DelBezOst(a.Y, b.Y) == true)
                        {
                            y = a.Y;
                            x = a.X - b.X * Kratnost(a.Y, b.Y);
                        }
                        else
                        {
                            y = a.Y * b.Y;
                            x = a.X * b.Y - b.X * a.Y;
                        }
                    }
                    else
                    {
                        if (DelBezOst(b.Y, a.Y) == true)
                        {
                            y = b.Y;
                            x = a.X * Kratnost(b.Y, a.Y) - b.X;
                        }
                        else
                        {
                            y = a.Y * b.Y;
                            x = a.X * b.Y - b.X * a.Y;
                        }
                    }

                    Drob c = new Drob(x, y);
                    return c;
                }

                public static Drob DelenDrob(Drob a, Drob b)
                {
                    int x = a.X * b.Y;
                    int y = a.Y * b.X;
                    Drob c = new Drob(x, y);
                    return c;
                }


                static bool DelBezOst(int x, int y)
                {
                    bool result = ((x % y) == 0) ? true : false;
                    return result;
                }
                static int Kratnost(int x, int y)
                {
                    int result = x / y;
                    return result;
                }
            }
               
                /*
                 * в корне проекта где SLN есть JGP с вопросом по теме, прокоментируйте пожалуйста почему не могу использовать OUT
                 */


        }
    }
}
 
 
 