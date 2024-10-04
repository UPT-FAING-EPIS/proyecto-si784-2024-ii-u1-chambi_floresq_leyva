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

namespace ProyectoFinal
{
    public partial class FormAdmin : Form
    {
        bool existe;
        string usuario, password;
        string codunico;
        string texto;
        String[] campo = new string[1];
        
        
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            GenerarCaptch();
        }
        public void GenerarCaptch()
        {
            Random rnd = new Random();
            string[] codigo = { "4Thz2", "D5E6f7", "890Xyz", "120Xyz", "G2H9j8" };
            int indiceAleatorio=rnd.Next(0, codigo.Length);
            string captchaAleatorio = codigo[indiceAleatorio];
            txtcaptcha.Text= captchaAleatorio;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            existe = false;
            usuario = txtRegUsuario.Text;
            password = txtRegPassword.Text;
            codunico = txtCodUnico.Text;
            string captcha = txtcaptcha.Text;
        }
    }
}
