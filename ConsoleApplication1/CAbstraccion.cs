using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CAbstraccion
    {
        IBridge implementacion;
        Dictionary<string, double> notas;

        public CAbstraccion(IBridge pImp, Dictionary<string, double> pNota)
        {
            implementacion = pImp;
            notas = pNota;
        }
        public CAbstraccion(int pTipo, Dictionary<string, double> pNota)
        {
            if (pTipo == 1)
                implementacion = new CImplementacion1();
            if (pTipo == 2)
                implementacion = new CImplementacion2();
            

            notas = pNota;
        }

        public void MostrarTotales()
        {
            implementacion.MostrarTotales(notas);
        }

        public void Listar()
        {
            implementacion.ListarNotas(notas);
        }
    }
}
