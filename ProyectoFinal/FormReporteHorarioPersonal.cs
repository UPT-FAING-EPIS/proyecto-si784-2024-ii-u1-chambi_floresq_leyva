using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace ProyectoFinal
{
    public partial class FormReporteHorarioPersonal : Form
    {
        int total85=0,total812=0,total125 = 0;
        public FormReporteHorarioPersonal()
        {
            InitializeComponent();
        }

        private void btnReporteCompleto_Click(object sender, EventArgs e)
        {

        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            Series series85  = new Series("08:00 - 05:00");
            Series series812 = new Series("08:00 - 12:00");
            Series series125 = new Series("12:00 - 05:00");
            chart1.Series["08:00 - 05:00"].Points.Clear();
            chart1.Series["08:00 - 12:00"].Points.Clear();
            chart1.Series["12:00 - 05:00"].Points.Clear();

            chart1.Series["08:00 - 05:00"].IsValueShownAsLabel = true;
            chart1.Series["08:00 - 12:00"].IsValueShownAsLabel = true;
            chart1.Series["12:00 - 05:00"].IsValueShownAsLabel = true;

            chart1.Series["08:00 - 05:00"].Points.AddXY(total85, total85 + 0);
            chart1.Series["08:00 - 12:00"].Points.AddXY(total812, total812 + 0);
            chart1.Series["12:00 - 05:00"].Points.AddXY(total125, total125 + 0);
            btnCargarDatos.Enabled = false;
            
        }

        private void FormReporteHorarioPersonal_Load(object sender, EventArgs e)
        {

        }

        private void btnReporteIngresado_Click(object sender, EventArgs e)
        {
            
        }

        public void btnLimpiar_Click(object sender, EventArgs e)
        {

            dgvLista.Rows.Clear();
        }
    }
}
