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
    public partial class frmListadoGeneralDeGeneros : Form
    {
        public frmListadoGeneralDeGeneros()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            Int32 TotalGeneros = 0;

            dgvListar.Rows.Clear();
            for (Int32 i = 0; i < Vector.IND; i++)
            {
                dgvListar.Rows.Add(Vector.Generos[i].Nombre, Vector.Generos[i].Codigo, Vector.Generos[i].Descripcion);
                TotalGeneros++;
            }
            lblTotal.Text = TotalGeneros.ToString();
        }
    }
}
