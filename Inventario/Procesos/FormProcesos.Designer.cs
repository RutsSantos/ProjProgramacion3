namespace Inventario.Procesos {
    partial class FormProcesos {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (FormProcesos));
            this.btnConsultar = new System.Windows.Forms.Button ();
            this.btnNuevo = new System.Windows.Forms.Button ();
            this.btnProcesar = new System.Windows.Forms.Button ();
            this.btnEliminar = new System.Windows.Forms.Button ();
            this.panel1.SuspendLayout ();
            this.panel2.SuspendLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.DS)).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) (this.ep)).BeginInit ();
            this.SuspendLayout ();
            // 
            // panel1
            // 
            this.panel1.Controls.Add (this.btnConsultar);
            this.panel1.Controls.Add (this.btnEliminar);
            this.panel1.Controls.Add (this.btnNuevo);
            this.panel1.Controls.Add (this.btnProcesar);
            this.panel1.Location = new System.Drawing.Point (644, 0);
            this.panel1.Size = new System.Drawing.Size (140, 461);
            this.panel1.Controls.SetChildIndex (this.btnProcesar, 0);
            this.panel1.Controls.SetChildIndex (this.btnNuevo, 0);
            this.panel1.Controls.SetChildIndex (this.btnEliminar, 0);
            this.panel1.Controls.SetChildIndex (this.buttonCerrar, 0);
            this.panel1.Controls.SetChildIndex (this.btnConsultar, 0);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.Location = new System.Drawing.Point (10, 410);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image) (resources.GetObject ("label1.Image")));
            this.label1.Size = new System.Drawing.Size (156, 31);
            this.label1.Text = "     Procesos";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb (((int) (((byte) (165)))), ((int) (((byte) (105)))), ((int) (((byte) (189)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font ("Arial", 14F);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Image = ((System.Drawing.Image) (resources.GetObject ("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point (10, 243);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding (0);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size (121, 42);
            this.btnConsultar.TabIndex = 18;
            this.btnConsultar.Text = "    Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb (((int) (((byte) (41)))), ((int) (((byte) (128)))), ((int) (((byte) (185)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font ("Arial", 14F);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image) (resources.GetObject ("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point (10, 358);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding (0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size (121, 42);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.FromArgb (((int) (((byte) (202)))), ((int) (((byte) (207)))), ((int) (((byte) (210)))));
            this.btnProcesar.FlatAppearance.BorderSize = 0;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font ("Arial", 14F);
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Image = ((System.Drawing.Image) (resources.GetObject ("btnProcesar.Image")));
            this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesar.Location = new System.Drawing.Point (10, 189);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding (0);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size (121, 42);
            this.btnProcesar.TabIndex = 16;
            this.btnProcesar.Text = "    Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb (((int) (((byte) (244)))), ((int) (((byte) (23)))), ((int) (((byte) (23)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font ("Arial", 14F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image) (resources.GetObject ("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point (10, 301);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding (0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size (121, 42);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "  Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // FormProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (784, 461);
            this.Name = "FormProcesos";
            this.Text = "Procesos";
            this.panel1.ResumeLayout (false);
            this.panel2.ResumeLayout (false);
            this.panel2.PerformLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.DS)).EndInit ();
            ((System.ComponentModel.ISupportInitialize) (this.ep)).EndInit ();
            this.ResumeLayout (false);

        }

        #endregion

        public System.Windows.Forms.Button btnConsultar;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Button btnProcesar;
        public System.Windows.Forms.Button btnEliminar;
    }
}