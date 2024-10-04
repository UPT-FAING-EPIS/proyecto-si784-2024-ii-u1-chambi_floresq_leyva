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
    public partial class FormAbastecimiento : Form
    {
        //Declaramos variables globales
        string nombre, stock;
        DateTime fecha_cad;


        private static int id = 0;
        private ClsVacuna objVacuna = new ClsVacuna();
        public FormAbastecimiento()
        {
            InitializeComponent();
            CargarComboVacuna();
            ListarVacuna();
            ListarTotalStockVacuna();
            ActivarBotones(true, false, false, false, false);
        }

        public void CargarComboVacuna()
        {
            cmbVacuna.Items.Clear();
            cmbVacuna.Items.Add("Distemper");
            cmbVacuna.Items.Add("Parvovirus");
            cmbVacuna.Items.Add("Traqueobronquitis");
            cmbVacuna.Items.Add("Rinotraqueitis");
            cmbVacuna.Items.Add("Adenovirus");
            
        }

        public void LimpiarVacuna()
        {
            txtStockVacuna.Text = "";
            txtID.Text = "";
            id = 0;
            cmbVacuna.Text = "";
            datePickVacuna.Text = "";
        }
        public void ListarVacuna()
        {
            objVacuna.Listar(dgvVacunas);
        }
        public void ListarTotalStockVacuna()
        {
            objVacuna.ListarTotalStock(dgvTotalStock);
        }


        private void dgvVacunas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtén los valores de la fila seleccionada
            DataGridViewRow fila = dgvVacunas.Rows[e.RowIndex];
            int ID = Convert.ToInt32(fila.Cells["ID_Vacuna"].Value);
            string NombreVacuna = fila.Cells["Nombre_Vacuna"].Value.ToString();
            int StockDisponible = Convert.ToInt32(fila.Cells["Stock"].Value);
            DateTime FechaCaducidad = (DateTime)fila.Cells["FechaCaducidad"].Value;


            // Asigna los valores a los controles del formulario
            txtID.Text = ID.ToString();
            cmbVacuna.Text = NombreVacuna;
            txtStockVacuna.Text = StockDisponible.ToString();
            datePickVacuna.Value = FechaCaducidad;

            ActivarBotones(false, false, true, true, true);
            ActivarCampos();
        }

        public void ActivarBotonessss()
        {
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        public void ActivarBotones(bool n, bool a, bool m, bool e, bool c)
        {
            btnNuevo.Enabled = n;
            btnAgregar.Enabled = a;
            btnModificar.Enabled = m;
            btnEliminar.Enabled = e;
            btnCancelar.Enabled = c;
        }

        public void DesactivarBotones()
        {
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        public void ActivarCampos()
        {
            cmbVacuna.Enabled = true;
            txtStockVacuna.Enabled = true;
        }
        public void DesactivarCampos()
        {
            cmbVacuna.Enabled = true;
            txtStockVacuna.Enabled = true;
        }




        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVacuna();
        }
        public void AgregarVacunas()
        {
            objVacuna.Insertar(cmbVacuna, txtStockVacuna, datePickVacuna);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarVacunas();
            ListarVacuna();
            ListarTotalStockVacuna();
            ActivarBotones(true, true, false, false, true);
            DesactivarCampos();
        }
        public void ModificarVacunas()
        {
            if (txtID.Text != "")
            {
                ClsVacuna objVacuna = new ClsVacuna();

                // Crear un objeto ClsVacuna con los datos del formulario
                ClsVacuna objVacuna2 = new ClsVacuna
                {
                    ID = Convert.ToInt32(txtID.Text),
                    NombreVacuna = cmbVacuna.Text,
                    StockDisponible = Convert.ToInt32(txtStockVacuna.Text),
                    FechaCaducidad = datePickVacuna.Value
                };

                // Llamar al método de actualización
                objVacuna.Actualizar(objVacuna2);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarVacunas();
            ListarVacuna();
            ListarTotalStockVacuna();
            ActivarBotones(true, false, false, false, true);
            ActivarCampos();
        }
        public void EliminarVacunas()
        {
            if (txtID.Text != "")
            {
                ClsVacuna objVacuna = new ClsVacuna();

                // Llamar al método de eliminación
                objVacuna.Eliminar(Convert.ToInt32(txtID.Text));
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarVacunas();
            ListarVacuna();
            ListarTotalStockVacuna();
            ActivarBotones(true, false, false, false, true);
            DesactivarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVacuna();
            ActivarBotones(true, false, false, false, true);
            DesactivarCampos();
        }

        private void FormAbastecimiento_Load(object sender, EventArgs e)
        {

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarBotones(false, true, false, false, true);
            ActivarCampos();
        }

    }
}
