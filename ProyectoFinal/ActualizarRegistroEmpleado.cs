using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class ActualizarRegistroEmpleado : Form
    {
        bool existe = false;
        string codigo, nomemp, apeemp, dniemp, Fechnac, genero, telf, Fechini, cargo, horario;
        int sueldo;
        int ubicacionfila = 0;


        public void Limpieza()
        {
            cmbGenero.SelectedIndex = -1;
            cmbHorario.SelectedIndex = -1;
            txtApellido.Text = "";
            txtCargo.Text = "";
            txtNombre.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtSueldo.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpieza();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            int lineaAEditar = ubicacionfila;

            //llamamos a la funcion recopilarinformacion que contiene los datos ingresados en el form
            RecopilarInformacion();

            string nuevaLinea = codigo + ";" + nomemp + ";" + apeemp + ";" + dniemp + ";" + Fechnac +
                                            ";" + genero + ";" + telf + ";" + Fechini + ";" + cargo +
                                            ";" + horario + ";" + sueldo;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Buscarempleado();
        }

        public ActualizarRegistroEmpleado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void Buscarempleado()
        {
            string busqueda;
            busqueda = txtCodigo.Text;
        }

        private void ActualizarRegistroEmpleado_Load(object sender, EventArgs e)
        {

        }
        public void RecopilarInformacion()
        {

            try
            {
                codigo = txtCodigo.Text;
                nomemp = txtNombre.Text;
                apeemp = txtApellido.Text;
                dniemp = txtDni.Text;
                Fechnac = dtpFechaNacimiento.Value.Date.ToString("dd-MM-yyyy");
                Sexo();
                telf = txtTelefono.Text;
                Fechini = dtpFechaInicio.Value.Date.ToString("dd-MM-yyyy");
                cargo = txtCargo.Text;
                Horario();
                if (txtSueldo.Text != "" && txtSueldo.Text.All(char.IsDigit))
                {
                    sueldo = Convert.ToInt32(txtSueldo.Text);
                }
                else
                {
                    MessageBox.Show("Ingrese un Sueldo Correcto ", "Error");
                }

            }
            catch
            {
                MessageBox.Show("Ingrese datos correctos", "Error");
            }
        }
        private void Sexo()
        {
            if (cmbGenero.SelectedIndex == 0)
            {
                genero = "Masculino";
            }
            else if (cmbGenero.SelectedIndex == 1)
            {
                genero = "Femenino";
            }
            else
            {
                genero = "-----";
            }
        }
        private void Horario()
        {
            if (cmbHorario.SelectedIndex == 0)
            {
                horario = "08:00 am - 05:00 pm";
            }
            else if (cmbHorario.SelectedIndex == 1)
            {
                horario = "08:00 am - 12:00 pm";
            }
            else if (cmbHorario.SelectedIndex == 2)
            {
                horario = "12:00 pm - 05:00 pm";
            }
            else
            {
                horario = "--:-- --:--";
            }
        }
       
    }
}
