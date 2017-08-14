using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaApp.Net.Problema03
{
    public class MoneyParts
    {
        private List<decimal> Denominaciones = new List<decimal>{
           // 200m, 100m, 50m, 20m, 10m, 5m, 2m, 1m, 0.5m, 0.2m, 0.1m, 0.05m
            0.05m, 0.1m, 0.2m, 0.5m, 1m, 2m, 5m, 10m,20m, 50m, 100m, 200m
        };
        private List<List<decimal>> Agrupar { get; set; }

        public List<List<decimal>> Build(decimal monto)
        {
            Agrupar = new List<List<decimal>>();
            Grupo(monto);
            return Agrupar;
        }

        private void Grupo(decimal monto, decimal conbinaValor = 0m, List<decimal> g = null)
        {
            conbinaValor = conbinaValor == 0m ? Denominaciones.First() : conbinaValor;
            g = g == null ? new List<decimal>() : g;
            var indexOfNextCoin = Denominaciones.IndexOf(conbinaValor) + 1;
            var multiplo = (int)Math.Floor((monto / conbinaValor));
            var noCoincide = multiplo;
            do
            {
                var groupAux = new List<decimal>(g);
                for (int y = 0; y < noCoincide; y++)
                    groupAux.Add(conbinaValor);

                if (monto - (conbinaValor * noCoincide) < Denominaciones.Last() && monto != 0)
                    Agrupar.Add(groupAux);

                if (conbinaValor == Denominaciones.Last())
                    break;
                Grupo(monto - (conbinaValor * noCoincide), Denominaciones[indexOfNextCoin], groupAux);
                noCoincide--;
            } while (noCoincide >= 0);


        }
    }
}
