namespace ProyectoFinal
{
    partial class FormReporte_Vacunas
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
            this.vacunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sOFTVETDataSet = new ProyectoFinal.SOFTVETDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Vacunas = new ProyectoFinal.DataSet.DataSet_Vacunas();
            this.dataSetVacunasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacunaTableAdapter = new ProyectoFinal.SOFTVETDataSetTableAdapters.VacunaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vacunaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Vacunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVacunasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vacunaBindingSource
            // 
            this.vacunaBindingSource.DataMember = "Vacuna";
            this.vacunaBindingSource.DataSource = this.sOFTVETDataSet;
            // 
            // sOFTVETDataSet
            // 
            this.sOFTVETDataSet.DataSetName = "SOFTVETDataSet";
            this.sOFTVETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetVacunas";
            reportDataSource1.Value = this.vacunaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoFinal.Reportes.Reporte_Vacunas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1300, 738);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Vacunas
            // 
            this.dataSet_Vacunas.DataSetName = "DataSet_Vacunas";
            this.dataSet_Vacunas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetVacunasBindingSource
            // 
            this.dataSetVacunasBindingSource.DataSource = this.dataSet_Vacunas;
            this.dataSetVacunasBindingSource.Position = 0;
            // 
            // vacunaTableAdapter
            // 
            this.vacunaTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporte_Vacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 738);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReporte_Vacunas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReporteVacunas";
            this.Load += new System.EventHandler(this.FormReporteVacunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vacunaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOFTVETDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Vacunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVacunasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetVacunasBindingSource;
        private DataSet.DataSet_Vacunas dataSet_Vacunas;
        private SOFTVETDataSet sOFTVETDataSet;
        private System.Windows.Forms.BindingSource vacunaBindingSource;
        private SOFTVETDataSetTableAdapters.VacunaTableAdapter vacunaTableAdapter;
    }
}