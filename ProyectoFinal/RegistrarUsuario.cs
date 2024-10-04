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
    public partial class RegistrarUsuario : Form
    {
        ClsUsuario objUsuario = new ClsUsuario();

        //Declaramos variables
        string id_empleado;
        string user, pass;
        string categoria;
        public RegistrarUsuario()
        {
            InitializeComponent();
        }
        public void CargarEmpleado()
        {
            //Instanciamos
            MSOFTVETDataContext dc = new MSOFTVETDataContext();

            string dniBusqueda = txtDNI.Text;

            var empleadoEncontrado = dc.V_Empleado.FirstOrDefault(c => c.DNI == dniBusqueda);

            if (!string.IsNullOrEmpty(dniBusqueda) && (dniBusqueda.Length == 8))
            {
                if (empleadoEncontrado != null)
                {
                    txtNombreEmpleado.Text = empleadoEncontrado.Nombre;

                    id_empleado = empleadoEncontrado.Cod_Empleado.ToString();
                    grupoUsuario.Enabled = true;
                }
                else
                {
                    txtNombreEmpleado.Text = "Empleado no encontrado";
                    MessageBox.Show("Empleado no encontrado...\r\nRevise dni introducido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un DNI valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void AgregarUsuario()
        {
            //Igualamos variables a cajas de txt
            objUsuario.usuario = txtUsername.Text;
            objUsuario.contraseña = txtPassword.Text;
            objUsuario.categoria = "empleado";
            objUsuario.idemp = id_empleado;
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                objUsuario.AgregarUsuario();
                limpiar();

            }
            else
            {
                MessageBox.Show("Complete todos los datos");
            }

        }
        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarEmpleado();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AgregarUsuario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Close();         
        }

        public void limpiar()
        {
            txtDNI.Text = "";
            txtNombreEmpleado.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            grupoUsuario.Enabled = false;
        }
    }

}
