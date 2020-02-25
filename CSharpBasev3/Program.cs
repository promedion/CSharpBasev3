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
                
                DZ2_5();

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

            static void DZ2_1()
                {
                Console.WriteLine("Передаем в сравнение (0; -1; 1) (0, 5, 6) и (-3, -4, -7)");
                Console.WriteLine("Минимум здесь (0; -1; 1) " + MinOfThreeDouble(0, -1, 1));
                Console.WriteLine("Минимум здесь (0, 5, 6) " + MinOfThreeDouble(0, 5, 6));
                Console.WriteLine("Минимум здесь (-3, -4, -7) " + MinOfThreeDouble(-3, -4, -7));
                }
           
            static double MinOfThreeDouble(double x, double y, double z)
            {
            /*
                 *  1. Написать метод, возвращающий минимальное из трех чисел.
            */
               
                    double min = x;

                    if (x > y)
                    {
                        min = y;
                        min = (y > z) ? z : y;
                    }

                    else
                    { 
                        min = (x > z) ? z : x;
                    }

                    return min;
              

            }
            static void DZ2_2()
            {
                /* 
                    *2. Написать метод подсчета количества цифр числа.
                */
                Console.WriteLine("Введите целое число любой длинны: ");
                string input = Console.ReadLine();

                Console.WriteLine($"В этом числе {CountDigits(input)} цифр.");
            }
            static int CountDigits(string argument)
            {
                int count = 0;
                for (int i = 0; i < argument.Length; i++)
                    count++;

                return count;
            }
            static void DZ2_3()
            {
                /*
                   *  3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
               */
                Console.WriteLine("Вводите целые числа, для остановки введите 0 ");
                string KeyEnter;
                int summator = 0;
                do
                {
                    KeyEnter = Console.ReadLine();

                    if (IsEven(Int32.Parse(KeyEnter)) == false & IsPositive(Int32.Parse(KeyEnter)) == true)
                        summator += int.Parse(KeyEnter);

                }
                while (KeyEnter != Convert.ToString('0'));
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


            static void DZ2_4()
            {
                /*
                     *  4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел
                         (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
                         С помощью цикла do while ограничить ввод пароля тремя попытками.
                */
                string StoredLogin = "root";
                string StoredPassword = "GeekBrains";
                bool trusted = false;
                string EnteredLogin;

                do
                {
                    Console.WriteLine("Введите логин: ");
                    EnteredLogin = Console.ReadLine();
                    if (EnteredLogin.ToLower() == StoredLogin)
                    {
                        for (int i = 1; i <= 3; i++)
                        {
                            Console.WriteLine($"Пльзователь {EnteredLogin.ToLower()} введите пароль: ");
                            string EnteredPassword = Console.ReadLine();
                            if (EnteredPassword != StoredPassword)
                            {
                                Console.WriteLine($"Вы ввели не верный пароль, у Вас осталось {3 - i} попыток!");
                            }
                            else
                            {
                                Console.WriteLine("Верно!");
                                trusted = true;
                                break;
                            }
                        }
                    }
                        //trusted = (EnteredPassword == StoredPassword) ? true : false;

                    else
                    {
                        Console.WriteLine("Пользователь не обнаружен в системе.");
                    }
                }
                while (trusted != true);

                    Console.WriteLine($"Пользователь {EnteredLogin.ToLower()} Вы вошли!");



            }

            static void DZ2_5()
            {
                /*
                     *  5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
                            б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
                */
                Console.WriteLine("Добро поджалуовать в программу Рост вес ИМТ");


                Console.WriteLine("Введите свой рост в см:");
                int height = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите свой вес До кг:");
                int wage = int.Parse(Console.ReadLine());
                string resultat;
                double indIMT = wage * 10000 / (height * height);
                Console.WriteLine("Ваш ИМТ (индекс массы тела) равен: " + indIMT);

                if (indIMT > 25) 
                {
                    resultat = "У Вас имеется лишний вес!";
                } 
                else if (indIMT == 25)
                {
                    resultat = "Вы в идеальной форме!";
                }
                else
                {
                    resultat = "Вам возможно не хватает пары килограммов!";
                }


                Console.WriteLine(resultat);
               
                
                

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
 
 
 
 