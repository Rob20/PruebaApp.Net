using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaApp.Net.Problema03
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal entrada = 10.50m;
            List<List<decimal>> salida = new MoneyParts().Build(entrada);
            for (int i = 0; i < salida.Count(); i++)
            {
                Console.Write(salida[i].ToString() + "\n");
            }
            Console.ReadLine();

        }
    }
}
