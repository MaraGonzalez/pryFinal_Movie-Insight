using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFinal_Movie_Insight
{
    public partial class frmAgregarNuevoGenero : Form
    {
        public frmAgregarNuevoGenero()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (Vector.IND < Vector.Generos.Length) 
            {
                Vector.Generos[Vector.IND].Nombre = txtgenero.Text;
                Vector.Generos[Vector.IND].Codigo = Convert.ToInt32(txtcodigo.Text);
                Vector.Generos[Vector.IND].Descripcion = txtdescripcion.Text;
                Vector.IND++;
                MessageBox.Show("Los datos se cargaron correctamente");
                txtgenero.Text = "";
                txtcodigo.Text = "";
                txtdescripcion.Text = "";
            }
            else
            {
                MessageBox.Show("Ya no hay espacio para cargar un nuevo género");
            }
        }

        private void ControlarCajasDeTexto()
        {
            if (txtgenero.Text != "" && txtcodigo.Text != "" && txtdescripcion.Text != "")
            {
                cmdCargar.Enabled = true;
            }
            else
            {
                cmdCargar.Enabled = false;
            }
        }

        private void txtgenero_TextChanged(object sender, EventArgs e)
        {
            ControlarCajasDeTexto();
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            ControlarCajasDeTexto();
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {
            ControlarCajasDeTexto();
        }
    }
}

