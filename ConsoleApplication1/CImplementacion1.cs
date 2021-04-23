using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CImplementacion1:IBridge
    {
        public void MostrarTotales(Dictionary<string, double> pNotas)
        {
            double total = 0;
            int cantidad = 0;
            foreach (KeyValuePair<string, double> p in pNotas)
            {
                total += p.Value;
                cantidad++;
            }

            Console.WriteLine("El total de {0} productos es ${1}", cantidad, total);
        }

        public void ListarNotas(Dictionary<string, double> pNotas)
        {
            foreach (KeyValuePair<string, double> p in pNotas)
            {
                Console.WriteLine(p.Key);
            }
        }
    }
}
