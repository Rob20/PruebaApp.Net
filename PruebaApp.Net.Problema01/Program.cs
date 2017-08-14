using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaApp.Net.Problema01
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = " * *Casa 52";
            string salida = ChangeString.Build(entrada);
            Console.Write(salida);
            Console.ReadLine();
        }
    }
}
