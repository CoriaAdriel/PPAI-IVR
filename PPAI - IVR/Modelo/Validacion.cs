using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI___IVR.Modelo
{
    public class Validacion
    {
        private string audioMensajeValidacion;
        private string nombre;

        /// <summary>
        /// Constructor de la clase actual
        /// </summary>
        /// <param name="audioMensajeValidacion"></param>
        /// <param name="nombre"></param>
        public Validacion(string audioMensajeValidacion, string nombre)
        {
            this.AudioMensajeValidacion = audioMensajeValidacion;
            this.Nombre = nombre;
        }
        
        // Métodos set y get de la clase.
        public string AudioMensajeValidacion { get => audioMensajeValidacion; set => audioMensajeValidacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
