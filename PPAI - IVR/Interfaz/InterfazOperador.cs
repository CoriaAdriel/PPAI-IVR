using PPAI___IVR.Controlador;
using PPAI___IVR.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI___IVR.Interfaz
{
    public partial class InterfazOperador : Form
    {
        private GestorOperador gestorOperador;

        public GestorOperador GestorOperador { get => gestorOperador; set => gestorOperador = value; }

        public InterfazOperador()
        {
            InitializeComponent();
        }

        private void InterfazOperador_Load(object sender, EventArgs e)
        {

        }
        public void mostrarDatos(string nombreCliente, string categoria, int opcion, int subOpcion, bool validacion)
        {
            if(validacion)
            {
                validar();
            }
        }
        public void mostrarOpValidacion()
        {

        }

        private void validar()
        {

        }
        public void tomarOpcionValida(int opcion)
        {
            gestorOperador.tomarOpcionValida();
        }
    }
}
