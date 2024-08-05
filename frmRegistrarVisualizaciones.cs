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
    public partial class frmRegistrarVisualizaciones : Form
    {
        public frmRegistrarVisualizaciones()
        {
            InitializeComponent();
        }

        private void frmRegistrarVisualizaciones_Load(object sender, EventArgs e)
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
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (cmbGenero.SelectedIndex != -1 && cmbMes.SelectedIndex != -1 && txtVisualizaciones.Text != "")
            {
                if (int.TryParse(txtVisualizaciones.Text, out int Visualizaciones))
                {
                    Int32 f = cmbGenero.SelectedIndex;
                    Int32 c = cmbMes.SelectedIndex;
                    Matriz.Visualizaciones[f, c] = Matriz.Visualizaciones[f, c] + Visualizaciones;
                    MessageBox.Show("Visualización registrada.");
                    cmbGenero.SelectedIndex = -1;
                    cmbMes.SelectedIndex = -1;
                    txtVisualizaciones.Text = "";
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido en el campo de visualizaciones.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los datos.");
            }
        }

        private void txtVisualizaciones_TextChanged(object sender, EventArgs e)
        {
            if (txtVisualizaciones.Text != "")
            {
                cmdCargar.Enabled = true;
            }
            else
            {
                cmdCargar.Enabled = false;
            }
        }
    }
}
