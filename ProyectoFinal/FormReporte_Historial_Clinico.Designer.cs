namespace ProyectoFinal
{
    partial class FormReporte_Historial_Clinico
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sPHistorialClinicoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sOFTVETDataSet_HC_Cli_Paciente = new ProyectoFinal.SOFTVETDataSet_HC_Cli_Paciente();
            this.sPRHvacunacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sOFTVETDataSet_HC_Vacunacion = new ProyectoFinal.SOFTVETDataSet_HC_Vacunacion();
            this.sPRHRecetacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sOFTVETDataSet_HC_RECETARIO = new ProyectoFinal.SOFTVETDataSet_HC_RECETARIO();
            this.sPRHdesparacitacionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sOFTVETDataSet_HC_Desparasitacion = new ProyectoFinal.SOFTVETDataSet_HC_Desparasitacion();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sPHistorialClinicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_HistorialClinicoTableAdapter1 = new ProyectoFinal.SOFTVETDataSet_HC_Cli_PacienteTableAdapters.SP_HistorialClinicoTableAdapter();
            this.sOFTVETDataSet_Vacunacion = new ProyectoFinal.SOFTVETDataSet_Vacunacion();
            this.sPHvacunacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_HvacunacionTableAdapter = new ProyectoFinal.SOFTVETDataSet_VacunacionTableAdapters.SP_HvacunacionTableAdapter();
            this.sPR_HvacunacionTableAdapter = new ProyectoFinal.SOFTVETDataSet_HC_VacunacionTableAdapters.SPR_HvacunacionTableAdapter();
            this.sPR_HRecetacionTableAdapter = new ProyectoFinal.SOFTVETDataSet_HC_RECETARIOTableAdapters.SPR_HRecetacionTableAdapter();
            this.sPRHdesparacitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPR_HdesparacitacionTableAdapter = new ProyectoFinal.SOFTVETDataSet_HC_DesparasitacionTableAdapters.SPR_HdesparacitacionTableAdapter();
            this.sOFTVETDataSetHCDesparasitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GrupoEnvio = new System.Windows.Forms.GroupBox();
            this.lblFiles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sPHistorialClinicoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet_HC_Cli_Paciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRHvacunacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet_HC_Vacunacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRHRecetacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet_HC_RECETARIO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRHdesparacitacionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet_HC_Desparasitacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPHistorialClinicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet_Vacunacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPHvacunacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRHdesparacitacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSetHCDesparasitacionBindingSource)).BeginInit();
            this.GrupoEnvio.SuspendLayout();
            this.SuspendLayout();
            // 
            // sPHistorialClinicoBindingSource1
            // 
            this.sPHistorialClinicoBindingSource1.DataMember = "SP_HistorialClinico";
            this.sPHistorialClinicoBindingSource1.DataSource = this.sOFTVETDataSet_HC_Cli_Paciente;
            // 
            // sOFTVETDataSet_HC_Cli_Paciente
            // 
            this.sOFTVETDataSet_HC_Cli_Paciente.DataSetName = "SOFTVETDataSet_HC_Cli_Paciente";
            this.sOFTVETDataSet_HC_Cli_Paciente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPRHvacunacionBindingSource
            // 
            this.sPRHvacunacionBindingSource.DataMember = "SPR_Hvacunacion";
            this.sPRHvacunacionBindingSource.DataSource = this.sOFTVETDataSet_HC_Vacunacion;
            // 
            // sOFTVETDataSet_HC_Vacunacion
            // 
            this.sOFTVETDataSet_HC_Vacunacion.DataSetName = "SOFTVETDataSet_HC_Vacunacion";
            this.sOFTVETDataSet_HC_Vacunacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPRHRecetacionBindingSource
            // 
            this.sPRHRecetacionBindingSource.DataMember = "SPR_HRecetacion";
            this.sPRHRecetacionBindingSource.DataSource = this.sOFTVETDataSet_HC_RECETARIO;
            // 
            // sOFTVETDataSet_HC_RECETARIO
            // 
            this.sOFTVETDataSet_HC_RECETARIO.DataSetName = "SOFTVETDataSet_HC_RECETARIO";
            this.sOFTVETDataSet_HC_RECETARIO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPRHdesparacitacionBindingSource1
            // 
            this.sPRHdesparacitacionBindingSource1.DataMember = "SPR_Hdesparacitacion";
            this.sPRHdesparacitacionBindingSource1.DataSource = this.sOFTVETDataSet_HC_Desparasitacion;
            // 
            // sOFTVETDataSet_HC_Desparasitacion
            // 
            this.sOFTVETDataSet_HC_Desparasitacion.DataSetName = "SOFTVETDataSet_HC_Desparasitacion";
            this.sOFTVETDataSet_HC_Desparasitacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(9, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(266, 308);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HC_Paciente";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvPacientes);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(25, 171);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(213, 128);
            this.groupBox4.TabIndex = 69;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mascotas del Cliente";
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvPacientes.Location = new System.Drawing.Point(9, 18);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.RowHeadersWidth = 51;
            this.dgvPacientes.Size = new System.Drawing.Size(196, 95);
            this.dgvPacientes.TabIndex = 72;
            this.dgvPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Generar Reporte Historial Clinico";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtDNI);
            this.groupBox3.Controls.Add(this.txtNombreCliente);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(29, 65);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(209, 102);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Ivory;
            this.btnBuscar.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(77, 66);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 23);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 21);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 14);
            this.label13.TabIndex = 26;
            this.label13.Text = " DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(77, 17);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(89, 20);
            this.txtDNI.TabIndex = 25;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(77, 42);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(89, 20);
            this.txtNombreCliente.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 44);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 14);
            this.label15.TabIndex = 18;
            this.label15.Text = "Nombre:";
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "DataSetHC_Cli_Paciente";
            reportDataSource5.Value = this.sPHistorialClinicoBindingSource1;
            reportDataSource6.Name = "DataSet_HC_Vacunacion";
            reportDataSource6.Value = this.sPRHvacunacionBindingSource;
            reportDataSource7.Name = "DataSet_HC_Recetario";
            reportDataSource7.Value = this.sPRHRecetacionBindingSource;
            reportDataSource8.Name = "DataSet_HC_Desparasitante";
            reportDataSource8.Value = this.sPRHdesparacitacionBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinal.Reportes.Reporte_Historial_Clinico_General.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(281, 24);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(687, 641);
            this.reportViewer1.TabIndex = 4;
            // 
            // sPHistorialClinicoBindingSource
            // 
            this.sPHistorialClinicoBindingSource.DataMember = "SP_HistorialClinico";
            // 
            // sP_HistorialClinicoTableAdapter1
            // 
            this.sP_HistorialClinicoTableAdapter1.ClearBeforeFill = true;
            // 
            // sOFTVETDataSet_Vacunacion
            // 
            this.sOFTVETDataSet_Vacunacion.DataSetName = "SOFTVETDataSet_Vacunacion";
            this.sOFTVETDataSet_Vacunacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPHvacunacionBindingSource
            // 
            this.sPHvacunacionBindingSource.DataMember = "SP_Hvacunacion";
            this.sPHvacunacionBindingSource.DataSource = this.sOFTVETDataSet_Vacunacion;
            // 
            // sP_HvacunacionTableAdapter
            // 
            this.sP_HvacunacionTableAdapter.ClearBeforeFill = true;
            // 
            // sPR_HvacunacionTableAdapter
            // 
            this.sPR_HvacunacionTableAdapter.ClearBeforeFill = true;
            // 
            // sPR_HRecetacionTableAdapter
            // 
            this.sPR_HRecetacionTableAdapter.ClearBeforeFill = true;
            // 
            // sPRHdesparacitacionBindingSource
            // 
            this.sPRHdesparacitacionBindingSource.DataMember = "SPR_Hdesparacitacion";
            this.sPRHdesparacitacionBindingSource.DataSource = this.sOFTVETDataSet_HC_Desparasitacion;
            // 
            // sPR_HdesparacitacionTableAdapter
            // 
            this.sPR_HdesparacitacionTableAdapter.ClearBeforeFill = true;
            // 
            // sOFTVETDataSetHCDesparasitacionBindingSource
            // 
            this.sOFTVETDataSetHCDesparasitacionBindingSource.DataSource = this.sOFTVETDataSet_HC_Desparasitacion;
            this.sOFTVETDataSetHCDesparasitacionBindingSource.Position = 0;
            // 
            // GrupoEnvio
            // 
            this.GrupoEnvio.Controls.Add(this.lblFiles);
            this.GrupoEnvio.Controls.Add(this.label3);
            this.GrupoEnvio.Controls.Add(this.btnSubir);
            this.GrupoEnvio.Controls.Add(this.btnEnviar);
            this.GrupoEnvio.Enabled = false;
            this.GrupoEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoEnvio.Location = new System.Drawing.Point(9, 330);
            this.GrupoEnvio.Name = "GrupoEnvio";
            this.GrupoEnvio.Size = new System.Drawing.Size(266, 153);
            this.GrupoEnvio.TabIndex = 5;
            this.GrupoEnvio.TabStop = false;
            this.GrupoEnvio.Text = "Enviar Reporte";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles.Location = new System.Drawing.Point(24, 72);
            this.lblFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(17, 12);
            this.lblFiles.TabIndex = 27;
            this.lblFiles.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Archivos adjuntos:";
            // 
            // btnSubir
            // 
            this.btnSubir.Image = global::ProyectoFinal.Properties.Resources.agregararchivo;
            this.btnSubir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubir.Location = new System.Drawing.Point(19, 22);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubir.Size = new System.Drawing.Size(113, 32);
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
            this.btnEnviar.Location = new System.Drawing.Point(165, 22);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(82, 32);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FormReporte_Historial_Clinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 609);
            this.Controls.Add(this.GrupoEnvio);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReporte_Historial_Clinico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReporte_Historial_Clinico";
            this.Load += new System.EventHandler(this.FormReporte_Historial_Clinico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPHistorialClinicoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet_HC_Cli_Paciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRHvacunacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet_HC_Vacunacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRHRecetacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet_HC_RECETARIO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRHdesparacitacionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet_HC_Desparasitacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPHistorialClinicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet_Vacunacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPHvacunacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRHdesparacitacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSetHCDesparasitacionBindingSource)).EndInit();
            this.GrupoEnvio.ResumeLayout(false);
            this.GrupoEnvio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPHistorialClinicoBindingSource;
        private System.Windows.Forms.BindingSource sPHistorialClinicoBindingSource1;
        private SOFTVETDataSet_HC_Cli_Paciente sOFTVETDataSet_HC_Cli_Paciente;
        private SOFTVETDataSet_HC_Cli_PacienteTableAdapters.SP_HistorialClinicoTableAdapter sP_HistorialClinicoTableAdapter1;
        private System.Windows.Forms.BindingSource sPHvacunacionBindingSource;
        private SOFTVETDataSet_Vacunacion sOFTVETDataSet_Vacunacion;
        private SOFTVETDataSet_VacunacionTableAdapters.SP_HvacunacionTableAdapter sP_HvacunacionTableAdapter;
        private System.Windows.Forms.BindingSource sPRHvacunacionBindingSource;
        private SOFTVETDataSet_HC_Vacunacion sOFTVETDataSet_HC_Vacunacion;
        private SOFTVETDataSet_HC_VacunacionTableAdapters.SPR_HvacunacionTableAdapter sPR_HvacunacionTableAdapter;
        private System.Windows.Forms.BindingSource sPRHRecetacionBindingSource;
        private SOFTVETDataSet_HC_RECETARIO sOFTVETDataSet_HC_RECETARIO;
        private SOFTVETDataSet_HC_RECETARIOTableAdapters.SPR_HRecetacionTableAdapter sPR_HRecetacionTableAdapter;
        private SOFTVETDataSet_HC_Desparasitacion sOFTVETDataSet_HC_Desparasitacion;
        private System.Windows.Forms.BindingSource sPRHdesparacitacionBindingSource;
        private SOFTVETDataSet_HC_DesparasitacionTableAdapters.SPR_HdesparacitacionTableAdapter sPR_HdesparacitacionTableAdapter;
        private System.Windows.Forms.BindingSource sPRHdesparacitacionBindingSource1;
        private System.Windows.Forms.BindingSource sOFTVETDataSetHCDesparasitacionBindingSource;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox GrupoEnvio;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnEnviar;
    }
}