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

        public OpcionLlamada(string audioMensajeSubOpciones, string mensajeSubOpciones, string nombre, int nroOrden)
        {
            this.AudioMensajeSubOpciones = audioMensajeSubOpciones;
            this.MensajeSubOpciones = mensajeSubOpciones;
            this.Nombre = nombre;
            this.NroOrden = nroOrden;
        }

        public string AudioMensajeSubOpciones { get => audioMensajeSubOpciones; set => audioMensajeSubOpciones = value; }
        public string MensajeSubOpciones { get => mensajeSubOpciones; set => mensajeSubOpciones = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
    }
}
