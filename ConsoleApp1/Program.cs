using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    class Program
    {
        static void Main()
        {
            {
                Console.WriteLine("Омельков К.С.\nВариант №17\nЛабораторная работа №5");
            }


            try
            {
                Console.WriteLine("Введите диапозон чисел от 8 до 12 в строку, через пробел:");
                var values = Console.ReadLine().Split(new[] { ' ' });
                var list = new List<int>();
                foreach (var item in values)
                {
                    int value;
                    if (!int.TryParse(item, out value)) continue;
                    list.Add(value);
                }
                var arr = list.ToArray();
                if (arr.Length >= 4)
                {
                    decimal max = int.MaxValue;
                    var sum=0;
                    var i = 0;
                    while (i < arr.Length)
                    {
                        max = arr[i];
                        sum += arr[i];
                        i++;
                    }
                    var avg = sum * 1.0 / arr.Length;
                    var sigma = Math.Sqrt(arr.Sum(item => Math.Pow(item - avg, 2)) / (arr.Length - 1));
                    Console.WriteLine("Наибольшее значение массива: {0}", max);
                    Console.WriteLine("Сумма массива: {0:#0.000}", sum);
                    Console.WriteLine("Среднее квадратичное стандартное отклонение: {0:#0.00000000}", sigma);
                }
                else
                    Console.WriteLine("Введено чисел менее допустимого.");
            }
            catch
            {
                Console.WriteLine("Введено чисел менее допустимого.");
            }
           
            
            Console.ReadKey();
            
        }

            
        }

       
        }

