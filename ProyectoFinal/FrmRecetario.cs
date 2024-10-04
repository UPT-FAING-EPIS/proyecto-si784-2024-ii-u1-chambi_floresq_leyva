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
    public partial class FrmRecetario : Form
    {
        private int codcliente;

        public FrmRecetario()
        {
            InitializeComponent();
            ActivarCampos(true, false, false, false, false, false);
            ActivarBotones(true,true,false,false,false,false);
            CargarRecetario();
        }
        public void ActivarCampos(bool d, bool n,bool a, bool i, bool f, bool des)
        {
            txtDNI.Enabled = d;
            txtNombre.Enabled = n;
            txtApellido.Enabled = a;
            txtId.Enabled = i;
            dtPicker1.Enabled = f;
            txtDescripcion.Enabled = des;
        }
        public void ActivarBotones(bool b, bool c, bool ed, bool el, bool i, bool r)
        {
            btnBuscar.Enabled = b;
            btnCancelar.Enabled = c;
            //btnEditar.Enabled = ed;
            //btnEliminar.Enabled = el;
            btnIniciar.Enabled = i;
            btnRegistrar.Enabled = r;
        }

        public void LimpiarCampos()
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtId.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MSOFTVETDataContext dc = new MSOFTVETDataContext();

            string dniBusqueda = txtDNI.Text;

            var clienteEncontrado = dc.V_Cliente.FirstOrDefault(c => c.DNI == dniBusqueda);

            if (clienteEncontrado != null)
            {
                codcliente = clienteEncontrado.Cod_Cliente;

                // Verificar si el cliente tiene algún paciente registrado
                var pacienteRegistrado = dc.V_Paciente.Any(p => p.Cod_Cliente == codcliente);

                if (pacienteRegistrado)
                {
                    txtNombre.Text = clienteEncontrado.Nombre;
                    txtApellido.Text = clienteEncontrado.Apellido;
                    ActivarCampos(false, false, false, true, false, false);
                    ActivarBotones(false, true, false, false, true, false);
                    CargarTablaPacientes();
                }
                else
                {
                    if (MessageBox.Show("No se ha encontrado pacientes registrados. ¿Desea registrar uno?", "Paciente", MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
                    {

                    }
                    else
                    {

                    }
                }
            }
            else
            {
                if (MessageBox.Show("Cliente no registrado. ¿Desea registrar uno?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    RegistrarCliente registrarCliente = new RegistrarCliente();
                    this.Hide();
                    registrarCliente.Show();
                }
                else
                {

                }
            }
        }

        private void CargarTablaPacientes()
        {
            MSOFTVETDataContext dc = new MSOFTVETDataContext();

            var pacienteEncontrado = dc.V_Paciente.Where(c => c.Cod_Cliente == codcliente).Select(p => new{Cod = p.Cod_Paciente,p.Nombre, p.Especie}).ToList();

            if (pacienteEncontrado != null)
            {
                dgvPaciente.DataSource = pacienteEncontrado;
                dgvPaciente.Columns[0].Width = 40;
                dgvPaciente.Columns[1].Width = 100;
                dgvPaciente.Columns[2].Width = 100;
                ActivarCampos(false, false, false, true, false, false);

            }
            else
            {
                MessageBox.Show("Pacientes no registrados ...", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarPacientes()
        {
            MSOFTVETDataContext dc = new MSOFTVETDataContext();

            if (int.TryParse(txtId.Text, out int bpaciente))
            {
                var pacienteEncontrado = dc.V_Paciente
                    .Where(c => c.Cod_Cliente == codcliente)
                    .FirstOrDefault(p => p.Cod_Paciente == bpaciente);

                if (pacienteEncontrado != null)
                {
                    ActivarCampos(false, false, false, false, true, true);
                    ActivarBotones(false, true, false, false, false, true);
                }
                else
                {
                    MessageBox.Show("Paciente no registrado ...", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID de paciente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrarRecetacion()
        {
            MSOFTVETDataContext dc = new MSOFTVETDataContext();
            int codPaciente = Convert.ToInt32(txtId.Text);

            // Verificar si txtDescripcion no está vacío
            if (!string.IsNullOrEmpty(txtDescripcion.Text))
            {
                try
                {
                    dc.SP_Agregar_Recetacion(txtDescripcion.Text, dtPicker1.Value, codPaciente);
                    MessageBox.Show("Datos registrados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    ActivarBotones(true, true, false, false, false, false);
                    ActivarCampos(true, false, false, false, false, false);
                    dgvPaciente.DataSource = null;
                    dgvPaciente.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar los datos. Detalles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La descripción no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            VerificarPacientes();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarRecetacion();
            CargarRecetario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActivarCampos(true, false, false, false, false, false);
            ActivarBotones(true, true, false, false, false, false);
            dgvPaciente.DataSource = null;
            dgvPaciente.Rows.Clear();
            LimpiarCampos();
        }

        public void CargarRecetario()
        {
            using (var dc = new MSOFTVETDataContext())
            {
                var consulta = (from x in dc.V_Recetaciones
                                select new
                                {
                                    ID = x.id,
                                    Descripcion = x.Descripcion_Receta,
                                    Fecha = x.Fecha_Receta,
                                    IdPaciente = x.cod_paciente
                                }).ToList();
                dgvReceta.DataSource = consulta;
                dgvReceta.Columns[0].Width = 26;
                dgvReceta.Columns[1].Width = 300;
                dgvReceta.Columns[2].Width = 100;
                dgvReceta.Columns[3].Width = 100;
            }
        }

        private void dgvPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPaciente.Rows.Count)
            {
                DataGridViewRow fila = dgvPaciente.Rows[e.RowIndex];

                // Obtiene el valor de la celda en la columna 0 (suponiendo que Cod_Paciente está en la primera columna)
                string codPaciente = fila.Cells[0].Value.ToString();

                // Asigna el valor al textbox
                txtId.Text = codPaciente;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcionOrden = cmbOrdenar.SelectedItem.ToString();

            switch (opcionOrden)
            {
                case "Ordenado":
                    CargarRecetario();
                    break;
                case "Ascendente":
                    OrdenarRecetario(true);
                    break;
                case "Descendente":
                    OrdenarRecetario(false);
                    break;
            }
        }

        private void OrdenarRecetario(bool ascendente)
        {
            using (var dc = new MSOFTVETDataContext())
            {
                var consulta = (from x in dc.V_Recetaciones
                                orderby x.Fecha_Receta ascending
                                select new
                                {
                                    ID = x.id,
                                    Descripcion = x.Descripcion_Receta,
                                    Fecha = x.Fecha_Receta,
                                    IdPaciente = x.cod_paciente
                                }).ToList();

                if (!ascendente)
                {
                    consulta.Reverse();
                }
                dgvReceta.DataSource = null;
                dgvReceta.DataSource = consulta;
                dgvReceta.Columns[0].Width = 26;
                dgvReceta.Columns[1].Width = 300;
                dgvReceta.Columns[2].Width = 100;
                dgvReceta.Columns[3].Width = 100;
            }
        }

        private void FrmRecetario_Load(object sender, EventArgs e)
        {
            cmbOrdenar.SelectedIndex = 0;
        }
    }
}
