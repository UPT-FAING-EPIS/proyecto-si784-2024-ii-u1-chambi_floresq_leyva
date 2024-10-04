using ProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace ProyectoFinal
{
    public partial class FormEditarAgenda : Form
    {
        string motivo, id_cliente, hora, estado, tamaño;
        DateTime fecha;
        int id_cita;

        private void FormEditarAgenda_Load(object sender, EventArgs e)
        {
            rbtnDNI.Checked = true;
            MostrarClientes();
            Desactivar();
        }

        private void rbtnDNI_CheckedChanged(object sender, EventArgs e)
        {
            dgvTabla.DataSource = null;
            Desactivar();
            dgvTabla.Rows.Clear();
            MostrarClientes();
            txtId.Text = "";
        }

        private void rbtnId_CheckedChanged(object sender, EventArgs e)
        {
            dgvTabla.DataSource = null;
            Desactivar();
            dgvTabla.Rows.Clear();
            MostrarClientes();
            txtDNI.Text = "";

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dc = new MSOFTVETDataContext())
                {
                    // Obtén el ID de la cita desde txtCita
                    if (int.TryParse(txtCita.Text, out int idCita))
                    {
                        // Obtén los valores de los controles
                        motivo = txtMotivo.Text;
                        fecha = dtPicker1.Value.Date;
                        hora = txtHora.Text;
                        estado = cmbEstado.SelectedItem.ToString();
                        tamaño = cmbTamano.SelectedItem.ToString();

                        // Llamada al procedimiento almacenado para editar la cita
                        dc.SP_EditarCita(idCita, motivo, fecha, hora, estado, tamaño);

                        MessageBox.Show("Cita editada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarHistorialCitas();
                        cmbTamano.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("ID de cita no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbtnDNI.Checked)
            {
                BuscarClientePorDNI();
            }
            else if (rbtnId.Checked)
            {
                BuscarClientePorID();
            }
        }

        public FormEditarAgenda()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtMotivo.Text = "";
            txtHora.Text = "";
            txtCita.Text = "";
            txtDNI.Text = string.Empty;
            txtId.Text = string.Empty;
            rbtnDNI.Checked = false;
            rbtnId.Checked = false;
        }

        public void Desactivar()
        {
            txtMotivo.Enabled = false;
            txtHora.Enabled = false;
            dtPicker1.Enabled = false;
            btnEditar.Enabled = false;
            cmbEstado.Enabled = false;
            cmbTamano.Enabled = false;
            txtCita.Enabled = false;
            btnBuscarCita.Enabled = false;
        }

        public void Activar()
        {
            txtMotivo.Enabled = true;
            txtHora.Enabled = true;
            dtPicker1.Enabled = true;
            btnEditar.Enabled = true;
            cmbEstado.Enabled = true;
        }

        public void BuscarClientePorDNI()
        {
            MSOFTVETDataContext dc = new MSOFTVETDataContext();

            string dniBusqueda = txtDNI.Text;
            var clienteEncontrado = dc.V_Cliente.FirstOrDefault(c => c.DNI == dniBusqueda);

            if (clienteEncontrado != null)
            {
                id_cliente = clienteEncontrado.Cod_Cliente.ToString();
                MostrarHistorialCitas();
            }
            else
            {
                MessageBox.Show("Cliente no encontrado", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbTamano.Enabled = false;
                txtCita.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dc = new MSOFTVETDataContext())
                {
                    if (int.TryParse(txtCita.Text, out int idCita))
                    {
                        // Buscar la cita por ID
                        var cita = dc.V_CargarCitas.FirstOrDefault(c => c.ID_Cita == idCita);

                        if (cita != null)
                        {
                            // Mostrar los datos en los controles
                            txtMotivo.Text = cita.Motivo;
                            dtPicker1.Value = cita.Fecha;
                            txtHora.Text = cita.Hora;
                            cmbEstado.SelectedItem = cita.Estado;
                            cmbTamano.SelectedItem = cita.Tamaño;
                            Activar();
                            btnBuscar.Enabled = false;
                            cmbTamano.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Cita no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID de cita no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dgvTabla.Rows[e.RowIndex];

                    // Obtén los valores de la fila seleccionada
                    id_cita = Convert.ToInt32(selectedRow.Cells["ID_Cita"].Value);
                    txtCita.Text = id_cita.ToString();
                    txtMotivo.Text = selectedRow.Cells["Motivo"].Value?.ToString();
                    dtPicker1.Value = Convert.ToDateTime(selectedRow.Cells["Fecha"].Value);
                    txtHora.Text = selectedRow.Cells["Hora"].Value?.ToString();
                    cmbEstado.SelectedItem = selectedRow.Cells["Estado"].Value?.ToString();
                    cmbTamano.SelectedItem = selectedRow.Cells["Tamaño"].Value?.ToString();
                    cmbTamano.Enabled = true;
                    Activar();
                }
            }
            catch
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dgvTabla.Rows[e.RowIndex];

                    if (rbtnDNI.Checked)
                    {
                        txtDNI.Text = selectedRow.Cells["DNI"].Value?.ToString();
                    }
                    else if (rbtnId.Checked)
                    {
                        txtId.Text = selectedRow.Cells["Cod_Cliente"].Value?.ToString();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Desactivar();
            btnBuscar.Enabled = true;
            Limpiar();
            rbtnDNI.Checked = true;
        }

        public void BuscarClientePorID()
        {
            MSOFTVETDataContext dc = new MSOFTVETDataContext();

            if (int.TryParse(txtId.Text, out int idBusqueda))
            {
                var clienteEncontrado = dc.V_Cliente.FirstOrDefault(c => c.Cod_Cliente == idBusqueda);

                if (clienteEncontrado != null)
                {
                    id_cliente = clienteEncontrado.Cod_Cliente.ToString();
                    MostrarHistorialCitas();
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbTamano.Enabled = false;
                    txtCita.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Id no valido", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void MostrarHistorialCitas()
        {
            try
            {
                MSOFTVETDataContext dc = new MSOFTVETDataContext();
                var historialCitas = dc.V_CargarCitas
                    .Where(c => c.Cod_Cliente == Convert.ToInt32(id_cliente))
                    .Select(c => new
                    {
                        c.ID_Cita,
                        c.Nombre,
                        c.Apellido,
                        c.Paciente,
                        c.Motivo,
                        c.Tamaño,
                        c.Fecha,
                        c.Hora,
                        c.Estado
                    })
                    .ToList();

                if (historialCitas.Any())
                {
                    dgvTabla.DataSource = historialCitas;
                    dgvTabla.Columns[0].Width = 90;
                    cmbTamano.Enabled = false;
                    txtCita.Enabled=true;
                    btnBuscarCita.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron citas para este cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el historial de citas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarClientes()
        {
            try
            {
                using (var dc = new MSOFTVETDataContext())
                {
                    var todosClientes = dc.V_Cliente.Select(c => new { c.Cod_Cliente, c.Nombre, c.Apellido, c.DNI }).ToList();

                    dgvTabla.DataSource = null;
                    dgvTabla.DataSource = todosClientes;
                    dgvTabla.Columns[0].Width = 90;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar todos los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
