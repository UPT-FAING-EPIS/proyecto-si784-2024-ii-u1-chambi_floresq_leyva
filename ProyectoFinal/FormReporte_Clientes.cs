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
    public partial class FormReporte_Clientes : Form
    {
        public FormReporte_Clientes()
        {
            InitializeComponent();
        }

        private void FormReporte_Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sOFTVETDataSet_Clientes.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.sOFTVETDataSet_Clientes.Cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
