using ProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Clases
{
    public class ClsVacuna
    {
        MSOFTVETDataContext dc = new MSOFTVETDataContext();

        //-----------------------------------------------------

        //Definimos propiedades
        //detalle
        public int id_Detalle { get; set; }
        public string Cod_Paciente { get; set; }
        public string Id_Vacuna { get; set; }
        public string num_dosis { get; set; }
        public DateTime fecha { get; set; }

        //cliente
        public string dni { get; set; }
        public string nombre { get; set; }
        public string codCliente { get; set; }
        public string idCliente { get; set; }

        //vacuna
        public int ID { get; set; }
        public string NombreVacuna { get; set; }
        public int StockDisponible { get; set; }
        public DateTime FechaCaducidad { get; set; }


        //Crear Metodos Vacuna Abastecimiento
        //Listar
        public void Listar(DataGridView dgvVacunados)
        {
            MSOFTVETDataContext dc = new MSOFTVETDataContext();
            var consulta = dc.Vacuna.ToList();
            dgvVacunados.DataSource = consulta;

        }

        public void ListarTotalStock(DataGridView dgvTotalStock)
        {
            try
            {
                var consulta = dc.SP_TotalStockVacuna().ToList();

                if (consulta.Any())
                {
                    dgvTotalStock.DataSource = consulta;
                    dgvTotalStock.Columns[0].HeaderText = "ID";
                    dgvTotalStock.Columns[1].HeaderText = "Nombre";
                    dgvTotalStock.Columns[2].HeaderText = "Total Stock";
                }
                else
                {
                    MessageBox.Show("No hay datos para mostrar.", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el total de stock por vacuna: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Insertar(ComboBox cmbVacuna, TextBox txtStockVacuna, DateTimePicker datePickVacuna)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(cmbVacuna.Text) && !string.IsNullOrWhiteSpace(txtStockVacuna.Text))
                {
                    //Igualamos las variables a las columnas de la tabla
                    NombreVacuna = cmbVacuna.Text;
                    StockDisponible = Convert.ToInt32(txtStockVacuna.Text);
                    FechaCaducidad = datePickVacuna.Value;

                    using (var dc = new MSOFTVETDataContext())
                    {
                        dc.SP_Agregar_Abast_Vacunas(NombreVacuna, StockDisponible, FechaCaducidad);
                    }

                    MessageBox.Show("Se ha registrado la vacuna al Abastecimiento", "Agregar Vacunas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, complete ambos campos antes de agregar las vacunas.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar las vacunas..." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Actualizar(ClsVacuna objVacunas)
        {
            try
            {
                using (var dc = new MSOFTVETDataContext())
                {
                    // Llamada al procedimiento almacenado
                    dc.SP_Modificar_Abast_Vacunas(
                        objVacunas.ID,
                        objVacunas.NombreVacuna,
                        objVacunas.StockDisponible,
                        objVacunas.FechaCaducidad
                    );
                }

                MessageBox.Show("Se ha actualizado la vacuna correctamente", "Actualizar Vacunas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al actualizar vacunas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Eliminar(int id)
        {
            try
            {
                // Llamar al procedimiento almacenado para eliminar la desparasitación
                dc.SP_Eliminar_Abast_Vacunas(id);

                MessageBox.Show("Se ha eliminado la vacuna correctamente", "Eliminar Vacunas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al eliminar vacunas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------
        // Método para cargar un cliente
        public void CargarCliente(TextBox txtDNI, TextBox txtNombreCliente, TextBox txtCodCliente)
        {
            MSOFTVETDataContext dc = new MSOFTVETDataContext();
            string dniBusqueda = txtDNI.Text;

            var clienteEncontrado = dc.V_Cliente.FirstOrDefault(c => c.DNI == dniBusqueda);

            if (clienteEncontrado != null)
            {
                txtNombreCliente.Text = clienteEncontrado.Nombre;
                txtCodCliente.Text = clienteEncontrado.Cod_Cliente.ToString();
                idCliente = clienteEncontrado.Cod_Cliente.ToString();
            }
            else
            {
                txtNombreCliente.Text = "Cliente no encontrado";
                idCliente = "";
            }
        }

        // Método para cargar las mascotas del cliente
        public void CargarMascota(DataGridView dgvPacientes)
        {
            MSOFTVETDataContext dc = new MSOFTVETDataContext();
            string codigoClienteBusqueda = idCliente;

            //Mostrar todas las columnas
            //var pacientes = dc.V_Paciente.Where(p => p.Cod_Cliente.ToString() == codigoClienteBusqueda).ToList();
            //Mostrar solo 2:
            var pacientes = dc.V_Paciente
               .Where(p => p.Cod_Cliente.ToString() == codigoClienteBusqueda)
               .Select(p => new
               {
                   ID = p.Cod_Paciente, // Alias para la columna IDPaciente
                   p.Nombre // Ajusta esto para reflejar la propiedad real que quieres mostrar
               })
               .ToList();
            if (pacientes.Count > 0)
            {
                dgvPacientes.DataSource = pacientes;
                dgvPacientes.Columns[0].Width = 40;

            }
            else
            {
                MessageBox.Show("No se encontraron pacientes vinculados al cliente.\r\nFavor de ingresar otro DNI", "Registro Vacunas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ReducirStock(int cantidad)
        {
            try
            {
                using (var dc = new MSOFTVETDataContext())
                {
                    // Llamar al procedimiento almacenado para reducir el stock
                    dc.SP_ReducirStockVacuna(ID, cantidad);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al reducir el stock de la vacuna: " + ex.Message);
            }
        }
        public void Insertar_Vacunacion(TextBox txtIDPaciente, TextBox txtIDVacuna, TextBox txtNroDosis, DateTimePicker datePickVacunacion)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtIDPaciente.Text) && !string.IsNullOrWhiteSpace(txtIDVacuna.Text))
                {
                    Cod_Paciente = txtIDPaciente.Text;
                    Id_Vacuna = txtIDVacuna.Text;
                    num_dosis = txtNroDosis.Text;
                    fecha = datePickVacunacion.Value;

                    using (var dc = new MSOFTVETDataContext())
                    {
                        // Verificar si hay suficiente stock antes de realizar la vacunación
                        var vacuna = dc.Vacuna.FirstOrDefault(v => v.ID_Vacuna == Convert.ToInt32(Id_Vacuna));
                        if (vacuna != null && vacuna.Stock > 0)
                        {
                            // Llamar al procedimiento almacenado para agregar la vacunación
                            dc.SP_Agregar_Vacunacion(Cod_Paciente, Id_Vacuna, num_dosis, fecha);

                            // Llamar al procedimiento almacenado para reducir el stock de la vacuna
                            dc.SP_ReducirStockVacuna(Convert.ToInt32(Id_Vacuna), 1);

                            MessageBox.Show("Se ha registrado la vacunación al Paciente y se ha actualizado el stock de la vacuna.", "Registrar Vacunación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No hay suficiente stock de la vacuna seleccionada.", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, complete ambos campos antes de registrar la Vacunación.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar Vacunación..." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Eliminar_Vacunacion(int id_Detalle)
        {
            try
            {
                using (var dc = new MSOFTVETDataContext())
                {
                    // Obtener la información de la vacunación antes de eliminarla
                    var vacunacion = dc.V_Vacunacion.FirstOrDefault(d => d.Id_Detalle == id_Detalle);

                    if (vacunacion != null)
                    {
                        // Llamar al procedimiento almacenado para eliminar la vacunación
                        dc.SP_Eliminar_Vacunacion(id_Detalle);

                        // Llamar al procedimiento almacenado para incrementar el stock de la vacuna
                        dc.SP_EliminarStockVacuna(vacunacion.ID_Vacuna, Convert.ToInt32(vacunacion.NumDosis));

                        MessageBox.Show("Se ha eliminado la Vacunación correctamente y se ha incrementado el stock de la vacuna.", "Eliminar Vacunación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la Vacunación para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al eliminar Vacunación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListarVacunados(DataGridView dgvVacunados)
        {
            MSOFTVETDataContext dc = new MSOFTVETDataContext();
            var consulta = dc.V_DETALLE_PACIENTE_VACUNA.ToList();
            dgvVacunados.DataSource = consulta;
            dgvVacunados.Columns[0].Width = 80;
        }


        //----------------------------------------


    }
}

