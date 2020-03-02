using System;
namespace HWDone
{
    public class Homeworks_Done
    {
        
            static void DZ1_1()
            {
                /*
                 *1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
                    а) используя склеивание;
                    б) используя форматированный вывод;
                    в) *используя вывод со знаком $.
                 */

                string name;
                string familyName;
                int age;
                int height;
                int wage;


                Console.WriteLine("Добро поджалуовать в программу Анкета");

                Console.WriteLine("Введите свое имя:");
                name = Console.ReadLine();
                Console.WriteLine("Введите свою фамилию:");
                familyName = Console.ReadLine();
                Console.WriteLine("Введите свой возраст:");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите свой рост в см:");
                height = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите свой вес До кг:");

                wage = int.Parse(Console.ReadLine());

                string outText1 = "Параметры Вашей записи А: " + name + " " + familyName + " " + age + " " + height + " " + wage;

                string outText2 = string.Format("Вы {0} {1} ваш возвраст {2}, рост {3} и вес {4}!", name, familyName, age, height, wage);

                string outText3 = $"Вы {name} {familyName} ваш возвраст {age}, рост {height} и вес {wage}!";

                Console.WriteLine(outText1);
                Console.WriteLine(outText2);
                Console.WriteLine(outText3);

            }

            static void DZ1_2()
            {
                /*
                * Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
                */
                Console.WriteLine("Добро поджалуовать в программу Рост вес ИМТ");


                Console.WriteLine("Введите свой рост в см:");
                int height = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите свой вес До кг:");
                int wage = int.Parse(Console.ReadLine());

                double indIMT = wage * 10000 / (height * height);
                Console.WriteLine("Ваш ИМТ (индекс массы тела) равен: " + indIMT);

            }
            static void DZ1_3()
            {
                /*
                * а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
                  б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
                */



                Console.WriteLine("Добро поджаловать в программу рассчета расстояния между двумя точками.");

                Console.WriteLine($"Расстояние между точками (5, 6)   и   (15, 26) равно {Rasstoyanie(5, 6, 15, 26)} единиц.");


                double Rasstoyanie(int x1, int y1, int x2, int y2)
                {

                    double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                    return r;

                }
            }

            static void DZ1_4()
            {
                /*
                * Написать программу обмена значениями двух переменных.
                а) с использованием третьей переменной;
                б) *без использования третьей переменной.
                */

                int a = 5;
                int b = 8;

                string outPrint = $"Сейчас а = {a}, и b = {b}";
                Console.WriteLine(outPrint);
                Console.WriteLine("Меняем переменные местами через вновь созданную третью переменную");
                int c = b;
                b = a;
                a = c;

                outPrint = $"Теперь а = {a}, и b = {b}";

                Console.WriteLine(outPrint);

                Console.WriteLine("А теперь меняем переменные местами обратно без создания новых переменных");

                a += b;
                b = a - b;
                a -= b;

                outPrint = $"И мы опять равны первоначальным значениям. а = {a}, и b = {b}";
                Console.WriteLine(outPrint);

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





        
    }
}