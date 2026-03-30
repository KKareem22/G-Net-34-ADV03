using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV03
{
    internal class Helper
    {
        public static void Print<T>(string name,IEnumerable<T>list)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{name} : [ {string.Join(",",list)} ]");
            Console.ResetColor();
        }
    }
}
