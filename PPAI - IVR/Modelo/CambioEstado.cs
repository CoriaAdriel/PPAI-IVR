using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI___IVR.Modelo
{
    public class CambioEstado
    {
        private DateTime fechaHoraInicio;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="fechaHoraInicio"></param>
        public CambioEstado(DateTime fechaHoraInicio)
        {
            this.FechaHoraInicio = fechaHoraInicio;
        }
        
        // Métodos set y get de la clase.
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
    }
}
