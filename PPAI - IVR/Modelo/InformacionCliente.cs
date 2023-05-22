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

        /// <summary>
        /// Constructor de la clase actual
        /// </summary>
        /// <param name="datoAValidar"></param>
        public InformacionCliente(string datoAValidar)
        {
            this.DatoAValidar = datoAValidar;
        }
        public InformacionCliente()
        {

        }
        // Métodos set y get de la clase.
        public string DatoAValidar { get => datoAValidar; set => datoAValidar = value; }

        public bool esInformacionCorrecta()
        {
            return false;
        }
        public bool esValidacion()
        {
            return false;
        }
    }
}
