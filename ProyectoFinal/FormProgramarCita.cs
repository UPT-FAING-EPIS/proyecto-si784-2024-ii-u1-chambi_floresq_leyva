using ProyectoFinal.Modelos;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormProgramarCita : Form
    {
        int id_pacienteSeleccionado;
        string id_cliente, mot, ho, tam;
        int c_c;
        DateTime fe;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            Desactivar();
            LIMPIARPANTALLA();
            cmbTamano.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                CargarCliente();
                CargarTablaPaciente();

                // Verificar si hay filas en el DataGridView dgvPacientes
                if (dgvPacientes.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún paciente asociado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un DNI...", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormProgramarCita_Load(object sender, EventArgs e)
        {
            CargarTablaCitas();
            CargarTablaPaciente();
            CargarCliente();
            Desactivar();
        }

        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            if (id_pacienteSeleccionado > 0)
            {
                dgvPacientes.DataSource = null;
                Programar();
                CargarTablaCitas();
                CargarTablaPaciente();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente antes de programar la cita.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void CargarTablaPaciente()
        {
            try
            {
                using (var dc = new MSOFTVETDataContext())
                {
                    if (!string.IsNullOrEmpty(id_cliente))
                    {
                        int codCliente = Convert.ToInt32(id_cliente);

                        // Obtener la lista de pacientes asociados al cliente desde la vista V_Paciente
                        var listaPacientes = dc.V_Paciente.Where(p => p.Cod_Cliente == codCliente).ToList();

                        // Asignar la lista de pacientes al DataGridView
                        dgvPacientes.DataSource = listaPacientes;
                        // dgvPacientes.Columns[0].Width = 90; // Ajusta según las necesidades
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de pacientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarCliente()
        {
            //Instanciamos
            MSOFTVETDataContext dc = new MSOFTVETDataContext();

            string dniBusqueda = txtBuscar.Text;

            var clienteEncontrado = dc.V_Cliente.FirstOrDefault(c => c.DNI == dniBusqueda);

            if (clienteEncontrado != null)
            {
                txtNomCliente.Text = clienteEncontrado.Nombre;
                txtApelCliente.Text = clienteEncontrado.Apellido.ToString();
                id_cliente = clienteEncontrado.Cod_Cliente.ToString();
                Activar();
                cmbTamano.Enabled = true;
            }
            else
            {
                txtNomCliente.Text = "Cliente no encontrado";
                LIMPIARPANTALLA();
            }
        }

        private void Programar()
        {
            try
            {
                using (var dc = new MSOFTVETDataContext())
                {
                    c_c = Convert.ToInt32(id_cliente);
                    fe = dtPicker1.Value.Date;
                    ho = txtHora.Text;
                    mot = txtMotivo.Text;
                    tam = cmbTamano.Text;
                    if (!string.IsNullOrEmpty(ho) && !string.IsNullOrEmpty(mot) && !string.IsNullOrEmpty(tam))
                    {
                        string est = "Pendiente";
                        // Llamar al procedimiento almacenado para agregar una nueva cita
                        dc.SP_AgregarCita(mot, fe, ho, c_c, est, tam, id_pacienteSeleccionado);
                        MessageBox.Show("Cita agregada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LIMPIARPANTALLA();
                        Desactivar();
                        txtBuscar.Text = "";
                        cmbTamano.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Llene todos los datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al programar cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarTablaCitas()
        {
            try
            {
                using (var dc = new MSOFTVETDataContext())
                {
                    // Cargar los resultados de la vista en el DataGridView
                    var listaCitas = dc.V_CargarCitas.ToList();

                    dgvTabla1.DataSource = null;
                    dgvTabla1.DataSource = listaCitas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de citas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LIMPIARPANTALLA()
        {
            txtNomCliente.Text = "";
            txtApelCliente.Text = "";
            txtMotivo.Text = "";
            txtHora.Text = "";
            dgvPacientes.DataSource = null;
            dgvPacientes.Rows.Clear();
            txtPaciente.Text = string.Empty;
            cmbTamano.SelectedIndex = -1;
            id_cliente = null;
            id_pacienteSeleccionado = 0;
        }

        public void Desactivar()
        {
            txtMotivo.Enabled = false;
            txtHora.Enabled = false;
            dtPicker1.Enabled = false;
            btnRegistrarCita.Enabled = false;
            txtPaciente.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RegistrarCliente registrarCliente = new RegistrarCliente();
            this.Hide();
            registrarCliente.Show();
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvPacientes.Rows[e.RowIndex];

                // Obtener el ID del paciente seleccionado
                id_pacienteSeleccionado = Convert.ToInt32(selectedRow.Cells["Cod_Paciente"].Value);

                // Llenar el campo de texto del paciente
                txtPaciente.Text = selectedRow.Cells["Nombre"].Value?.ToString();
            }
            else
            {
                LIMPIARPANTALLA();
            }
        }

        public void Activar()
        {
            txtMotivo.Enabled = true;
            txtHora.Enabled = true;
            dtPicker1.Enabled = true;
            btnRegistrarCita.Enabled = true;
        }

        public FormProgramarCita()
        {
            InitializeComponent();
            cmbTamano.Enabled = false;
        }
    }
}