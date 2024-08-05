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
    public partial class frmEstadisticasVisualizacionesXGenero : Form
    {
        public frmEstadisticasVisualizacionesXGenero()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            dgvListar.Rows.Clear();
            for (Int32 f= 0; f < Vector.Generos.Length; f++)
            {
                Int32 TotalVisualizaciones = 0;
                Int32 MaxVisualizaciones = int.MinValue;
                Int32 MinVisualizaciones = int.MaxValue;
                Int32 MaxMes = -1;
                Int32 MinMes = -1;

                for (Int32 c = 0; c < Vector.Meses.Length; c++)
                {
                    Int32 v = Matriz.Visualizaciones[f, c];
                    TotalVisualizaciones = TotalVisualizaciones + v;

                    if (v > MaxVisualizaciones)
                    {
                        MaxVisualizaciones = v;
                        MaxMes = c;
                    }
                    if (v < MinVisualizaciones)
                    {
                        MinVisualizaciones = v;
                        MinMes = c;
                    }
                }
                Int32 PromedioVisualizaciones = (TotalVisualizaciones / Vector.Generos.Length);
                String MaxMesNombre = Vector.Meses[MaxMes];
                String MinMesNombre = Vector.Meses[MinMes];

                dgvListar.Rows.Add(Vector.Generos[f].Nombre, TotalVisualizaciones, PromedioVisualizaciones, MaxMesNombre, MinMesNombre);
            }
        }
    }
}