using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name + "\nРад тебя видеть, " + name);
            Console.ReadKey();

        }
    }
}
