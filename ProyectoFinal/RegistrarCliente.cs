using ProyectoFinal.Clases;
using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class RegistrarCliente : Form
    {
        private ClsCliente cliente;
        ApisPeru ApisPeru = new ApisPeru();
        private void RegistrarCliente_Load(object sender, EventArgs e)
        {

        }

        public RegistrarCliente()
        {
            InitializeComponent();
            CargarClientes();
            ActivarBotones(true, false, false, false, false);
            ActivarCampos(false, false, false, false, false, false, false);
            cliente = new ClsCliente();
        }

        private string ObtenerGeneroSeleccionado()
        {
            switch (cmbGenero.SelectedIndex)
            {
                case 0:
                    return "Masculino";
                case 1:
                    return "Femenino";
                default:
                    return "-----";
            }
        }

        public void CargarClientes()
        {
            dgvClientes.DataSource = ClsCliente.ObtenerListaClientes();
            dgvClientes.Columns[0].Width = 70;
            dgvClientes.Columns[5].Width = 180;
            dgvClientes.Columns[3].Width = 70;
            dgvClientes.Columns[4].Width = 80;
            dgvClientes.Columns[6].Width = 80;
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.DNI = txtDocumento.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Genero = ObtenerGeneroSeleccionado();
                cliente.Correo=txtCorreo.Text;

                if (ClsCliente.ExisteClientePorDNI(cliente.DNI))
                {
                    MessageBox.Show("Ya existe un cliente con el mismo DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cliente.ValidarDatos())
                {
                    cliente.InsertarEnBaseDeDatos();
                    MessageBox.Show("El cliente ha sido registrado correctamente", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActivarBotones(true, false, false, false, false);
                    ActivarCampos(false, false, false, false, false, false, false);
                    Limpiar();
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("Por favor, complete los campos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActivarCampos(bool n, bool a, bool d, bool di, bool t, bool g,bool c)
        {
            txtNombre.Enabled = n;
            txtApellido.Enabled = a;
            txtDocumento.Enabled = d;
            txtDireccion.Enabled = di;
            txtTelefono.Enabled = t;
            cmbGenero.Enabled = g;
            txtCorreo.Enabled = c;
        }
        public void ActivarBotones(bool n, bool r, bool m, bool el, bool c)
        {
            btnNuevo.Enabled = n;
            btnRegistrar.Enabled = r;
            btnModificar.Enabled = m;
            btnEliminar.Enabled = el;
            btnCancelar.Enabled = c;
        }

        public void Limpiar()
        {
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            cmbGenero.SelectedIndex = -1;
            txtCod.Text = "0";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ActivarBotones(true, false, false, false, false);
            ActivarCampos(false, false, false, false, false, false,false);
            Limpiar();
            txtCod.Text = "0";
            txtBdni.Enabled = false;
            btnConsulta.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarCampos(true, true, true, true, true, true,true);
            ActivarBotones(true, true, true, true, true);
            Limpiar();
            txtCod.Text = "0";
            btnConsulta.Enabled = true;
            txtBdni.Enabled = true;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvClientes.Rows.Count)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

                cliente.CodCliente = Convert.ToInt32(fila.Cells["CodCliente"].Value);
                cliente.Nombre = fila.Cells["Nombre"].Value.ToString();
                cliente.Apellido = fila.Cells["Apellido"].Value.ToString();
                cliente.DNI = fila.Cells["DNI"].Value.ToString();
                cliente.Telefono = fila.Cells["Telefono"].Value.ToString();
                cliente.Direccion = fila.Cells["Direccion"].Value.ToString();
                cliente.Genero = fila.Cells["Genero"].Value.ToString();
                cliente.Correo= fila.Cells["Correo"].Value.ToString();

                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtDocumento.Text = cliente.DNI;
                txtTelefono.Text = cliente.Telefono;
                txtDireccion.Text = cliente.Direccion;
                txtCod.Text = cliente.CodCliente.ToString();
                txtCorreo.Text = cliente.Correo;

                int indiceGenero = cmbGenero.FindString(cliente.Genero);
                cmbGenero.SelectedIndex = indiceGenero;
                ActivarCampos(true, true, true, true, true, true, true);
                ActivarBotones(true, true, true, true, true);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.DNI = txtDocumento.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Genero = ObtenerGeneroSeleccionado();
                cliente.Correo= txtCorreo.Text;

                if (cliente.ValidarDatos())
                {
                    cliente.ModificarEnBaseDeDatos();

                    MessageBox.Show("El cliente ha sido modificado correctamente", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActivarBotones(true, false, false, false, false);
                    ActivarCampos(false, false, false, false, false, false, false);
                    Limpiar();
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("Por favor, complete los campos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente.CodCliente == 0 || txtCod.Text == "0")
                {
                    MessageBox.Show("No hay ningún cliente seleccionado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cliente.EliminarEnBaseDeDatos();

                MessageBox.Show("El cliente ha sido eliminado correctamente", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActivarBotones(true, false, false, false, false);
                ActivarCampos(false, false, false, false, false, false, false);
                Limpiar();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Este cliente tiene citas y/o pacientes asociados...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultarCliente();
        }
        private void consultarCliente()
        {
            try
            {
                if (txtBdni.Text.Length == 8)
                {
                    dynamic respuesta = ApisPeru.Get("https://dniruc.apisperu.com/api/v1/dni/" + txtBdni.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImxtdGltYW5hZ0BnbWFpbC5jb20ifQ.udFejq_ZQw4kqP6wfRGX1RaKaksh-lFwcqlM7p9Y1dU");
                    txtNombre.Text = respuesta.nombres.ToString();
                    txtApellido.Text = respuesta.apellidoPaterno.ToString() + " " + respuesta.apellidoMaterno.ToString();
                    txtDocumento.Text = txtBdni.Text;
                    txtBdni.Text = "";
                }        
                else
                {
                    MessageBox.Show("Ingrese un número de documento válido.", "Documento inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese un número de documento válido.", "Documento inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
