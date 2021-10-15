using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            int X = 0;
            int Y = 0;
            try
            {
                Console.Write("Введите целое число. X=");
                X = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadKey();
                return;
            }
            try
            {
                Console.Write("Введите целое число. Y=");
                Y = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Введите код операции:\n\t1 - сложение\n\t2 - вычитание\n\t3 - произведение\n\t4 - частное");
            try
            {
                Console.Write("Ваш выбор: ");
                int type = Convert.ToInt32(Console.ReadLine());
                if (type == 1)
                {
                    int result = X + Y;
                    Console.Write("Результат = ");
                    Console.WriteLine(result);
                }
                else
                {
                    if (type == 2)
                    {
                        int result = X - Y;
                        Console.Write("Результат = ");
                        Console.WriteLine(result);
                    }
                    else
                    {
                        if (type == 3)
                        {
                            int result = X * Y;
                            Console.Write("Результат = ");
                            Console.WriteLine(result);
                        }
                        else
                        {
                            if (type == 4)
                            {
                                int result = X / Y;
                                Console.Write("Результат = ");
                                Console.WriteLine(result);
                            }
                            else
                            {
                                Console.WriteLine("Нет операции с указанным номером");
                            }
                        }
                    }
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadKey();
                return;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadKey();
                return;
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка! {0}", ex.Message);
                Console.ReadKey();
                return;
            }
            Console.ReadKey();
        }
    }
}
