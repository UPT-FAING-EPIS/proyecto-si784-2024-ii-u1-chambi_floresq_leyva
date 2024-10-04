namespace ProyectoFinal
{
    partial class FormReporte_Estadistica_Pacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sOFTVETDataSet_Est_Paciente = new ProyectoFinal.SOFTVETDataSet_Est_Paciente();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pacienteTableAdapter = new ProyectoFinal.SOFTVETDataSet_Est_PacienteTableAdapters.PacienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet_Est_Paciente)).BeginInit();
            this.SuspendLayout();
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.sOFTVETDataSet_Est_Paciente;
            // 
            // sOFTVETDataSet_Est_Paciente
            // 
            this.sOFTVETDataSet_Est_Paciente.DataSetName = "SOFTVETDataSet_Est_Paciente";
            this.sOFTVETDataSet_Est_Paciente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtSet_Estad_Paciente";
            reportDataSource1.Value = this.pacienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinal.Reportes.Reporte_Estadistica_Pacientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(975, 600);
            this.reportViewer1.TabIndex = 0;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporte_Estadistica_Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 600);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormReporte_Estadistica_Pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReporte_Estadistica_Pacientes";
            this.Load += new System.EventHandler(this.FormReporte_Estadistica_Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet_Est_Paciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SOFTVETDataSet_Est_Paciente sOFTVETDataSet_Est_Paciente;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private SOFTVETDataSet_Est_PacienteTableAdapters.PacienteTableAdapter pacienteTableAdapter;
    }
}