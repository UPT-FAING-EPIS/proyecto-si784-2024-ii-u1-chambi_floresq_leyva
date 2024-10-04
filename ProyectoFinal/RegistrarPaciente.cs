using ProyectoFinal.Clases;
using ProyectoFinal.Modelos;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class RegistrarPaciente : Form
    {
        private ClsPaciente paciente;
        string dni;

        private void btnAgregarProp_Click(object sender, EventArgs e)
        {
            RegistrarCliente registrarCliente = new RegistrarCliente();
            this.Hide();
            registrarCliente.Show();
        }

        private void cmbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecie.SelectedIndex == 0)
            {
                pictpaciente.Image = ProyectoFinal.Properties.Resources.perro;
            }
            else if (cmbEspecie.SelectedIndex == 1)
            {
                pictpaciente.Image = ProyectoFinal.Properties.Resources.gato;
            }
            else
            {
                pictpaciente.Image = ProyectoFinal.Properties.Resources.registrarmascota;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dni = txtBuscar.Text;

            if (!string.IsNullOrEmpty(dni) && dni.Length == 8)
            {
                BuscarClientePorDNI(dni);

                if (int.TryParse(txtCodCliente.Text, out int codCliente))
                {
                    BuscarPacientes(codCliente);
                    DesactivarCampos(true, true, true, true, true);
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número de DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            CargarTodo();
            LIMPIARPANTALLA();
            DesactivarCampos(false, false, false, false, false);
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
                paciente.CodCliente = Convert.ToInt32(txtCodCliente.Text);

                if (paciente.CodCliente > 0 && paciente.ValidarDatos())
                {
                    paciente.InsertarEnBaseDeDatos();

                    MessageBox.Show("Registro exitoso", "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DesactivarCampos(false, false, false, false, false);
                    CargarTodo();
                }
                else
                {
                    MessageBox.Show("Complete los datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LIMPIARPANTALLA();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el paciente...\r\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LIMPIARPANTALLA()
        {
            txtBuscar.Text = "";
            txtNombreMascota.Text = "";
            cmbEspecie.SelectedIndex = -1;
            txtRaza.Text = "";
            cmbGenero.SelectedIndex = -1;
            datePickPaciente.Value = DateTime.Now;
            txtCodCliente.Text = "";
            txtCodCliente.Text = "";
            txtNomCliente.Text = "";
            txtApelCliente.Text = "";
            txtTelCliente.Text = "";
            txtGenCliente.Text = "";
            textDNI.Text = "";
            txtDirec.Text = "";
            paciente = new ClsPaciente();
        }


        public RegistrarPaciente()
        {
            InitializeComponent();
            CargarTodo();
            DesactivarCampos(false, false, false, false, false);
            paciente = new ClsPaciente();
        }

        private void BuscarClientePorDNI(string dni)
        {
            using (var dc = new MSOFTVETDataContext())
            {
                var clienteEncontrado = dc.SP_BuscarCliente(dni).FirstOrDefault();

                if (clienteEncontrado != null)
                {
                    txtCodCliente.Text = clienteEncontrado.Cod_Cliente.ToString();
                    txtNomCliente.Text = clienteEncontrado.Nombre;
                    txtApelCliente.Text = clienteEncontrado.Apellido;
                    txtTelCliente.Text = clienteEncontrado.Telefono;
                    txtGenCliente.Text = clienteEncontrado.Genero;
                    textDNI.Text = clienteEncontrado.DNI;
                    txtDirec.Text = clienteEncontrado.Direccion;
                }
                else
                {
                    MessageBox.Show("Ingrese un dni Valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LIMPIARPANTALLA();
                }
            }
        }

        private void BuscarPacientes(int codCliente)
        {
            try
            {
                using (var dc = new MSOFTVETDataContext())
                {
                    var pacientes = dc.V_Paciente.Where(p => p.Cod_Cliente == codCliente).ToList();

                    dgvPaciente.DataSource = pacientes;                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pacientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTabla()
        {
            if (int.TryParse(txtCodCliente.Text, out int codCliente))
            {
                dgvPaciente.DataSource = ClsPaciente.ObtenerListaPacientes(codCliente);
              
            }
        }
        private void CargarTodo()
        {
            dgvPaciente.DataSource = ClsPaciente.CargarTodo();
            dgvPaciente.Columns[0].Width = 85;
            dgvPaciente.Columns[1].Width = 65;
            dgvPaciente.Columns[2].Width = 65;
            dgvPaciente.Columns[3].Width = 60;
            dgvPaciente.Columns[4].Width = 60;
            dgvPaciente.Columns[6].Width = 55;
        }

        private void DesactivarCampos(bool n, bool r, bool e, bool g, bool f)
        {
            txtNombreMascota.Enabled = n;
            txtRaza.Enabled = r;
            cmbEspecie.Enabled = e;
            cmbGenero.Enabled = g;
            datePickPaciente.Enabled = f;
        }
        private void CargarDatos()
        {
            paciente.Nombre = txtNombreMascota.Text;
            paciente.Especie = cmbEspecie.SelectedItem?.ToString();
            paciente.Raza = txtRaza.Text;
            paciente.Sexo = (cmbGenero.SelectedIndex == 0) ? "Macho" : (cmbGenero.SelectedIndex == 1) ? "Hembra" : "-----";
            paciente.FechaNacimiento = datePickPaciente.Value;
        }

        private void dgvPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPaciente.Rows.Count)
            {
                DataGridViewRow fila = dgvPaciente.Rows[e.RowIndex];

                try
                {
                    paciente.CodPaciente = Convert.ToInt32(fila.Cells["Cod_Paciente"].Value);
                    paciente.Nombre = fila.Cells["Nombre"].Value.ToString();
                    paciente.Especie = fila.Cells["Especie"].Value.ToString();
                    paciente.Raza = fila.Cells["Raza"].Value.ToString();
                    paciente.Sexo = fila.Cells["Sexo"].Value.ToString();
                    paciente.FechaNacimiento = Convert.ToDateTime(fila.Cells["Fecha"].Value);
                    paciente.CodCliente = Convert.ToInt32(fila.Cells["Cod_Cliente"].Value);

                    txtNombreMascota.Text = paciente.Nombre;
                    cmbEspecie.SelectedItem = paciente.Especie;
                    txtRaza.Text = paciente.Raza;
                    string sexo = paciente.Sexo;
                    cmbGenero.SelectedItem = (sexo == "Macho") ? "Macho" : (sexo == "Hembra") ? "Hembra" : "-----";
                    datePickPaciente.Value = paciente.FechaNacimiento;
                    txtCodCliente.Text = paciente.CodCliente.ToString();
                }
                catch 
                {
                    
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
                if (paciente.CodPaciente > 0)
                {
                    paciente.ModificarEnBaseDeDatos();
                    MessageBox.Show("El paciente ha sido modificado correctamente", "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DesactivarCampos(false, false, false, false, false);
                    CargarTodo();
                    LIMPIARPANTALLA();
                }
                else
                {
                    MessageBox.Show("Seleccione un paciente para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el paciente...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (paciente.CodPaciente > 0)
                {
                    paciente.EliminarEnBaseDeDatos();

                    MessageBox.Show("El paciente ha sido eliminado correctamente", "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DesactivarCampos(false, false, false, false, false);
                    CargarTodo();
                    LIMPIARPANTALLA();
                }
                else
                {
                    MessageBox.Show("Seleccione un paciente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"El paciente tiene citas asociadas...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrarPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}

