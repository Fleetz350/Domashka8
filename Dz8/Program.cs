using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Dz8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Задание 1";
            Type t = typeof(DateTime);
            var dat1 = new DateTime();
            dat1 = DateTime.Now;
            foreach (var prop in t.GetProperties())
                Console.WriteLine(prop.Name);
            Console.WriteLine(dat1.Year);           
            Console.WriteLine(dat1);
            Console.ReadKey();
        }
    }
}
