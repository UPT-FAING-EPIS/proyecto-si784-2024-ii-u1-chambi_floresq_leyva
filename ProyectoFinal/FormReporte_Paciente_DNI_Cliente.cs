using ProyectoFinal.Clases;
using ProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormReporte_Paciente_DNI_Cliente : Form
    {
        // -- declarando para el envio de correo
        private string[] myAdjuntos;
        private CorreoManager correoManager;
        //--------
        string dni, correocli, codcliente,nomcliente,apecliente;

        public FormReporte_Paciente_DNI_Cliente()
        {
            InitializeComponent();
            //----
            correoManager = new CorreoManager();
        }
        //public String dni { get; set; }
        private void FormReporte_Paciente_DNI_Cliente_Load(object sender, EventArgs e)
        {


        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dni = txtDNI.Text;

            this.sP_PacientexClienteTableAdapter.Fill(this.sOFTVETDataSet_PacientesxDNI.SP_PacientexCliente, dni);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

            GrupoEnvio.Enabled = true;

        }
        // ---------- Codigo para enviar al correo del cliente 
        private void btnSubir_Click(object sender, EventArgs e)
        {
            AdjuntarArchivos();
        }
        private void CrearCuerpoCorreo()
        {
            correoManager.CrearCuerpoCorreo(correocli, "Reporte de Mascotas", "Hola "+nomcliente+" "+apecliente+" Enviamos en adjunto el Reporte de las mascotas registradas", myAdjuntos);
        }

        private void AdjuntarArchivos()
        {
            var names = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "Adjuntar archivos al correo";
            //ofd.InitialDirectory = @"C:\Ruta\A\Tu\Carpeta\Predeterminada";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                myAdjuntos = ofd.FileNames;
            }

            for (int i = 0; i < myAdjuntos.Length; i++)
            {
                names += myAdjuntos[i] + "\n";
            }

            lblFiles.Text = names;
            btnEnviar.Enabled = true;
        }
        private void Enviar()
        {
            try
            {
                correoManager.Enviar();
                MessageBox.Show("Enviado","Confirmación de envío",MessageBoxButtons.OK,MessageBoxIcon.Information);
                lblFiles.Text = "";
                btnEnviar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //--------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dni))
            {
                // Realiza la búsqueda en la base de datos utilizando el procedimiento almacenado
                BuscarCliente(dni);
            }
            else
            {
                MessageBox.Show("Ingrese un número de DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CrearCuerpoCorreo();
            Enviar();

        }

        public void BuscarCliente(string dni)
        {
            try
            {
                using (var dc = new MSOFTVETDataContext())
                {
                    // Llamar al procedimiento almacenado de búsqueda
                    var clienteEncontrado = dc.SP_BuscarCliente(dni).FirstOrDefault();

                    if (clienteEncontrado != null)
                    {
                        // Llena los TextBox con los datos encontrados
                        codcliente = clienteEncontrado.Cod_Cliente.ToString();
                        correocli = clienteEncontrado.Correo;
                        nomcliente = clienteEncontrado.Nombre;
                        apecliente = clienteEncontrado.Apellido;
                        MessageBox.Show("El correo del cliente es : " + correocli);
                    }
                }
            }
            catch
            {

            }
        }
    }
}
