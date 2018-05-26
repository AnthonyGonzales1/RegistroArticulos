using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroArticulos
{
    public partial class MainRegistro : Form
    {
        public MainRegistro()
        {
            InitializeComponent();
        }

        private void registroArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroArticulos.UI.Registros.FormularioArticulos formularioArticulos=new UI.Registros.FormularioArticulos();
            formularioArticulos.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroArticulos.UI.Consultas.Consulta consulta = new UI.Consultas.Consulta();
            consulta.Show();
        }
    }
}
