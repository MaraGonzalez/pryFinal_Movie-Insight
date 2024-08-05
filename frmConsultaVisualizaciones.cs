using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFinal_Movie_Insight
{
    public partial class frmConsultaVisualizaciones : Form
    {
        public frmConsultaVisualizaciones()
        {
            InitializeComponent();
        }

        private void frmConsultaVisualizaciones_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Clear();
            for (Int32 i = 0; i < Vector.Generos.Length; i++)
            {
                cmbGenero.Items.Add(Vector.Generos[i].Nombre);
            }
            cmbGenero.SelectedIndex = -1;

            cmbMes.Items.Clear();
            for (Int32 i = 0; i < Vector.Meses.Length; i++)
            {
                cmbMes.Items.Add(Vector.Meses[i]);
            }
            cmbMes.SelectedIndex = -1;

            cmdConsultar.Enabled = false;
        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarSeleccion();
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarSeleccion();
        }

        private void VerificarSeleccion()
        {
            cmdConsultar.Enabled = (cmbGenero.SelectedIndex != -1 && cmbMes.SelectedIndex != -1);
        }
        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbGenero.SelectedIndex;
            Int32 c = cmbMes.SelectedIndex;
            lblVisualizaciones.Text = Matriz.Visualizaciones[f, c].ToString();
        }


    }
}
