using ProyectoFinal.Clases;
using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormCitasProgramadas : Form
    {
        private ClsCita objCita = new ClsCita();

        public FormCitasProgramadas()
        {
            InitializeComponent();
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            MostrarCitas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaSeleccionada = dtPicker1.Value.Date;
                var citasFecha = objCita.ObtenerCitasPorFecha(fechaSeleccionada);
                dgvCitas.DataSource = citasFecha;
                dgvCitas.Columns[0].Width = 90;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las citas para la fecha seleccionada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCitasProgramadas_Load(object sender, EventArgs e)
        {
            var citasPendientes = objCita.Cargar();
            dgvCitas.DataSource = citasPendientes;
            dgvCitas.Columns[0].Width = 90;
        }

        public void MostrarCitas()
        {
            try
            {
                var todasCitas = objCita.ObtenerTodasCitas();
                dgvCitas.DataSource = todasCitas;
                dgvCitas.Columns[0].Width = 90;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las citas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtCancelar.Text, out int idCita))
                {
                    // Llamar al método para cancelar la cita
                    objCita.CancelarCita(idCita);

                    // Mostrar mensaje de éxito y recargar las citas
                    MessageBox.Show("Cita cancelada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarCitas();
                }
                else
                {
                    MessageBox.Show("ID de cita no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cancelar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerEstado_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter el estado seleccionado del ComboBox
                string estadoSeleccionado = cmbEstado.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(estadoSeleccionado))
                {
                    MessageBox.Show("Por favor, selecciona un estado antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Filtrar las citas según el estado seleccionado
                var citasConEstado = objCita.ObtenerCitasPorEstado(estadoSeleccionado);

                // Asignar la lista de citas al DataGridView
                dgvCitas.DataSource = citasConEstado;
                dgvCitas.Columns[0].Width = 90;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las citas con el estado seleccionado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int estadoColumnIndex = dgvCitas.Columns["Estado"].Index;

            // Verificar si la celda actual pertenece a la columna de Estado
            if (e.ColumnIndex == estadoColumnIndex && e.RowIndex >= 0)
            {
                // Obtener el valor de la celda actual
                string estado = dgvCitas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Asignar colores según el estado
                if (estado == "Pendiente")
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Yellow;
                    e.CellStyle.ForeColor = System.Drawing.Color.Black;
                }
                else if (estado == "Cancelado")
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Red;
                    e.CellStyle.ForeColor = System.Drawing.Color.White;
                }
                else if (estado == "Atendido")
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Green;
                    e.CellStyle.ForeColor = System.Drawing.Color.White;
                }
            }
        }
    }
}
