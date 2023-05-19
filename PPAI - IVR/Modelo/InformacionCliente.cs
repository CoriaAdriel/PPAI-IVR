using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI___IVR.Modelo
{
    public class InformacionCliente
    {
        private string datoAValidar;

        public InformacionCliente(string datoAValidar)
        {
            this.DatoAValidar = datoAValidar;
        }

        public string DatoAValidar { get => datoAValidar; set => datoAValidar = value; }
    }
}
