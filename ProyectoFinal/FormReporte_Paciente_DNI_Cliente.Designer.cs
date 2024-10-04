namespace ProyectoFinal
{
    partial class FormReporte_Paciente_DNI_Cliente
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
            this.sPPacientexClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sOFTVETDataSet_PacientesxDNI = new ProyectoFinal.SOFTVETDataSet_PacientesxDNI();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Generar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sPPacientexClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_PacientexClienteTableAdapter = new ProyectoFinal.SOFTVETDataSet_PacientesxDNITableAdapters.SP_PacientexClienteTableAdapter();
            this.sOFTVETDataSet_PacientexPaciente2 = new ProyectoFinal.SOFTVETDataSet_PacientexPaciente2();
            this.sOFTVETDataSetPacientexPaciente2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sOFTVETDataSetPacientesxDNIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GrupoEnvio = new System.Windows.Forms.GroupBox();
            this.lblFiles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sPPacientexClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet_PacientesxDNI)).BeginInit();
            this.Generar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPPacientexClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet_PacientexPaciente2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSetPacientexPaciente2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSetPacientesxDNIBindingSource)).BeginInit();
            this.GrupoEnvio.SuspendLayout();
            this.SuspendLayout();
            // 
            // sPPacientexClienteBindingSource1
            // 
            this.sPPacientexClienteBindingSource1.DataMember = "SP_PacientexCliente";
            this.sPPacientexClienteBindingSource1.DataSource = this.sOFTVETDataSet_PacientesxDNI;
            // 
            // sOFTVETDataSet_PacientesxDNI
            // 
            this.sOFTVETDataSet_PacientesxDNI.DataSetName = "SOFTVETDataSet_PacientesxDNI";
            this.sOFTVETDataSet_PacientesxDNI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(189, 92);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(56, 19);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(92, 92);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(76, 20);
            this.txtDNI.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese DNI:";
            // 
            // Generar
            // 
            this.Generar.Controls.Add(this.label2);
            this.Generar.Controls.Add(this.btnGenerar);
            this.Generar.Controls.Add(this.label1);
            this.Generar.Controls.Add(this.txtDNI);
            this.Generar.Location = new System.Drawing.Point(96, 11);
            this.Generar.Margin = new System.Windows.Forms.Padding(2);
            this.Generar.Name = "Generar";
            this.Generar.Padding = new System.Windows.Forms.Padding(2);
            this.Generar.Size = new System.Drawing.Size(418, 127);
            this.Generar.TabIndex = 2;
            this.Generar.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Generar Reporte de Mascotas por DNI";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_PacientexDNI";
            reportDataSource1.Value = this.sPPacientexClienteBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinal.Reportes.Reporte_PacientexDNI.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(61, 152);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(850, 410);
            this.reportViewer1.TabIndex = 3;
            // 
            // sPPacientexClienteBindingSource
            // 
            this.sPPacientexClienteBindingSource.DataMember = "SP_PacientexCliente";
            this.sPPacientexClienteBindingSource.DataSource = this.sOFTVETDataSet_PacientesxDNI;
            // 
            // sP_PacientexClienteTableAdapter
            // 
            this.sP_PacientexClienteTableAdapter.ClearBeforeFill = true;
            // 
            // sOFTVETDataSet_PacientexPaciente2
            // 
            this.sOFTVETDataSet_PacientexPaciente2.DataSetName = "SOFTVETDataSet_PacientexPaciente2";
            this.sOFTVETDataSet_PacientexPaciente2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sOFTVETDataSetPacientexPaciente2BindingSource
            // 
            this.sOFTVETDataSetPacientexPaciente2BindingSource.DataSource = this.sOFTVETDataSet_PacientexPaciente2;
            this.sOFTVETDataSetPacientexPaciente2BindingSource.Position = 0;
            // 
            // sOFTVETDataSetPacientesxDNIBindingSource
            // 
            this.sOFTVETDataSetPacientesxDNIBindingSource.DataSource = this.sOFTVETDataSet_PacientesxDNI;
            this.sOFTVETDataSetPacientesxDNIBindingSource.Position = 0;
            // 
            // GrupoEnvio
            // 
            this.GrupoEnvio.Controls.Add(this.lblFiles);
            this.GrupoEnvio.Controls.Add(this.label3);
            this.GrupoEnvio.Controls.Add(this.btnSubir);
            this.GrupoEnvio.Controls.Add(this.btnEnviar);
            this.GrupoEnvio.Enabled = false;
            this.GrupoEnvio.Location = new System.Drawing.Point(650, 12);
            this.GrupoEnvio.Name = "GrupoEnvio";
            this.GrupoEnvio.Size = new System.Drawing.Size(261, 126);
            this.GrupoEnvio.TabIndex = 4;
            this.GrupoEnvio.TabStop = false;
            this.GrupoEnvio.Text = "Enviar Reporte";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(20, 73);
            this.lblFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(16, 13);
            this.lblFiles.TabIndex = 27;
            this.lblFiles.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Archivos adjuntos:";
            // 
            // btnSubir
            // 
            this.btnSubir.Image = global::ProyectoFinal.Properties.Resources.agregararchivo;
            this.btnSubir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubir.Location = new System.Drawing.Point(15, 23);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubir.Size = new System.Drawing.Size(101, 32);
            this.btnSubir.TabIndex = 5;
            this.btnSubir.Text = "Subir Reporte";
            this.btnSubir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Image = global::ProyectoFinal.Properties.Resources.enviar_mensaje;
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.Location = new System.Drawing.Point(161, 23);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(82, 32);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormReporte_Paciente_DNI_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 600);
            this.Controls.Add(this.GrupoEnvio);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Generar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReporte_Paciente_DNI_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReporte_Paciente_DNI_Cliente";
            this.Load += new System.EventHandler(this.FormReporte_Paciente_DNI_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPPacientexClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet_PacientesxDNI)).EndInit();
            this.Generar.ResumeLayout(false);
            this.Generar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPPacientexClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet_PacientexPaciente2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSetPacientexPaciente2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSetPacientesxDNIBindingSource)).EndInit();
            this.GrupoEnvio.ResumeLayout(false);
            this.GrupoEnvio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Generar;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPPacientexClienteBindingSource;
        private SOFTVETDataSet_PacientesxDNI sOFTVETDataSet_PacientesxDNI;
        private SOFTVETDataSet_PacientesxDNITableAdapters.SP_PacientexClienteTableAdapter sP_PacientexClienteTableAdapter;
        private System.Windows.Forms.BindingSource sOFTVETDataSetPacientexPaciente2BindingSource;
        private SOFTVETDataSet_PacientexPaciente2 sOFTVETDataSet_PacientexPaciente2;
        private System.Windows.Forms.BindingSource sOFTVETDataSetPacientesxDNIBindingSource;
        private System.Windows.Forms.BindingSource sPPacientexClienteBindingSource1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.GroupBox GrupoEnvio;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFiles;
    }
}