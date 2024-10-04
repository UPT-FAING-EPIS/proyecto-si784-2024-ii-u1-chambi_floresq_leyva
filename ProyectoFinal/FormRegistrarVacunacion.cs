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
    public partial class FormRegistrarVacunacion : Form
    {
        ClsVacuna objVacunacion = new ClsVacuna();

        //Declaramos variables
        private string dni, nombre;
        private string cod_cliente;
        private string id_cliente;
        private string id_paciente, id_vacuna, nro_dosis;
        DateTime fecha;
        public FormRegistrarVacunacion()
        {
            InitializeComponent();
            Listar();
            ActivarBotones(true, false, false);
            DesactivarCampos();
            
        }
        public void Cargar_Cliente()
        {
            objVacunacion.CargarCliente(txtDNI, txtNombreCliente, txtCod_Cliente);
            if (txtNombreCliente.Text != "Cliente no encontrado")
            {
                groupBoxVacunacion.Enabled = true;
                Cargar_Mascota();
                CargarVacunas();
                Listar();

            }
                
        }

        public void Cargar_Mascota()
        {
            objVacunacion.CargarMascota(dgvPacientes);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cargar_Cliente();
            
            
            
        }
        public void ActivarBotones(bool n, bool a, bool c)
        {
            btnNuevo.Enabled = n;
            btnAgregar.Enabled = a;
            btnCancelar.Enabled = c;
        }
        public void ActivarCampos()
        {
            txtidVacunacion.Enabled = false;
            txtIDPaciente.Enabled = true;
            txtIDVacuna.Enabled = true;
            txtNroDosis.Enabled = true;
            datePickVacunacion.Enabled = true;
        }
        public void DesactivarCampos()
        {
            txtidVacunacion.Enabled = false;
            txtIDPaciente.Enabled = false;
            txtIDVacuna.Enabled = false;
            txtNroDosis.Enabled = false;
            datePickVacunacion.Enabled = false;
        }
        public void Limpiar()
        {
            txtidVacunacion.Text = "";
            txtIDPaciente.Text = "";
            txtIDVacuna.Text = "";
            txtNroDosis.Text = "";
            datePickVacunacion.Text = "";
            txtDNI.Text = "";
            txtNombreCliente.Text = "";
            txtCod_Cliente.Text = "";
            cod_cliente = "0";

        }
        public void AgregarVacunacion()
        {
            objVacunacion.Insertar_Vacunacion(txtIDPaciente, txtIDVacuna, txtNroDosis, datePickVacunacion);
        }

        public void EliminarVacunacion()
        {
            if (txtidVacunacion.Text != "")
            {
                ClsVacuna objVacunante = new ClsVacuna();

                // Llamar al método de eliminación
                objVacunante.Eliminar_Vacunacion(Convert.ToInt32(txtidVacunacion.Text));

                // Otros pasos, como limpiar el formulario, actualizar la lista, etc.
            }
        }
        

        public void Listar()
        {
            objVacunacion.ListarVacunados(dgvVacunados);
            dgvVacunados.Columns[0].Width = 40;
            dgvVacunados.Columns[3].Width = 70;

        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la celda seleccionada es válida y no es el encabezado de la columna
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtén el valor de la celda seleccionada en la columna IDPaciente
                object idPaciente = dgvPacientes.Rows[e.RowIndex].Cells["ID"].Value;

                // Asigna el valor al TextBox
                txtIDPaciente.Text = idPaciente.ToString();
            }
        }
        

        private void dgvVacunados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtén los valores de la fila seleccionada
            ////DataGridViewRow selectedRow = dgvVacunados.Rows[e.RowIndex];
            //////int idDetalle = (int)selectedRow.Cells["Id_Detalle"].Value;
            //////string Cod_Paciente = selectedRow.Cells["Cod_Paciente"].Value.ToString();
            //////string Id_Vacuna = selectedRow.Cells["ID_Vacuna"].Value.ToString();
            //////string NumDosis = selectedRow.Cells["NumDosis"].Value.ToString();
            //////DateTime fecha = (DateTime)selectedRow.Cells["Fecha"].Value;


            ////// Asigna los valores a los controles del formulario
            
            //////txtidVacunacion.Text = idDetalle.ToString();
            //////txtIDPaciente.Text = Cod_Paciente;
            //////txtIDVacuna.Text = Id_Vacuna;
            //////txtNroDosis.Text = NumDosis;    
            //////datePickVacunacion.Value = fecha;

            ////ActivarBotones(false, false, true);
            ////ActivarCampos();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarVacunacion();
            ActivarBotones(true, true, true);
            DesactivarCampos();
            Listar();
            CargarVacunas();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarVacunacion();
            Listar();
            ActivarBotones(true, true, true);
            Limpiar();
            DesactivarCampos();
            CargarVacunas();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            
            ActivarBotones(false, true, true);
            ActivarCampos();
            Listar();
            groupBoxCliente.Enabled = true;
            CargarVacunas();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            ActivarBotones(true, false, true);
            DesactivarCampos();
            dgvPacientes.Columns.Clear();
            dgvTotalStock.Columns.Clear();


        }

        private void dgvTotalStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la celda seleccionada es válida y no es el encabezado de la columna
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtén el valor de la celda seleccionada en la columna IDVacuna
                object idVacuna = dgvTotalStock.Rows[e.RowIndex].Cells["ID_Vacuna"].Value;

                // Asigna el valor al TextBox
                txtIDVacuna.Text = idVacuna.ToString();
            }
        }

        public void CargarVacunas()
        {
            objVacunacion.ListarTotalStock(dgvTotalStock);
            dgvTotalStock.Columns[0].Width = 50;
        }
        private void btnVacunas_Click(object sender, EventArgs e)
        {
            
        }
        
        private void FormRegistrarVacunacion_Load(object sender, EventArgs e)
        {

        }
    }
}
