using ProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoFinal.Clases
{
    public class ClsDesparasitante
    {

        MSOFTVETDataContext dc = new MSOFTVETDataContext();


        //Definimos propiedades
        public int id_disparasitacion { get; set; }
        public string Tipo { get; set; }
        public DateTime fecha { get; set; }
        public string Cod_Paciente { get; set; }

        public string dni { get; set; }
        public string nombre { get; set; }
        public string codCliente { get; set; }
        public string idCliente { get; set; }



        //Crear Metodos


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

        public void Insertar(ComboBox cmbTipo, DateTimePicker datePickDesparasitacion, TextBox txtidPaciente)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(cmbTipo.Text) && !string.IsNullOrWhiteSpace(txtidPaciente.Text))
                {
                    Tipo = cmbTipo.Text;
                    fecha = datePickDesparasitacion.Value;
                    Cod_Paciente = txtidPaciente.Text;

                    using (var dc = new MSOFTVETDataContext())
                    {
                        dc.SP_Agregar_Desparasitacion(Tipo, fecha, Cod_Paciente);
                    }

                    MessageBox.Show("Se ha registrado la desparasitación al Paciente", "Registrar Desparasitación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, complete ambos campos antes de registrar la desparasitación.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar desparasitacion..." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Actualizar(ClsDesparasitante objDesparasitacion)
        {
            try
            {
                using (var dc = new MSOFTVETDataContext())
                {
                    // Llamada al procedimiento almacenado
                    dc.SP_Modificar_Desparasitacion(
                        objDesparasitacion.id_disparasitacion,
                        objDesparasitacion.Tipo,
                        objDesparasitacion.fecha,
                        objDesparasitacion.Cod_Paciente
                    );
                }

                MessageBox.Show("Se ha actualizado la desparasitación correctamente", "Actualizar Desparasitación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al actualizar desparasitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Eliminar(int idDesparasitacion)
        {
            try
            {
                // Llamar al procedimiento almacenado para eliminar la desparasitación
                dc.SP_Eliminar_Desparasitacion(idDesparasitacion);

                MessageBox.Show("Se ha eliminado la desparasitación correctamente", "Eliminar Desparasitación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al eliminar desparasitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListarDesparasitados(DataGridView dgvDesparasitados)
        {
            MSOFTVETDataContext dc = new MSOFTVETDataContext();
            var consulta = dc.V_Desparasitacion.ToList();
            dgvDesparasitados.DataSource = consulta;
            dgvDesparasitados.Columns[0].Width = 80;
        }


        //----------------------------------------


    }
}