using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI___IVR.Modelo
{
    public class SubOpcionLlamada
    {
        private string nombre;
        private int nroOrden;

        public SubOpcionLlamada(string nombre, int nroOrden)
        {
            this.Nombre = nombre;
            this.NroOrden = nroOrden;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
    }
}
