using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic;
using ProyectoFinal.Modelos;

namespace ProyectoFinal
{
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void toolStripLabel3_ButtonClick(object sender, EventArgs e)
        {

        }

        private void registroDePagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistrarCliente Rcliente = new RegistrarCliente();
            Rcliente.MdiParent = this;
            Rcliente.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != Rcliente)
                {
                    formHijo.Close();
                }
            }
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void programarNuevasCitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProgramarCita ProgramarCita = new FormProgramarCita();
            ProgramarCita.MdiParent = this;
            ProgramarCita.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != ProgramarCita)
                {
                    formHijo.Close();
                }
            }
        }

        private void citasProgramadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCitasProgramadas citasProgramadas = new FormCitasProgramadas();
            citasProgramadas.MdiParent = this;
            citasProgramadas.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != citasProgramadas)
                {
                    formHijo.Close();
                }
            }
        }

        private void programarNuevasCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProgramarCita ProgramarCita = new FormProgramarCita();
            ProgramarCita.MdiParent = this;
            ProgramarCita.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != ProgramarCita)
                {
                    formHijo.Close();
                }
            }
        }

        private void cambiosEnLaAgendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEditarAgenda EditarAgenda = new FormEditarAgenda();
            EditarAgenda.MdiParent = this;
            EditarAgenda.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != EditarAgenda)
                {
                    formHijo.Close();
                }
            }
        }

        private void citasProgramadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCitasProgramadas citasProgramadas = new FormCitasProgramadas();
            citasProgramadas.MdiParent = this;
            citasProgramadas.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != citasProgramadas)
                {
                    formHijo.Close();
                }
            }
        }

        private void cambiosEnLaAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditarAgenda EditarAgenda = new FormEditarAgenda();
            EditarAgenda.MdiParent = this;
            EditarAgenda.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != EditarAgenda)
                {
                    formHijo.Close();
                }
            }
        }

        private void registroDeEmpleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistrarEmpleado registraremp = new RegistrarEmpleado();
            registraremp.MdiParent = this;
            registraremp.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != registraremp)
                {
                    formHijo.Close();
                }
            }
        }

        private void registroDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarEmpleado registraremp = new RegistrarEmpleado();
            registraremp.MdiParent = this;
            registraremp.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != registraremp)
                {
                    formHijo.Close();
                }
            }
        }

        private void menusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistorialClinico Historiales = new FormHistorialClinico();
            Historiales.MdiParent = this;
            Historiales.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != Historiales)
                {
                    formHijo.Close();
                }
            }
        }

        private void registroDeClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistrarCliente registrarcliente = new RegistrarCliente();
            registrarcliente.MdiParent = this;
            registrarcliente.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != registrarcliente)
                {
                    formHijo.Close();
                }
            }
        }

        private void reporteDeIngresosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void reporteDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporte_Clientes Rcliente = new FormReporte_Clientes();
            Rcliente.MdiParent = this;
            Rcliente.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != Rcliente)
                {
                    formHijo.Close();
                }
            }
        }

        private void reporteDeGastosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void reporteDeGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormReporte_Clientes Rcliente = new FormReporte_Clientes();
            Rcliente.MdiParent = this;
            Rcliente.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != Rcliente)
                {
                    formHijo.Close();
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormReporte_Vacunas Rvacunas = new FormReporte_Vacunas();
            Rvacunas.MdiParent = this;
            Rvacunas.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != Rvacunas)
                {
                    formHijo.Close();
                }
            }
        }

        private void reporteDeHistorialClínicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporte_Historial_Clinico RHclínico = new FormReporte_Historial_Clinico();
            RHclínico.MdiParent = this;
            RHclínico.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != RHclínico)
                {
                    formHijo.Close();
                }
            }
        }

        private void reporteDePacientesPorDueñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporte_Paciente_DNI_Cliente RPxdueño = new FormReporte_Paciente_DNI_Cliente();
            RPxdueño.MdiParent = this;
            RPxdueño.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != RPxdueño)
                {
                    formHijo.Close();
                }
            }
        }

        private void reporteEstadísticoDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormReporte_Estadistica_Pacientes REP = new FormReporte_Estadistica_Pacientes();
            REP.MdiParent = this;
            REP.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != REP)
                {
                    formHijo.Close();
                }
            }

        }

        private void accesoAHistoriasClinicasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHistorialClinico Historiales = new FormHistorialClinico();
            Historiales.MdiParent = this;
            Historiales.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != Historiales)
                {
                    formHijo.Close();
                }
            }
        }

        private void registroDeVacunaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarVacunacion Historiales = new FormRegistrarVacunacion();
            Historiales.MdiParent = this;
            Historiales.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != Historiales)
                {
                    formHijo.Close();
                }
            }
        }

        private void registroDePacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {  
            RegistrarPaciente Historiales = new RegistrarPaciente();
            Historiales.MdiParent = this;
            Historiales.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != Historiales)
                {
                    formHijo.Close();
                }
            }
        }

        private void registroDeDesparacitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarDesparasitacion desparasitacion = new FormRegistrarDesparasitacion();
            desparasitacion.MdiParent = this;
            desparasitacion.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != desparasitacion)
                {
                    formHijo.Close();
                }
            }
        }

        private void registroDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecetario recetario= new FrmRecetario();
            recetario.MdiParent = this;
            recetario.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != recetario)
                {
                    formHijo.Close();
                }
            }
        }

        private void abastecimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbastecimiento abastecimiento = new FormAbastecimiento();
            abastecimiento.MdiParent = this;
            abastecimiento.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != abastecimiento)
                {
                    formHijo.Close();
                }
            }
        }
        private void abastecimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAbastecimiento abastecimiento = new FormAbastecimiento();
            abastecimiento.MdiParent = this;
            abastecimiento.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != abastecimiento)
                {
                    formHijo.Close();
                }
            }
        }

        private void registroDePacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarVacunacion vacunas = new FormRegistrarVacunacion();
            vacunas.MdiParent = this;
            vacunas.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != vacunas)
                {
                    formHijo.Close();
                }
            }
        }

        private void accesoAHistoriasClinicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarDesparasitacion desparasitacion = new FormRegistrarDesparasitacion();
            desparasitacion.MdiParent = this;
            desparasitacion.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != desparasitacion)
                {
                    formHijo.Close();
                }
            }
        }

        private void registroDeRecetaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecetario recetario = new FrmRecetario();
            recetario.MdiParent = this;
            recetario.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != recetario)
                {
                    formHijo.Close();
                }
            }
        }

        private void registroDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarCliente Rcliente = new RegistrarCliente();
            Rcliente.MdiParent = this;
            Rcliente.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != Rcliente)
                {
                    formHijo.Close();
                }
            }
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarPaciente paciente = new RegistrarPaciente();
            paciente.MdiParent = this;
            paciente.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != paciente)
                {
                    formHijo.Close();
                }
            }
        }

        private void reporteDeHorariosDelPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporte_Vacunas Rvacunas = new FormReporte_Vacunas();
            Rvacunas.MdiParent = this;
            Rvacunas.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != Rvacunas)
                {
                    formHijo.Close();
                }
            }
        }

        private void reporteHistorialClínicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporte_Historial_Clinico RHclínico = new FormReporte_Historial_Clinico();
            RHclínico.MdiParent = this;
            RHclínico.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != RHclínico)
                {
                    formHijo.Close();
                }
            }
        }

        private void reporteDePacientesPorDueñoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormReporte_Paciente_DNI_Cliente RPxdueño = new FormReporte_Paciente_DNI_Cliente();
            RPxdueño.MdiParent = this;
            RPxdueño.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != RPxdueño)
                {
                    formHijo.Close();
                }
            }
        }

        private void reporteEstadíticoDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporte_Estadistica_Pacientes REP = new FormReporte_Estadistica_Pacientes();
            REP.MdiParent = this;
            REP.Show();
            foreach (Form formHijo in this.MdiChildren)
            {
                if (formHijo != REP)
                {
                    formHijo.Close();
                }
            }
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            foreach (Form formularioHijo in this.MdiChildren)
            {
                formularioHijo.Close();
            }
        }
    }
}
