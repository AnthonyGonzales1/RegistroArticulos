using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistroArticulos.BLL;
using RegistroArticulos.Entidades;

namespace RegistroArticulos.UI.Registros
{
    public partial class FormularioArticulos : Form
    {
        public FormularioArticulos()
        {
            InitializeComponent();
        }

        private void FormularioArticulos_Load(object sender, EventArgs e)
        {

        }

        private Articulos LlenaClase() {

            Articulos articulos = new Articulos();

            articulos.ArticuloID = Convert.ToInt32(numericUpDown1.Value);
            articulos.FechaVC = FechavdateTimePickr1.Value;
            articulos.Descripcion = DescriptextBox.Text;
            articulos.Precio = Convert.ToSingle(PrectextBox.Text);
            articulos.Existencia = Convert.ToSingle(ExisttextBox.Text);
            articulos.CantidadCo = Convert.ToSingle(CantcotextBox.Text);

            return articulos;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void FormularioArticulos_Load_1(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Articulos articulos = LlenaClase();
            bool Paso = false;
            //determinar si es guardar o eliminar
            if (numericUpDown1.Value == 0)
                Paso = BLL.ArticulosBLL.Guardar(articulos);
            else
                Paso = BLL.ArticulosBLL.Modificar(LlenaClase());
            //aqui informa el resultado
            if (Paso)
                MessageBox.Show("Guardado!!","Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            FechavdateTimePickr1.Value=DateTime.Now;
            DescriptextBox.Clear();
            PrectextBox.Clear();
            ExisttextBox.Clear();
            CantcotextBox.Clear();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            //inicializando el filtro en true
            int id = Convert.ToInt32(numericUpDown1.Value);
            Articulos articulos = BLL.ArticulosBLL.Buscar(id);

            if (articulos != null) {
                FechavdateTimePickr1.Value = articulos.FechaVC;
                DescriptextBox.Text = articulos.Descripcion;
                PrectextBox.Text = articulos.Precio.ToString();
                ExisttextBox.Text = articulos.Existencia.ToString();
                CantcotextBox.Text = articulos.CantidadCo.ToString();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDown1.Value);

            if (BLL.ArticulosBLL.Eliminar(id))
                MessageBox.Show("Eliminado","Exito", MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar","Fallo", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

    }
}
