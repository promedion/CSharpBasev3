using System;

public class Homeworks_Done
{
    public Lesson01()
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
    }
}