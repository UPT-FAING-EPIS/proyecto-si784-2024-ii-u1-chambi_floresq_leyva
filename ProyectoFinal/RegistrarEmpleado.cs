using ProyectoFinal.Clases;
using ProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class RegistrarEmpleado : Form
    {
        private ClsEmpleado empleado;
        ApisPeru ApisPeru = new ApisPeru();
        public RegistrarEmpleado()
        {
            InitializeComponent();
            ActivarBotones(true, false, false, false, false);
            ActivarCampos(false, false, false, false, false, false, false, false);
            Limpieza();
            CargarEmpleado();
            empleado = new ClsEmpleado();
        }

        public void btnLimpiar_Click(object sender, EventArgs e)
        {
            ActivarBotones(true, false, false, false, false);
            ActivarCampos(false, false, false, false, false, false, false, false);
            Limpieza();
            CargarEmpleado();
            empleado = new ClsEmpleado();

        }
        public void Limpieza()
        {
            cmbGenero.SelectedIndex = -1;
            cmbHorario.SelectedIndex = -1;
            txtApellido.Text = "";
            txtCargo.Text = "";
            txtNombre.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtSueldo.Text = string.Empty;
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEmpleado();
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvEmpleados.Rows.Count)
            {
                DataGridViewRow fila = dgvEmpleados.Rows[e.RowIndex];

                empleado.CodEmpleado = Convert.ToInt32(fila.Cells["CodEmpleado"].Value);
                empleado.Nombre = fila.Cells["Nombre"].Value.ToString();
                empleado.Apellido = fila.Cells["Apellido"].Value.ToString();
                empleado.DNI = fila.Cells["DNI"].Value.ToString();
                empleado.FechaNacimiento = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value);
                empleado.Genero = fila.Cells["Genero"].Value.ToString();
                empleado.Telefono = fila.Cells["Telefono"].Value.ToString();
                empleado.FechaInicio = Convert.ToDateTime(fila.Cells["FechaInicio"].Value);
                empleado.Cargo = fila.Cells["Cargo"].Value.ToString();
                empleado.Sueldo = Convert.ToInt32(fila.Cells["Sueldo"].Value);
                empleado.Horario = fila.Cells["Horario"].Value.ToString();

                txtNombre.Text = empleado.Nombre;
                txtApellido.Text = empleado.Apellido;
                txtDNI.Text = empleado.DNI;
                dtpFechaNacimiento.Value = empleado.FechaNacimiento;
                txtTelefono.Text = empleado.Telefono;
                dtpFechaInicio.Value = empleado.FechaInicio;
                txtCargo.Text = empleado.Cargo;
                txtSueldo.Text = empleado.Sueldo.ToString();
                string horario = empleado.Horario;
                int indiceHorario = cmbHorario.FindString(horario);
                cmbHorario.SelectedIndex = indiceHorario;
                string genero = empleado.Genero;
                int indiceGenero = cmbGenero.FindString(genero);
                cmbGenero.SelectedIndex = indiceGenero;
                ActivarCampos(true, true, true, true, true, true, true, true);
                ActivarBotones(true, true, true, true, true);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerDatos();
                if (empleado.ValidarDatos())
                {
                    empleado.ModificarEnBaseDeDatos();

                    MessageBox.Show("El empleado ha sido modificado correctamente", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActivarBotones(true, false, false, false, false);
                    ActivarCampos(false, false, false, false, false, false, false, false);
                    Limpieza();
                    CargarEmpleado();
                }
                else
                {
                    MessageBox.Show("Por favor, complete los campos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (empleado.CodEmpleado > 0)
                {
                    empleado.EliminarEnBaseDeDatos();

                    MessageBox.Show("El empleado ha sido eliminado correctamente", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActivarBotones(true, false, false, false, false);
                    ActivarCampos(false, false, false, false, false, false, false, false);
                    Limpieza();
                    CargarEmpleado();
                }
                else
                {
                    MessageBox.Show("Seleccione un empleado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el empleado, tiene una referencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarCampos(true, true, true, true, true, true, true, true);
            ActivarBotones(true, true, true, true, true);
            Limpieza();
            empleado = new ClsEmpleado();
            gruporeniec.Enabled = true;
        }

        public void ActivarCampos(bool g, bool h, bool a, bool c, bool n, bool d, bool t, bool s)
        {
            cmbGenero.Enabled = g;
            cmbHorario.Enabled = h;
            txtApellido.Enabled = a;
            txtCargo.Enabled = c;
            txtNombre.Enabled = n;
            txtDNI.Enabled = d;
            txtTelefono.Enabled = t;
            txtSueldo.Enabled = s;
            dtpFechaInicio.Enabled = t;
            dtpFechaNacimiento.Enabled = t;
        }

        public void ActivarBotones(bool n, bool r, bool m, bool el, bool c)
        {
            btnNuevo.Enabled = n;
            btnAgregar.Enabled = r;
            btnModificar.Enabled = m;
            btnEliminar.Enabled = el;
            btnCancelar.Enabled = c;
        }

        public void CargarEmpleado()
        {
            dgvEmpleados.DataSource = ClsEmpleado.ObtenerListaEmpleados();
            dgvEmpleados.Columns[0].Width = 80;
            dgvEmpleados.Columns[3].Width = 70;
            dgvEmpleados.Columns[5].Width = 70;
            dgvEmpleados.Columns[6].Width = 70;
            dgvEmpleados.Columns[7].Width = 70;
            dgvEmpleados.Columns[8].Width = 70;
            dgvEmpleados.Columns[9].Width = 70;
            dgvEmpleados.Columns[10].Width = 70;
        }


    public void AgregarEmpleado()
        {
            try
            {
                ObtenerDatos();

                if (ClsEmpleado.ExisteEmpleadoPorDNI(empleado.DNI))
                {
                    MessageBox.Show("Ya existe un empleado con el mismo DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (empleado.ValidarDatos())
                {
                    empleado.InsertarEnBaseDeDatos();
                    MessageBox.Show("Se ha agregado correctamente...", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActivarBotones(true, false, false, false, false);
                    ActivarCampos(false, false, false, false, false, false, false, false);
                    Limpieza();
                    CargarEmpleado();
                }
                else
                {
                    MessageBox.Show("Por favor, complete los campos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al registrar Empleado...\r\nComplete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObtenerDatos()
        {
            empleado.Nombre = txtNombre.Text;
            empleado.Apellido = txtApellido.Text;
            empleado.DNI = txtDNI.Text;
            empleado.FechaNacimiento = dtpFechaNacimiento.Value;
            empleado.Genero = ObtenerGenero();
            empleado.Telefono = txtTelefono.Text;
            empleado.FechaInicio = dtpFechaInicio.Value;
            empleado.Cargo = txtCargo.Text;
            empleado.Sueldo = Convert.ToInt32(txtSueldo.Text);
            empleado.Horario = ObtenerHorario();
        }

        private string ObtenerGenero()
        {
            if (cmbGenero.SelectedIndex == 0)
            {
                return "Masculino";
            }
            else if (cmbGenero.SelectedIndex == 1)
            {
                return "Femenino";
            }
            else
            {
                return "-----";
            }
        }

        private string ObtenerHorario()
        {
            if (cmbHorario.SelectedIndex == 0)
            {
                return "08:00 - 17:00";
            }
            else if (cmbHorario.SelectedIndex == 1)
            {
                return "08:00 - 12:00";
            }
            else if (cmbHorario.SelectedIndex == 2)
            {
                return "12:00 - 17:00";
            }
            else
            {
                return "--:-- --:--";
            }
        }

        private void RegistrarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarEmpleado();
        }
        private void consultarEmpleado()
        {
            try
            {
                if (txtBdni.Text.Length == 8)
                {
                    dynamic respuesta = ApisPeru.Get("https://dniruc.apisperu.com/api/v1/dni/" + txtBdni.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImxtdGltYW5hZ0BnbWFpbC5jb20ifQ.udFejq_ZQw4kqP6wfRGX1RaKaksh-lFwcqlM7p9Y1dU");
                    txtNombre.Text = respuesta.nombres.ToString();
                    txtApellido.Text = respuesta.apellidoPaterno.ToString() + " " + respuesta.apellidoMaterno.ToString();
                    txtDNI.Text = txtBdni.Text;
                    txtBdni.Text = "";
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
    }
}
