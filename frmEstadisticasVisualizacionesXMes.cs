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
    public partial class frmEstadisticasVisualizacionesXMes : Form
    {
        public frmEstadisticasVisualizacionesXMes()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            dgvListar.Rows.Clear();
            for (Int32 c = 0; c < Vector.Meses.Length; c++)
            {
                Int32 TotalVisualizaciones = 0;
                Int32 MaxVisualizaciones = int.MinValue;
                Int32 MinVisualizaciones = int.MaxValue;
                Int32 MaxGenero = -1;
                Int32 MinGenero = -1;

                for (Int32 f = 0; f < Vector.Generos.Length; f++)
                {
                    Int32 v = Matriz.Visualizaciones[f,c];
                    TotalVisualizaciones = TotalVisualizaciones + v;

                    if (v > MaxVisualizaciones)
                    {
                        MaxVisualizaciones = v;
                        MaxGenero = f;
                    }
                    if ( v < MinVisualizaciones)
                    {
                        MinVisualizaciones = v;
                        MinGenero = f;
                    } 
                }
                Int32 PromedioVisualizaciones = (TotalVisualizaciones / Vector.Meses.Length);
                String MaxGeneroNombre = Vector.Generos[MaxGenero].Nombre; 
                String MinGeneroNombre = Vector.Generos[MinGenero].Nombre;

                dgvListar.Rows.Add(Vector.Meses[c], TotalVisualizaciones, PromedioVisualizaciones, MaxGeneroNombre, MinGeneroNombre);
            }
        }
    }
}
