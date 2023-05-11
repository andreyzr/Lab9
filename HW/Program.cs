using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Привет, пользователь!Я твой калькулятор");
                Console.Write("Введите челое число. X=");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите челое число. Y=");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:\n   1 - сложение\n   2 - вычитани\n   3 - произведение\n   4 - частное");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ваш выбор: {0}", n);
                switch (n)
                {
                    case 1:
                        {
                            Console.WriteLine("Результат равен: {0}",x + y);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Результат равен: {0}", x - y);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Результат равен: {0}", x *y);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Результат равен: {0}", x/y);
                            break;
                        }
                        default:
                        {
                            Console.WriteLine("Нет операции с указанным номером");
                            break;
                        }
                }

            }          
            catch (Exception )
            {
                Console.WriteLine("Ошибка!Входная строка имела неверный формат");
            }
            Console.ReadKey();
        }
    }
}
