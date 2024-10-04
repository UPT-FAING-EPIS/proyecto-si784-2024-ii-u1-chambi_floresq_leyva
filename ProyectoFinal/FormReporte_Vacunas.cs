using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormReporte_Vacunas : Form
    {
        public FormReporte_Vacunas()
        {
            InitializeComponent();
        }

        private void FormReporteVacunas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sOFTVETDataSet.Vacuna' Puede moverla o quitarla según sea necesario.
            this.vacunaTableAdapter.Fill(this.sOFTVETDataSet.Vacuna);

            this.reportViewer1.RefreshReport();
        }
    }
}
