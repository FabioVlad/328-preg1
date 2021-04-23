using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CImplementacion2:IBridge
    {
        public void MostrarTotales(Dictionary<string, double> pNotas)
        {
            double total = 0;
            double totalm = 0;
            double totalf = 0;
 
            int cantidad = 0;
            foreach (KeyValuePair<string, double> p in pNotas)
            {
                total += p.Value;
                if (p.Key[0] == 'M')
                    totalm += p.Value;
                if (p.Key[0] == 'F')
                    totalf += p.Value;
                cantidad++;
            }
            Console.WriteLine("El total de notas de varones es {0}, {1}% del total", totalm, totalm / total * 100);
            Console.WriteLine("El total de notas de femeninas es {0}, {1}% del total", totalf, totalf / total * 100);
            Console.WriteLine("El total de {0} notas es ${1}", cantidad, total);
        }

        public void ListarNotas(Dictionary<string, double> pNotas)
        {
            foreach (KeyValuePair<string, double> p in pNotas)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if(p.Key[0]=='M')
                    Console.WriteLine("{0}-{1}",p.Key,p.Value);

            }
            foreach (KeyValuePair<string, double> p in pNotas)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (p.Key[0] == 'F')
                    Console.WriteLine("{0}-{1}", p.Key, p.Value);

            }

            
        }
    }
}
