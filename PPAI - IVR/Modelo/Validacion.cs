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

        public Validacion(string audioMensajeValidacion, string nombre)
        {
            this.AudioMensajeValidacion = audioMensajeValidacion;
            this.Nombre = nombre;
        }

        public string AudioMensajeValidacion { get => audioMensajeValidacion; set => audioMensajeValidacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
