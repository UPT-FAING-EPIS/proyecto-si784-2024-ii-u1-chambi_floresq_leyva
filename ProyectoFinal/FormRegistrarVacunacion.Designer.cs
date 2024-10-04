namespace ProyectoFinal
{
    partial class FormRegistrarVacunacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarVacunacion));
            this.groupBoxVacunacion = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidVacunacion = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDVacuna = new System.Windows.Forms.TextBox();
            this.txtIDPaciente = new System.Windows.Forms.TextBox();
            this.datePickVacunacion = new System.Windows.Forms.DateTimePicker();
            this.txtNroDosis = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.txtCod_Cliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.dgvVacunados = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvTotalStock = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxVacunacion.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVacunacion
            // 
            this.groupBoxVacunacion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxVacunacion.Controls.Add(this.label3);
            this.groupBoxVacunacion.Controls.Add(this.txtidVacunacion);
            this.groupBoxVacunacion.Controls.Add(this.btnNuevo);
            this.groupBoxVacunacion.Controls.Add(this.btnCancelar);
            this.groupBoxVacunacion.Controls.Add(this.label4);
            this.groupBoxVacunacion.Controls.Add(this.label6);
            this.groupBoxVacunacion.Controls.Add(this.txtIDVacuna);
            this.groupBoxVacunacion.Controls.Add(this.txtIDPaciente);
            this.groupBoxVacunacion.Controls.Add(this.datePickVacunacion);
            this.groupBoxVacunacion.Controls.Add(this.txtNroDosis);
            this.groupBoxVacunacion.Controls.Add(this.btnAgregar);
            this.groupBoxVacunacion.Controls.Add(this.label5);
            this.groupBoxVacunacion.Controls.Add(this.label2);
            this.groupBoxVacunacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVacunacion.Location = new System.Drawing.Point(32, 362);
            this.groupBoxVacunacion.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxVacunacion.Name = "groupBoxVacunacion";
            this.groupBoxVacunacion.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxVacunacion.Size = new System.Drawing.Size(565, 274);
            this.groupBoxVacunacion.TabIndex = 55;
            this.groupBoxVacunacion.TabStop = false;
            this.groupBoxVacunacion.Text = "Agregar Vacuna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 78;
            this.label3.Text = "id Registro :";
            this.label3.Visible = false;
            // 
            // txtidVacunacion
            // 
            this.txtidVacunacion.Location = new System.Drawing.Point(115, 59);
            this.txtidVacunacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidVacunacion.Name = "txtidVacunacion";
            this.txtidVacunacion.Size = new System.Drawing.Size(136, 23);
            this.txtidVacunacion.TabIndex = 77;
            this.txtidVacunacion.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(428, 41);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(125, 41);
            this.btnNuevo.TabIndex = 76;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(428, 146);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 42);
            this.btnCancelar.TabIndex = 75;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "id Vacuna:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "id Paciente: ";
            // 
            // txtIDVacuna
            // 
            this.txtIDVacuna.Enabled = false;
            this.txtIDVacuna.Location = new System.Drawing.Point(115, 128);
            this.txtIDVacuna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDVacuna.Name = "txtIDVacuna";
            this.txtIDVacuna.Size = new System.Drawing.Size(136, 23);
            this.txtIDVacuna.TabIndex = 58;
            // 
            // txtIDPaciente
            // 
            this.txtIDPaciente.Enabled = false;
            this.txtIDPaciente.Location = new System.Drawing.Point(115, 94);
            this.txtIDPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDPaciente.Name = "txtIDPaciente";
            this.txtIDPaciente.Size = new System.Drawing.Size(136, 23);
            this.txtIDPaciente.TabIndex = 52;
            // 
            // datePickVacunacion
            // 
            this.datePickVacunacion.Location = new System.Drawing.Point(115, 194);
            this.datePickVacunacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePickVacunacion.Name = "datePickVacunacion";
            this.datePickVacunacion.Size = new System.Drawing.Size(303, 23);
            this.datePickVacunacion.TabIndex = 49;
            // 
            // txtNroDosis
            // 
            this.txtNroDosis.Location = new System.Drawing.Point(115, 158);
            this.txtNroDosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNroDosis.Name = "txtNroDosis";
            this.txtNroDosis.Size = new System.Drawing.Size(136, 23);
            this.txtNroDosis.TabIndex = 43;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(428, 92);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 41);
            this.btnAgregar.TabIndex = 72;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Fecha Vacuna:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nro. Dosis:";
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxCliente.Controls.Add(this.txtCod_Cliente);
            this.groupBoxCliente.Controls.Add(this.label7);
            this.groupBoxCliente.Controls.Add(this.btnBuscar);
            this.groupBoxCliente.Controls.Add(this.label13);
            this.groupBoxCliente.Controls.Add(this.txtDNI);
            this.groupBoxCliente.Controls.Add(this.txtNombreCliente);
            this.groupBoxCliente.Controls.Add(this.label15);
            this.groupBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCliente.Location = new System.Drawing.Point(39, 142);
            this.groupBoxCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCliente.Size = new System.Drawing.Size(477, 149);
            this.groupBoxCliente.TabIndex = 54;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // txtCod_Cliente
            // 
            this.txtCod_Cliente.Enabled = false;
            this.txtCod_Cliente.Location = new System.Drawing.Point(117, 116);
            this.txtCod_Cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCod_Cliente.Name = "txtCod_Cliente";
            this.txtCod_Cliente.Size = new System.Drawing.Size(117, 23);
            this.txtCod_Cliente.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "ID: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::ProyectoFinal.Properties.Resources.buscar__2_;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(332, 57);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 41);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "Ingrese DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDNI.Location = new System.Drawing.Point(117, 44);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(117, 23);
            this.txtDNI.TabIndex = 25;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(117, 79);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(171, 23);
            this.txtNombreCliente.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(41, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "Nombre:";
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(20, 42);
            this.dgvPacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.RowHeadersWidth = 51;
            this.dgvPacientes.RowTemplate.Height = 24;
            this.dgvPacientes.Size = new System.Drawing.Size(224, 148);
            this.dgvPacientes.TabIndex = 65;
            this.dgvPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellClick);
            // 
            // dgvVacunados
            // 
            this.dgvVacunados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvVacunados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVacunados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacunados.Location = new System.Drawing.Point(621, 362);
            this.dgvVacunados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVacunados.Name = "dgvVacunados";
            this.dgvVacunados.RowHeadersVisible = false;
            this.dgvVacunados.RowHeadersWidth = 51;
            this.dgvVacunados.RowTemplate.Height = 24;
            this.dgvVacunados.Size = new System.Drawing.Size(565, 274);
            this.dgvVacunados.TabIndex = 68;
            this.dgvVacunados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVacunados_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(423, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(454, 48);
            this.label8.TabIndex = 80;
            this.label8.Text = "REGISTRO DE VACUNACIÓN";
            // 
            // dgvTotalStock
            // 
            this.dgvTotalStock.AllowUserToAddRows = false;
            this.dgvTotalStock.AllowUserToDeleteRows = false;
            this.dgvTotalStock.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTotalStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTotalStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalStock.Location = new System.Drawing.Point(250, 42);
            this.dgvTotalStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTotalStock.Name = "dgvTotalStock";
            this.dgvTotalStock.ReadOnly = true;
            this.dgvTotalStock.RowHeadersVisible = false;
            this.dgvTotalStock.RowHeadersWidth = 51;
            this.dgvTotalStock.RowTemplate.Height = 24;
            this.dgvTotalStock.Size = new System.Drawing.Size(303, 148);
            this.dgvTotalStock.TabIndex = 82;
            this.dgvTotalStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTotalStock_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "Mascotas del Dueño";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 16);
            this.label9.TabIndex = 84;
            this.label9.Text = "Stocks de Vacunas";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgvPacientes);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvTotalStock);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(621, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 206);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            // 
            // FormRegistrarVacunacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.PATITAS;
            this.ClientSize = new System.Drawing.Size(1284, 677);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvVacunados);
            this.Controls.Add(this.groupBoxVacunacion);
            this.Controls.Add(this.groupBoxCliente);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRegistrarVacunacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistrarVacunacion";
            this.Load += new System.EventHandler(this.FormRegistrarVacunacion_Load);
            this.groupBoxVacunacion.ResumeLayout(false);
            this.groupBoxVacunacion.PerformLayout();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxVacunacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDPaciente;
        private System.Windows.Forms.DateTimePicker datePickVacunacion;
        private System.Windows.Forms.TextBox txtNroDosis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCod_Cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDVacuna;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.DataGridView dgvVacunados;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidVacunacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvTotalStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}