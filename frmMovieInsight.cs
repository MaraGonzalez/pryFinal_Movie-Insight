using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pryFinal_Movie_Insight.Vector;

namespace pryFinal_Movie_Insight
{
    public partial class frmMovieInsight : Form
    {
        public frmMovieInsight()
        {
            InitializeComponent();
        }

        private void frmMovieInsight_Load(object sender, EventArgs e)
        {
            
        }

        Random r = new Random();
        private void cargaAutomáticaDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generos[0] = new RegistroGenero(1, "Acción", "Películas llenas de emocionantes escenas de persecuciones, combates y situaciones de riesgo.");
            Generos[1] = new RegistroGenero(2, "Comedia", "Películas diseñadas para hacer reír al público con situaciones cómicas y humor.");
            Generos[2] = new RegistroGenero(3, "Drama", "Historias centradas en el desarrollo emocional de los personajes, a menudo explorando situaciones intensas.");
            Generos[3] = new RegistroGenero(4, "Ciencia Ficción", "Películas que presentan elementos de ciencia avanzada, tecnología futurista y conceptos imaginativos.");
            Generos[4] = new RegistroGenero(5, "Romántica", "Historias centradas en relaciones amorosas y emociones románticas.");
            Generos[5] = new RegistroGenero(6, "Terror", "Películas destinadas a asustar o provocar miedo en la audiencia.");
            Generos[6] = new RegistroGenero(7, "Fantasía", "Historias que incluyen elementos mágicos, criaturas extraordinarias y mundos imaginarios.");
            Generos[7] = new RegistroGenero(8, "Misterio", "Películas que involucran la resolución de un enigma o crimen.");
            Generos[8] = new RegistroGenero(9, "Aventura", "Narrativas emocionantes que siguen a los personajes en viajes y desafíos.");
            Generos[9] = new RegistroGenero(10, "Animación", "Películas que utilizan técnicas de animación para contar historias, generalmente dirigidas a un público más joven.");
            Vector.IND = 10;

            for (Int32 f = 0; f < Vector.Generos.Length; f++)
            {
                for (Int32 c = 0; c < Meses.Length; c++)
                {
                    Matriz.Visualizaciones[f, c] = r.Next(0, 100);
                }
            }
            MessageBox.Show("Se cargaron correctamente todos los datos");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAcercaDe Ventana = new frmAcercaDe();
            Ventana.ShowDialog();
        }

        private void agregarNuevoGéneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarNuevoGenero Ventana = new frmAgregarNuevoGenero();
            Ventana.ShowDialog();
        }

        private void listadoGeneralDeGénerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoGeneralDeGeneros Ventana = new frmListadoGeneralDeGeneros();
            Ventana.ShowDialog();
        }

        private void consultaDeDatosDeUnGéneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDatosGenero Ventana = new frmConsultaDatosGenero();
            Ventana.ShowDialog();
        }

        private void registrarVisualizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarVisualizaciones Ventana = new frmRegistrarVisualizaciones();
            Ventana.ShowDialog();
        }

        private void consultaDeVisualizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaVisualizaciones Ventana = new frmConsultaVisualizaciones();
            Ventana.ShowDialog();
        }

        private void visualizacionesDeUnMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVIsualizacionesMes Ventana = new frmVIsualizacionesMes();
            Ventana.ShowDialog();
        }

        private void visualizacionesDeUnGéneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizacionesGenero Ventana = new frmVisualizacionesGenero();
            Ventana.ShowDialog();
        }

        private void estadísticaDeVisualizacionesPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticasVisualizacionesXMes Ventana = new frmEstadisticasVisualizacionesXMes();
            Ventana.ShowDialog();
        }

        private void estadísticaDeVisualizacionesPorGéneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticasVisualizacionesXGenero Ventana = new frmEstadisticasVisualizacionesXGenero();
            Ventana.ShowDialog();
        }
    }
}
