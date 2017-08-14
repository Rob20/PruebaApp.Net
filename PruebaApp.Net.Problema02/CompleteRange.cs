using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaApp.Net.Problema02
{
    public class CompleteRange
    {
        public static IEnumerable<int> Build(IEnumerable<int> entrada)
        {
            var ordenaLista = entrada.OrderBy(x => x);
            int numeroMaximo = ordenaLista.LastOrDefault();
            for (int i = 1; i <= numeroMaximo; i++)
                yield return i;
        }
    }
}
