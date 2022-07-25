using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Tasks
{
    public class Tasks1 // every task contain 10 solves
    {
        int a = 0;

        public Tasks1()
        {
           
        }
        public Tasks1(int a)
        {
            this.a = a;
            taskselection(this.a);
        }

        public void taskselection(int a)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine("Введите 3 стороны треугольника");
                    Console.WriteLine("Введите сторону a ");
                    double a1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону b ");
                    double b1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону c ");
                    double c1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(Heron(a1, b1, c1));// Функция решения 1 задачи  https://www.codewars.com/kata/57aa218e72292d98d500240f/csharp
                    break;
                case 2:
                    Console.WriteLine("Введите число");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(DescendingOrder(num2));// Функция решения 2 задачи
                    break;
                default:
                    break;
            }
        }


        //Heron's formula

        double Heron(double a, double b, double c)  /*Write function heron which calculates the area of a triangle with sides a, b, and c (x, y, z in COBOL).
                                                                Output should have 2 digits precision.*/ 
        {
            double s = (a + b + c) / 2;
            double result = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            result = Math.Round(result, 2);
            return result;
        }


        //Descending Order

        int DescendingOrder(int num) // Задача написать программу которая будет возавращать число, состоящее из цифр вводимиого но расположенных в порядке убывания
        {
            List<int> list = new List<int>();
            if (num == 0) {list.Add(0);}
            while (num > 0)
            {
                list.Add(num%10);
                num /= 10;
            }

            List<int> maxlist = new List<int>();
            int max = -1; // переменная для нахождения максимального числа в массиве
            int maxposition = -1; // переменная для позиции максимальной цифры

            for (int i = 0; i < list.Count;)
            {
                max = -1;
                int position = 0;
                foreach (var item in list)
                {
                    if (item>max)
                    {
                        max = item;
                        maxposition = position;
                    }
                    position++;
                }
                maxlist.Add(max);
                list.RemoveAt(maxposition);
            }

            int? result = null;

            foreach (var item in maxlist)
            {
                result = Convert.ToInt32(Convert.ToString(result) + Convert.ToString(item));
            }

            int resultint = (int)result;

            return resultint;
        }
    }
}
