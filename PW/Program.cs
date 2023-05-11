using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try
            {
                double l = Convert.ToDouble(Console.ReadLine());
                double r = l / (2 * Math.PI);
                Console.WriteLine(r);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            
        }
    }
}
