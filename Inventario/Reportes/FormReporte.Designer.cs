namespace Inventario.Reportes {
    partial class FormReporte {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (FormReporte));
            this.panel1.SuspendLayout ();
            this.panel2.SuspendLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.DS)).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) (this.ep)).BeginInit ();
            this.SuspendLayout ();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point (977, 0);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image) (resources.GetObject ("label1.Image")));
            this.label1.Size = new System.Drawing.Size (134, 31);
            this.label1.Text = "    Reporte";
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size (1117, 52);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (1117, 499);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            this.Load += new System.EventHandler (this.FormReporte_Load);
            this.panel1.ResumeLayout (false);
            this.panel2.ResumeLayout (false);
            this.panel2.PerformLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.DS)).EndInit ();
            ((System.ComponentModel.ISupportInitialize) (this.ep)).EndInit ();
            this.ResumeLayout (false);

        }

        #endregion

    }
}