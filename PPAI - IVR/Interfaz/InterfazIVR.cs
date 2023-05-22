using PPAI___IVR.Controlador;
using PPAI___IVR.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI___IVR
{
    public partial class InterfazIVR : Form
    {
        private GestorOperador gestorOperador;
        private InterfazOperador interfazOperador;

        public InterfazIVR()
        {
            InitializeComponent();
        }

        public GestorOperador GestorOperador {  set => gestorOperador = value; }
        public InterfazOperador InterfazOperador { set => interfazOperador = value; }
        private void InterfazIVR_Load(object sender, EventArgs e)
        {

        }


    }
}
