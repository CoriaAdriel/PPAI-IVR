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
        private Estado estado;
        private DateTime fechaHoraFin;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="fechaHoraInicio"></param>
        public CambioEstado(DateTime fechaHoraInicio)
        {
            this.FechaHoraInicio = fechaHoraInicio;
        }
        public CambioEstado()
        {

        }
        
        // Métodos set y get de la clase.
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public Estado Estado { get => estado; set => estado = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }

        public bool esEstadoInicial()
        {
            return false;
        }
        public bool ultimoEstado()
        {
            return false;
        }
        public bool sosActual()
        {
            return fechaHoraFin == null;
        }
        
    }
}
