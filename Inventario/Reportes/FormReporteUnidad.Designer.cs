namespace Inventario.Reportes {
    partial class FormReporteUnidad {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer ();
            this.panel1.SuspendLayout ();
            this.panel2.SuspendLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.DS)).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) (this.ep)).BeginInit ();
            this.SuspendLayout ();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point (1001, 0);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size (269, 30);
            this.label1.Text = "    Reporte de unidad";
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size (1004, 52);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventario.Reports.ReportUnidad.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point (0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size (1001, 499);
            this.reportViewer1.TabIndex = 3;
            // 
            // FormReporteUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (1141, 499);
            this.Controls.Add (this.reportViewer1);
            this.LabelonParent = "    Reporte de unidad";
            this.Name = "FormReporteUnidad";
            this.Text = "Reporte de unidad";
            this.Load += new System.EventHandler (this.FormReporteUnidad_Load);
            this.Controls.SetChildIndex (this.panel1, 0);
            this.Controls.SetChildIndex (this.panel2, 0);
            this.Controls.SetChildIndex (this.reportViewer1, 0);
            this.panel1.ResumeLayout (false);
            this.panel2.ResumeLayout (false);
            this.panel2.PerformLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.DS)).EndInit ();
            ((System.ComponentModel.ISupportInitialize) (this.ep)).EndInit ();
            this.ResumeLayout (false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}