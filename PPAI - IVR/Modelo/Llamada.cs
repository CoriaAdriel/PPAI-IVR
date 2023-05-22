using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI___IVR.Modelo
{
    public class Llamada
    {
        private string descripcionOperador;
        private string detalleAccionRequerida;
        private TimeSpan duracion;
        private string encuestaEnviada;
        private string observacionAuditor;
        private List<CambioEstado> cambioEstados;
        private Cliente cliente;

        /// <summary>
        /// Constructor de la clase Llamada.
        /// </summary>
        /// <param name="descripcionOperador"></param>
        /// <param name="detalleAccionRequerida"></param>
        /// <param name="duracion"></param>
        /// <param name="encuestaEnviada"></param>
        /// <param name="observacionAuditor"></param>
        public Llamada(string descripcionOperador, string detalleAccionRequerida, TimeSpan duracion, string encuestaEnviada, string observacionAuditor)
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.observacionAuditor = observacionAuditor;
        }
        public Llamada()
        {

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
        public TimeSpan Duracion
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

        public Cliente Cliente { get => cliente; set => cliente = value; }

        public List<CambioEstado> getListCambioEstado()
        {
            return this.cambioEstados;
        }
        public void setListCambioEstado(List<CambioEstado> lista)
        {
            this.cambioEstados = lista;
        }
        public void addCambioEstado(CambioEstado cambioEstado)
        {
            this.cambioEstados.Add(cambioEstado);
        }
        public void setEstado(Estado estado)
        {
            foreach (CambioEstado item in cambioEstados)
            {
                if(item.sosActual())
                {
                    item.FechaHoraFin = DateTime.Now;
                }
            }
            CambioEstado cambioEstado = new CambioEstado(DateTime.Now);
            cambioEstado.Estado = estado;
            cambioEstados.Add(cambioEstado);
        }
        public void validarInfoCliente()
        {
            cliente.esInfoCorrecta();
        }

        public bool sosFinalizada()
        {
            foreach (CambioEstado item in cambioEstados)
            {
                if (item.sosActual())
                {
                    return item.Estado.Nombre == "Finalizada";
                     
                }
            }
            return false;
        }

        public void finalizar() {
            Estado estado = new Estado("Finalizada");
            setEstado(estado);

        }
    }
}
