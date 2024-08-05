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
    public partial class frmVisualizacionesGenero : Form
    {
        public frmVisualizacionesGenero()
        {
            InitializeComponent();
        }

        private void frmVisualizacionesGenero_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Clear();
            for (Int32 i = 0; i < Vector.Generos.Length; i++)
            {
                cmbGenero.Items.Add(Vector.Generos[i].Nombre);
            }
            cmbGenero.SelectedIndex = -1;
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            if (cmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un género.");
                return;
            }

            dgvListar.Rows.Clear();
            Int32 TotalVisualizaciones = 0;
            Int32 MaxVisualizaciones = Int32.MinValue;
            Int32 MinVisualizaciones = Int32.MaxValue;
            Int32 f = cmbGenero.SelectedIndex;

            dgvListar.Rows.Clear();
            for (Int32 c = 0; c < Vector.Meses.Length; c++)
            {
                Int32 v = Matriz.Visualizaciones[f, c];
                dgvListar.Rows.Add(Vector.Meses[c], Matriz.Visualizaciones[f, c]);
                TotalVisualizaciones = TotalVisualizaciones + Matriz.Visualizaciones[f, c];

                if (v > MaxVisualizaciones)
                {
                    MaxVisualizaciones = v;
                }
                if (v < MinVisualizaciones)
                {
                    MinVisualizaciones = v;
                }
            }
            lblTotalVisualizaciones.Text = TotalVisualizaciones.ToString();
            lblPromedio.Text = (TotalVisualizaciones / Vector.Generos.Length).ToString();
            lblMaxima.Text = MaxVisualizaciones.ToString();
            lblMinima.Text = MinVisualizaciones.ToString();
        }
    }
}
