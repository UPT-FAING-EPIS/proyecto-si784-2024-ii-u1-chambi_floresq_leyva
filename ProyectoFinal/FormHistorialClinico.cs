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
    public partial class FormHistorialClinico : Form
    {
        ClsHclinica objHclinica = new ClsHclinica();
        string dni, codcliente, idpaciente;
        public FormHistorialClinico()
        {
            InitializeComponent();
        }

        private void FormHistorialClinico_Load(object sender, EventArgs e)
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
                        CargarPaciente(codcliente);
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvVacunas.DataSource = null;
                        dgvRecetas.DataSource = null;
                        dgvDesparacitaciones.DataSource = null;
                        LIMPIARPANTALLA();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvPacientes.Rows[e.RowIndex];
                idpaciente = selectedRow.Cells[0].Value?.ToString();
                CargarDatosPaciente(idpaciente);
                objHclinica.idpaciente = Convert.ToInt32(idpaciente);
                objHclinica.VerVacunas();
                dgvVacunas.DataSource = objHclinica.VerVacunas();
                dgvVacunas.Columns[0].Width = 130;
                dgvRecetas.DataSource = objHclinica.VerRecetas();
                dgvRecetas.Columns[0].Width = 230;
                dgvDesparacitaciones.DataSource = objHclinica.VerDesparacitaciones();
                dgvDesparacitaciones.Columns[0].Width = 150;
            }
            else
            {
                
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

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void CargarDatosPaciente(string idpaciente)
        {
            //Instanciamos
            MSOFTVETDataContext dc = new MSOFTVETDataContext();
            var pacientes = dc.V_Paciente.Where(p => p.Cod_Paciente.ToString() == idpaciente);
            if (pacientes.Any())
            {
                foreach (var paciente in pacientes)
                {
                    string codpaciente = paciente.Cod_Paciente.ToString();
                    string nombrepaciente = paciente.Nombre;
                    txtnombrep.Text = paciente.Nombre;
                    txtespeciep.Text = paciente.Especie;
                    txtrazap.Text = paciente.Raza;
                    txtsexop.Text = paciente.Sexo;
                    txtfnacimientop.Text = paciente.Fecha.ToString("yy-MM-dd");
                }
            }
            else
            {
                MessageBox.Show("No se encontró pacientes vinculados al cliente.\r\nFavor de ingresar otro DNI", "Registro Vacunas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void LIMPIARPANTALLA()
        {
            txtDNI.Text = string.Empty;
            txtespeciep.Text = string.Empty;
            txtfnacimientop.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtnombrep.Text = string.Empty;
            txtrazap.Text = string.Empty;
            txtsexop.Text = string.Empty;
            dgvVacunas.Rows.Clear();
            dgvPacientes.Rows.Clear();
            dgvDesparacitaciones.Rows.Clear();
            dgvRecetas.Rows.Clear();
        }
    }
}
