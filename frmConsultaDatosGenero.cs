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
    public partial class frmConsultaDatosGenero : Form
    {
        public frmConsultaDatosGenero()
        {
            InitializeComponent();
        }
        private void frmConsultaDatosGenero_Load(object sender, EventArgs e)
        {
            cmbGeneros.Items.Clear();
            for (Int32 i = 0; i < Vector.IND; i++)
            {
                cmbGeneros.Items.Add(Vector.Generos[i].Nombre);
            }
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            if (cmbGeneros.SelectedIndex != -1)
            {
                Int32 i = cmbGeneros.SelectedIndex;
                lblCodigo.Text = Vector.Generos[i].Codigo.ToString();
                lblDescripcion.Text = Vector.Generos[i].Descripcion;
            }
            else
            {
                MessageBox.Show("Por favorm seleccione un género.");
            }
        }

        private void cmbGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGeneros.SelectedIndex != -1)
            {
                cmdConsultar.Enabled = true;
            }
            else
            {
                cmdConsultar.Enabled = false;
            }

        }
    }
}
