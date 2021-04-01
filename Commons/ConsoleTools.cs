using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2.Commons
{
    public class ConsoleTools : IConsoleTools
    {
        public void Escrever(string value)
        {
            Console.WriteLine(value);
        }

        public string Ler()
        {
            return Console.ReadLine();
        }
    }
}
