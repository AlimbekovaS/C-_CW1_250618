using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");
            //Console.Write("Введите имя: ");

            //string str = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("Привет," +str); //+str KONKATENACIA STROK
            task13();
        }

        static void task1()
        {
            //1.Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка.Программа должна сосчитать количество введенных пользователем пробелов.
            string str="";
            int i = 0;
            do
            {
                str += Console.ReadLine();// str=str+cr()
                i++; //i=i+1;
               // Console.Clear();

            } while (!str.Contains('.'));

            int countSpace = str.Count(w => w == ' ');

            int b = 0;
            for (int k = 0; k < str.Length; k++)
            {
                if (str[k] == ' ')
                    b++;
            }
            Console.WriteLine("Кол-во символов: " + i);
            Console.WriteLine("Кол-во пробелов: " + countSpace);
            Console.WriteLine("Кол-во пробелов: " + b);

        }

        static void task2()
        {
            //2.Ввести с клавиатуры номер трамвайного билета(6 - значное число) и проверить является ли данный билет 
            //    счастливым(если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).

            string ticket = Console.ReadLine();
            if(ticket.Length==6)
            {
                //summa pervyh treh cifr
                int sum1 = ticket[0]+ ticket[1]+ ticket[2];
                //summa posled treh cifr
                int sum2 = ticket[3] + ticket[4] + ticket[5];
               if(sum1==sum2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Билет счастливый!");
                }
               else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Билет не счастливый!");

                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Длин а билета не правильная");
            }
        }

        static void task3()
        {
            //4.Даны целые положительные числа A и B (A < B).Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке; 
            //при этом каждое число должно выводиться количество раз, равное его значению. Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод: 
            //3 3 3
            //4 4 4 4
            //5 5 5 5 5
            //6 6 6 6 6 6
            //7 7 7 7 7 7 7

            int A =Int32.Parse( Console.ReadLine());
            int B = Int32.Parse(Console.ReadLine());

            for(int i=A;i<=B;i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine(" ");
            }
        }

        static void task4()
        {
            // 5.Дано целое число N(> 0), найти число, полученное при прочтении числа N справа налево. Например, если было введено число 345, то программа должна вывести число 543.
            string a = Console.ReadLine();
            if(Int32.Parse(a)>0)
            {
                for(int i=a.Length-1;i>=0;i--)
                {
                    Console.Write(a[i]);
                }
            }
        }

        static void task5()
        {
            //6.	Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
            string str;
            Random rnd = new Random();
            str = rnd.Next(1, 30) + " " + rnd.Next(2, 20) +"  "+ rnd.Next(3, 40);
            Console.WriteLine(str);
        }
        static void task6()
        {
            //8.	Дано расстояние в сантиметрах. Найти число полных метров в нем.
            float A = Int32.Parse(Console.ReadLine());
            float B = A / 100;
            Console.WriteLine(B);
        }

        static void task7()
        {
            //9.	С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
            int A=234/7;
            Console.WriteLine(A);
        }

        static void task8()
        {
            //            11.Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
            //            a.А или В;
            //            b.А и В;
            //            c.В или С.

            bool A = bool.Parse(Console.ReadLine());
            bool B = bool.Parse(Console.ReadLine());
            bool C = bool.Parse(Console.ReadLine());
            if(A || B)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if (A & B)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if (B||C)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }

        static void task9()
        {
            //Напечатать "столбиком": 
            //a.все целые числа от 20 до 35;
            //b.квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
            //c.третьи степени всех целых чисел от a до 50(значение a вводится с клавиатуры; a < 50);
            //d.все целые числа от a до b(значения a и b вводятся с клавиатуры; b > a).
            for (int i = 20; i < 35; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("-------------");
            int b = Int32.Parse(Console.ReadLine());
            if (b > 10)
            {
                for (int i = 10; i <= b; i++)
                {
                    Console.WriteLine("{0}", Math.Pow(i,2));
                }
            }
            else
            {
                Console.WriteLine("Error b");
            }
            Console.WriteLine("-------------");
            int a = Int32.Parse(Console.ReadLine());
            if (a > 10)
            {
                for (int i = 10; i <= b; i++)
                {
                    Console.WriteLine("{0}", Math.Pow(i, 3));
                }
            }
            else
            {
                Console.WriteLine("Error a");
            }
        }

        static void task10()
        {
            //16.	вычисления значения функции y= 7x2-3x+6 при любом значении x;
            //double x = double.Parse(Console.ReadLine());
            double x;
            Random rnd = new Random();
            x = rnd.Next(1,30);
            double y = 7 * 2 - 3 - x + 6;
            Console.WriteLine(y);
        }
        static void task11()
        {
            //31.	Известны два расстояния: одно в километрах, другое — в футах ( 1 фут 0,305 м ). Какое из расстояний меньше?
            double m1 = Int32.Parse(Console.ReadLine());
            double f2 = Int32.Parse(Console.ReadLine());
            m1 = (f2 * 0.304)/1000;
            if(m1>f2)
                Console.WriteLine("второе растояние меньше");
            else
                Console.WriteLine("первое растояние меньше");
        }
        static void task12()
        {
            // 34. .Составить программу, которая в зависимости от порядкового номера дня недели (1, 2, ..., 7) выводит на экран его название(понедельник, вторник, ..., воскресенье).
            int a = Int32.Parse(Console.ReadLine());
            DayOfWeek dow = (DayOfWeek)a;
            Console.WriteLine(dow);
            //var t = DateTime.Now.DayOfWeek
        }
        static void task13()
        {
            //    37.Составить программу, которая в зависимости от порядкового номера месяца(1, 2, ..., 12) выводит на экран количество дней в этом месяце. Рассмотреть два случая:
            //    a.год не является високосным (см.задачу 4.65);
            //    b.год может быть високосным (информация об этом вводится с клавиатуры).
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.DaysInMonth(2018,a));
           
        }
    }
}
