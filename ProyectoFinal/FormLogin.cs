using Microsoft.VisualBasic;
using ProyectoFinal.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormLogin : Form
    {
        bool existe;
        string usuario, contraseña, nombre, categoria;

        private void label9_Click(object sender, EventArgs e)
        {
            string usuario, clave;

            usuario = Interaction.InputBox("Ingrese usuario", "Usuario");
            clave = Interaction.InputBox("Ingrese clave", "Clave");

            if (ValidarUsuario(usuario, clave))
            {
                if (categoria.Equals("A"))
                {

                    RegistrarUsuario admin = new RegistrarUsuario();
                    this.Hide();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Error al ingresar, El usuario ingresado necesita permisos de Administrador");
                }
            }
            else
            {
                MessageBox.Show("Usuario o Clave Incorrectos", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        private void AbrirWeb(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la página: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AbrirWeb("https://www.facebook.com/61554367919909");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AbrirWeb("https://www.instagram.com/jkdev38");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AbrirWeb("mailto:jkdev38@gmail.com");
        }

        public FormLogin()
        {
            InitializeComponent();
        }
        private bool ValidarUsuario(string usuario, string password)
        {
            MSOFTVETDataContext dc = new MSOFTVETDataContext();

            try
            {
                var consulta = dc.SP_Autenticar(usuario, password).SingleOrDefault();

                if (consulta != null)
                {
                    categoria = consulta.Categoria;
                    nombre = consulta.NOMBRE;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al autenticar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text;
            contraseña = txtPassword.Text;
            if (ValidarUsuario(usuario, contraseña))
            {
                MessageBox.Show("Bienvenido al sistema Sofvet: " + "\n\r" + nombre, "Login de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MDIPrincipal MDI = new MDIPrincipal();
                this.Hide();
                MDI.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o Password incorrectos... ", "Login de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
