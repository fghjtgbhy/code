using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = ConfigurationManager.AppSettings["num"];
            Console.WriteLine($"{num} new app");
        }
    }
}
