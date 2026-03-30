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
        public static void PrintDictionary<T1,T2>(string name,Dictionary<T1,T2>Dic)
        {
            Console.WriteLine(new string('_',30));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{name} :{name}");
            foreach(var item in Dic)
            {
                Console.WriteLine($"Key : {item.Key} , Value : {item.Value}");
            }
            Console.ResetColor();
            Console.WriteLine(new string('_', 30));
        }

        public static void PrintQueue<T>(string Name,Queue<T>q)
        {
            Console.WriteLine(new string('_', 30));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{Name} :");
            foreach(var item in q)
            {
                Console.WriteLine(item);
            }
            Console.ResetColor();
            Console.WriteLine(new string('_', 30));
        }
    }
}
