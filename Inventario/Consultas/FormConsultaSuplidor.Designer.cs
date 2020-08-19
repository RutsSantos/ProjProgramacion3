namespace Inventario {
    partial class FormConsultaDeSuplidor {
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
            this.dataGridView = new System.Windows.Forms.DataGridView ();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox ();
            this.label4 = new System.Windows.Forms.Label ();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox ();
            this.label3 = new System.Windows.Forms.Label ();
            this.panel1.SuspendLayout ();
            this.panel2.SuspendLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.DS)).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) (this.ep)).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView)).BeginInit ();
            this.SuspendLayout ();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Font = new System.Drawing.Font ("Arial", 11F);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "        Salvar          Suplidor";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font ("Arial", 11F);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "        Buscar           Suplidor";
            this.btnBuscar.Click += new System.EventHandler (this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Font = new System.Drawing.Font ("Arial", 11F);
            this.ep.SetIconAlignment (this.btnEliminar, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "        Eliminar           Suplidor";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point (31, 117);
            this.txtNombre.Size = new System.Drawing.Size (177, 29);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler (this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler (this.txtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point (36, 81);
            this.label2.Size = new System.Drawing.Size (172, 22);
            this.label2.Text = "Buscar por nombre";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.Font = new System.Drawing.Font ("Arial", 11F);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "          Elegir           Suplidor";
            this.btnSeleccionar.Click += new System.EventHandler (this.btnSeleccionar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "        Generar           Reporte";
            this.btnImprimir.Click += new System.EventHandler (this.btnImprimir_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point (738, 0);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size (336, 30);
            this.label1.Text = "     Consulta de suplidores";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) |
                    System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView.Location = new System.Drawing.Point (17, 179);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 40;
            this.dataGridView.Size = new System.Drawing.Size (675, 264);
            this.dataGridView.TabIndex = 15;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Font = new System.Drawing.Font ("Arial", 14.25F);
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange (new object[] {
                "Todos",
                "Activo",
                "Inactivo"
            });
            this.comboBoxEstado.Location = new System.Drawing.Point (495, 115);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size (214, 30);
            this.comboBoxEstado.TabIndex = 18;
            this.comboBoxEstado.Text = "Todos";
            this.comboBoxEstado.SelectedIndexChanged += new System.EventHandler (this.comboBoxEstado_SelectedIndexChanged);
            this.comboBoxEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler (this.comboBoxEstado_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font ("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point (513, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size (165, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Buscar por estado";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.Font = new System.Drawing.Font ("Arial", 14.25F);
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange (new object[] {
                "Todos",
                "Femenino",
                "Masculino"
            });
            this.comboBoxGenero.Location = new System.Drawing.Point (238, 115);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size (214, 30);
            this.comboBoxGenero.TabIndex = 17;
            this.comboBoxGenero.Text = "Todos";
            this.comboBoxGenero.SelectedIndexChanged += new System.EventHandler (this.comboBoxGenero_SelectedIndexChanged);
            this.comboBoxGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler (this.comboBoxGenero_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font ("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point (258, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (167, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Buscar por genero";
            // 
            // FormConsultaDeSuplidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (879, 455);
            this.Controls.Add (this.comboBoxEstado);
            this.Controls.Add (this.label4);
            this.Controls.Add (this.comboBoxGenero);
            this.Controls.Add (this.label3);
            this.Controls.Add (this.dataGridView);
            this.LabelonParent = "     Consulta de suplidores";
            this.Name = "FormConsultaDeSuplidor";
            this.Text = "Consulta de suplidores";
            this.Controls.SetChildIndex (this.dataGridView, 0);
            this.Controls.SetChildIndex (this.panel2, 0);
            this.Controls.SetChildIndex (this.label2, 0);
            this.Controls.SetChildIndex (this.txtNombre, 0);
            this.Controls.SetChildIndex (this.panel1, 0);
            this.Controls.SetChildIndex (this.label3, 0);
            this.Controls.SetChildIndex (this.comboBoxGenero, 0);
            this.Controls.SetChildIndex (this.label4, 0);
            this.Controls.SetChildIndex (this.comboBoxEstado, 0);
            this.panel1.ResumeLayout (false);
            this.panel2.ResumeLayout (false);
            this.panel2.PerformLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.DS)).EndInit ();
            ((System.ComponentModel.ISupportInitialize) (this.ep)).EndInit ();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView)).EndInit ();
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        public System.Windows.Forms.Label label3;

    }
}