using ProyectoFinal.Clases;
using ProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormRegistrarDesparasitacion : Form
    {
        ClsDesparasitante objDesparasitante = new ClsDesparasitante();
        public FormRegistrarDesparasitacion()
        {
            InitializeComponent();
            CargarComboTipo();
            Listar();
            ActivarBotones(true, true, false, false, true);

        }
        public void CargarComboTipo()
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Pastilla Antidesparasitante");
            cmbTipo.Items.Add("Inyectable");
        }

        public void Cargar_Cliente()
        {
            objDesparasitante.CargarCliente(txtDNI, txtNombreCliente, txtCod_Cliente);
            if (txtNombreCliente.Text != "Cliente no encontrado")
                GroupBox_Desparasitacion.Enabled = true;
        }

        public void Cargar_Mascota()
        {
            objDesparasitante.CargarMascota(dgvPacientes);
            
        }

        public void AgregarDesparasitante()
        { 
            objDesparasitante.Insertar(cmbTipo, datePickDesparasitacion, txtidPaciente);
        }

        public void ModificarDesparasitante()
        {
            if (txtid_desparasitacion.Text != "")
            {
                ClsDesparasitante objDesparasitante = new ClsDesparasitante();

                // Crear un objeto ClsDesparasitante con los datos del formulario
                ClsDesparasitante objDesparasitacion = new ClsDesparasitante
                {
                    id_disparasitacion = Convert.ToInt32(txtid_desparasitacion.Text),
                    Tipo = cmbTipo.Text,
                    fecha = datePickDesparasitacion.Value,
                    Cod_Paciente = txtidPaciente.Text
                };

                // Llamar al método de actualización
                objDesparasitante.Actualizar(objDesparasitacion);
            }
        }
        public void EliminarDesparasitante()
        {
            if (txtid_desparasitacion.Text != "")
            {
                ClsDesparasitante objDesparasitante = new ClsDesparasitante();

                // Llamar al método de eliminación
                objDesparasitante.Eliminar(Convert.ToInt32(txtid_desparasitacion.Text));

                // Otros pasos, como limpiar el formulario, actualizar la lista, etc.
            }
        }
        private void FormRegistrarDesparasitacion_Load(object sender, EventArgs e)
        {

        }
        public void Listar()
        {
            objDesparasitante.ListarDesparasitados(dgvDesparasitados);
            dgvDesparasitados.Columns[0].Width = 40;
            dgvDesparasitados.Columns[2].Width = 80;
        }
        public void ActivarBotones(bool n, bool a, bool m, bool e, bool c)
        {
            btnNuevo.Enabled = n;
            btnAgregar.Enabled = a;
            btnModificar.Enabled = m;
            btnEliminar.Enabled = e;
            btnCancelar.Enabled = c;
        }
        public void ActivarCampos()
        {
            txtid_desparasitacion.Enabled = false;
            cmbTipo.Enabled = true;
            datePickDesparasitacion.Enabled = true;
            txtidPaciente.Enabled = true;
        }
        public void DesactivarCampos()
        {
            txtid_desparasitacion.Enabled = false;
            cmbTipo.Enabled = true;
            datePickDesparasitacion.Enabled = true;
            txtidPaciente.Enabled = false;
        }
        public void Limpiar()
        {
            txtid_desparasitacion.Text = "";
            cmbTipo.Text = "";
            datePickDesparasitacion.Text = "";
            txtidPaciente.Text = "";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarDesparasitante();
            Listar();
            Limpiar();
            ActivarBotones(true, true, false, false, true);
            DesactivarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cargar_Cliente();
            Cargar_Mascota();
            
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la celda seleccionada es válida y no es el encabezado de la columna
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtén el valor de la celda seleccionada en la columna IDPaciente
                object idPaciente = dgvPacientes.Rows[e.RowIndex].Cells["ID"].Value;

                // Asigna el valor al TextBox
                txtidPaciente.Text = idPaciente.ToString();
            }
            
        }

        private void dgvDesparasitados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtén los valores de la fila seleccionada
            DataGridViewRow selectedRow = dgvDesparasitados.Rows[e.RowIndex];
            int idDesparasitacion = (int)selectedRow.Cells["id"].Value;
            string tipo = selectedRow.Cells["tipo"].Value.ToString();
            DateTime fecha = (DateTime)selectedRow.Cells["fecha"].Value;
            string codPaciente = selectedRow.Cells["cod_Paciente"].Value.ToString();

            // Asigna los valores a los controles del formulario
            txtid_desparasitacion.Text = idDesparasitacion.ToString();
            cmbTipo.Text = tipo;
            datePickDesparasitacion.Value = fecha;
            txtidPaciente.Text = codPaciente;

            ActivarBotones(false, false, true, true, true);
            ActivarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarDesparasitante();
            Listar();
            ActivarBotones(true, false, false, false, true);
            ActivarCampos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            ActivarBotones(false, true, false, false, true);
            ActivarCampos();
            Listar();
            Cargar_Cliente();
            Cargar_Mascota();
            GroupBox_Desparasitacion.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            ActivarBotones(true, false, false, false, true);
            DesactivarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarDesparasitante();
            Listar();
            ActivarBotones(true, false, false, false, true);
            DesactivarCampos();
        }
    }

}

