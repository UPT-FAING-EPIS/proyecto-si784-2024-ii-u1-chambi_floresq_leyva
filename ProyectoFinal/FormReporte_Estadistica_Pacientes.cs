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
    public partial class FormReporte_Estadistica_Pacientes : Form
    {
        public FormReporte_Estadistica_Pacientes()
        {
            InitializeComponent();
        }

        private void FormReporte_Estadistica_Pacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sOFTVETDataSet_Est_Paciente.Paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter.Fill(this.sOFTVETDataSet_Est_Paciente.Paciente);

            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
