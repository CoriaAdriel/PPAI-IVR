using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI___IVR.Modelo
{
    public class OpcionLlamada
    {
        private string audioMensajeSubOpciones;
        private string mensajeSubOpciones;
        private string nombre;
        private int nroOrden;

        /// <summary>
        /// Constructor de la clase actual.
        /// </summary>
        /// <param name="audioMensajeSubOpciones"></param>
        /// <param name="mensajeSubOpciones"></param>
        /// <param name="nombre"></param>
        /// <param name="nroOrden"></param>
        public OpcionLlamada(string audioMensajeSubOpciones, string mensajeSubOpciones, string nombre, int nroOrden)
        {
            this.AudioMensajeSubOpciones = audioMensajeSubOpciones;
            this.MensajeSubOpciones = mensajeSubOpciones;
            this.Nombre = nombre;
            this.NroOrden = nroOrden;
        }

        // Métodos set y get de la clase.
        public string AudioMensajeSubOpciones { get => audioMensajeSubOpciones; set => audioMensajeSubOpciones = value; }
        public string MensajeSubOpciones { get => mensajeSubOpciones; set => mensajeSubOpciones = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
    }
}
