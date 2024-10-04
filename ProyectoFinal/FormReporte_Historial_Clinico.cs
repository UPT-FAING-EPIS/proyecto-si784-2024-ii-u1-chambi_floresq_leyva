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
    public partial class FormReporte_Historial_Clinico : Form
    {
        // -- declarando para el envio de correo
        private string[] myAdjuntos;
        private CorreoManager correoManager;
        string  nomcliente, apecliente,correocli;
        // -------
        string id;
        ClsHclinica objHclinica = new ClsHclinica();
        string dni, codcliente, idpaciente;
        public FormReporte_Historial_Clinico()
        {
            InitializeComponent();
            correoManager = new CorreoManager();
        }

        private void FormReporte_Historial_Clinico_Load(object sender, EventArgs e)
        {

        }
        public void GenerarReporte()
        {
            id = idpaciente;
            // No tocar
            this.sP_HistorialClinicoTableAdapter1.Fill(this.sOFTVETDataSet_HC_Cli_Paciente.SP_HistorialClinico, id);
            this.sPR_HvacunacionTableAdapter.Fill(this.sOFTVETDataSet_HC_Vacunacion.SPR_Hvacunacion, id);
            this.sPR_HRecetacionTableAdapter.Fill(this.sOFTVETDataSet_HC_RECETARIO.SPR_HRecetacion, id);
            this.sPR_HdesparacitacionTableAdapter.Fill(this.sOFTVETDataSet_HC_Desparasitacion.SPR_Hdesparacitacion, id);
            this.reportViewer1.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dni = txtDNI.Text;
            if (!string.IsNullOrEmpty(dni))
            {
                // Realiza la búsqueda en la base de datos utilizando el procedimiento almacenado
                BuscarCliente(dni);               
            }
            else
            {
                MessageBox.Show("Ingrese un número de DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvPacientes.Rows[e.RowIndex];
                idpaciente = selectedRow.Cells[0].Value?.ToString();
                objHclinica.idpaciente = Convert.ToInt32(idpaciente);              
                GenerarReporte();
                GrupoEnvio.Enabled = true;
            }
            else
            {
                MessageBox.Show("Opción no valida!", "Error");
            }
            //---------------------------------------.
        }
        // -------- codigop para subir y enviar correo
        private void btnSubir_Click(object sender, EventArgs e)
        {
            AdjuntarArchivos();
        }
        private void CrearCuerpoCorreo()
        {
            correoManager.CrearCuerpoCorreo(correocli, "Reporte de Mascotas", "Hola " + nomcliente + " " + apecliente + " Enviamos en adjunto el Reporte de las mascotas registradas", myAdjuntos);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
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

        private void AdjuntarArchivos()
        {
            var names = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "Adjuntar archivos al correo";
            ofd.InitialDirectory = @"C:\REPORTES";

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
                MessageBox.Show("Enviado a: "+ correocli, "Confirmación de envío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblFiles.Text = "";
                btnEnviar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        // ----------
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
                        txtNombreCliente.Text = clienteEncontrado.Nombre;
                        nomcliente= clienteEncontrado.Nombre;
                        correocli = clienteEncontrado.Correo;
                        apecliente= clienteEncontrado.Apellido;
                        CargarPaciente(codcliente);
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //dgvVacunas.DataSource = null;
                        //dgvRecetas.DataSource = null;
                        //dgvDesparacitaciones.DataSource = null;
                        //LIMPIARPANTALLA();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarPaciente(string codcl)
        {
            //Instanciamos
            MSOFTVETDataContext dc = new MSOFTVETDataContext();
            var pacientes = dc.V_Paciente.Where(p => p.Cod_Cliente.ToString() == codcl).ToList();
            if (pacientes.Any())
            {
                dgvPacientes.Rows.Clear();
                // Llena tus controles o realiza acciones con la lista de resultados
                foreach (var paciente in pacientes)
                {
                    string codpaciente = paciente.Cod_Paciente.ToString();
                    string nombrepaciente = paciente.Nombre;
                    dgvPacientes.Rows.Add(codpaciente, nombrepaciente);
                }
            }
            else
            {
                MessageBox.Show("No se encontró pacientes vinculados al cliente.\r\nFavor de ingresar otro DNI", "Registro Vacunas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
