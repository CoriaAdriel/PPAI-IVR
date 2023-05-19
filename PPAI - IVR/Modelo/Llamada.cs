using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI___IVR.Modelo
{
    public class Llamada
    {
        private string descripcionOperador;
        private string detalleAccionRequerida;
        private int duracion;
        private string encuestaEnviada;
        private string observacionAuditor;

        /// <summary>
        /// Constructor de la clase Llamada.
        /// </summary>
        /// <param name="descripcionOperador"></param>
        /// <param name="detalleAccionRequerida"></param>
        /// <param name="duracion"></param>
        /// <param name="encuestaEnviada"></param>
        /// <param name="observacionAuditor"></param>
        public Llamada(string descripcionOperador, string detalleAccionRequerida, int duracion, string encuestaEnviada, string observacionAuditor)
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.observacionAuditor = observacionAuditor;
        }

        // Métodos set y get de todos los atributos de la clase.
        public string DescripcionOperador
        {
            get { return descripcionOperador; }
            set { descripcionOperador = value; }
        }
        public string DetalleAccionRequerida
        {
            get { return detalleAccionRequerida; }
            set { detalleAccionRequerida = value; }
        }
        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
        public string EncuestaEnviada
        {
            get { return encuestaEnviada; }
            set { encuestaEnviada= value; }
        }
        public string ObservacionAuditor
        {
            get { return observacionAuditor; }
            set { observacionAuditor = value; }
        }
    }
}
