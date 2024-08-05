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
    public partial class frmVIsualizacionesMes : Form
    {
        public frmVIsualizacionesMes()
        {
            InitializeComponent();
        }

        private void frmVIsualizacionesMes_Load(object sender, EventArgs e)
        {
            cmbMes.Items.Clear();
            for (Int32 i = 0; i < Vector.Meses.Length; i++)
            {
                cmbMes.Items.Add(Vector.Meses[i]);
            }
            cmbMes.SelectedIndex = -1;
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            if (cmbMes.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un mes.");
                return;
            }

            dgvListar.Rows.Clear();
            Int32 TotalVisualizaciones = 0;
            Int32 MaxVisualizaciones = Int32.MinValue;
            Int32 MinVisualizaciones = Int32.MaxValue;
            Int32 f = cmbMes.SelectedIndex;

            for (Int32 c = 0; c < Vector.Generos.Length; c++)
            {
                Int32 v = Matriz.Visualizaciones[c, f];
                dgvListar.Rows.Add(Vector.Generos[c].Nombre, Matriz.Visualizaciones[c, f]);
                TotalVisualizaciones = TotalVisualizaciones + Matriz.Visualizaciones[c, f];

                if (v > MaxVisualizaciones)
                {
                    MaxVisualizaciones = v;
                }
                if (v < MinVisualizaciones)
                {
                    MinVisualizaciones= v;
                }
            }
            lblTotalVisualizaciones.Text = TotalVisualizaciones.ToString();
            lblPromedio.Text = (TotalVisualizaciones / Vector.Meses.Length).ToString();
            lblMaxima.Text = MaxVisualizaciones.ToString();
            lblMinima.Text = MinVisualizaciones.ToString();
        }
        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        
    }
}
