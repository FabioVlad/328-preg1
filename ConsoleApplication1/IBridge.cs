using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IBridge
    {
        void MostrarTotales(Dictionary<string, double> pNotas);
        void ListarNotas(Dictionary<string, double> pNotas);
    }
}
