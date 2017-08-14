using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaApp.Net.Problema02
{
    class Program
    {
        static void Main(string[] args)
        {
            var entrada = new List<int>
            {
               //8,9,2,6,15
               //2, 1, 4, 5
               //4, 2, 9
               58, 60, 55
            };
            List<int> salida = CompleteRange.Build(entrada).ToList();
            for (int i = 0; i < salida.Count(); i++)
            {
                Console.Write(salida[i].ToString() + "\n");
            }
            Console.ReadLine();
        }
    }
}
