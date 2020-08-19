namespace Inventario.Procesos {
    partial class FormProcesosVentas {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (FormProcesosVentas));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel ();
            this.txtNombre = new System.Windows.Forms.TextBox ();
            this.txtCodigo = new System.Windows.Forms.TextBox ();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox ();
            this.txtNombreProducto = new System.Windows.Forms.TextBox ();
            this.txtCantidadAVender = new System.Windows.Forms.TextBox ();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox ();
            this.btnAgregar = new System.Windows.Forms.Button ();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel ();
            this.btnConsultarCliente = new System.Windows.Forms.Button ();
            this.dataGridView1 = new System.Windows.Forms.DataGridView ();
            this.txtTotal = new System.Windows.Forms.TextBox ();
            this.label2 = new System.Windows.Forms.Label ();
            this.label3 = new System.Windows.Forms.Label ();
            this.label4 = new System.Windows.Forms.Label ();
            this.label5 = new System.Windows.Forms.Label ();
            this.label6 = new System.Windows.Forms.Label ();
            this.label7 = new System.Windows.Forms.Label ();
            this.txtUnidad = new System.Windows.Forms.TextBox ();
            this.panel1.SuspendLayout ();
            this.panel2.SuspendLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.DS)).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) (this.ep)).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit ();
            this.SuspendLayout ();
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.Font = new System.Drawing.Font ("Arial", 12F);
            this.btnConsultar.Location = new System.Drawing.Point (10, 415);
            this.btnConsultar.Size = new System.Drawing.Size (121, 48);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "      Consulta          Productos";
            this.btnConsultar.Click += new System.EventHandler (this.btnConsultar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.Font = new System.Drawing.Font ("Arial", 11F);
            this.btnNuevo.Location = new System.Drawing.Point (10, 530);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "         Nuevo            Proceso";
            this.btnNuevo.Click += new System.EventHandler (this.btnNuevo_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.FlatAppearance.BorderSize = 0;
            this.btnProcesar.Location = new System.Drawing.Point (10, 309);
            this.btnProcesar.TabIndex = 10;
            this.btnProcesar.Click += new System.EventHandler (this.btnProcesar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Font = new System.Drawing.Font ("Arial", 11F);
            this.btnEliminar.Location = new System.Drawing.Point (10, 473);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "       Eliminar           Producto";
            this.btnEliminar.Click += new System.EventHandler (this.btnEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add (this.btnConsultarCliente);
            this.panel1.Location = new System.Drawing.Point (645, 0);
            this.panel1.Size = new System.Drawing.Size (140, 633);
            this.panel1.Controls.SetChildIndex (this.btnProcesar, 0);
            this.panel1.Controls.SetChildIndex (this.btnNuevo, 0);
            this.panel1.Controls.SetChildIndex (this.btnEliminar, 0);
            this.panel1.Controls.SetChildIndex (this.buttonCerrar, 0);
            this.panel1.Controls.SetChildIndex (this.btnConsultar, 0);
            this.panel1.Controls.SetChildIndex (this.btnConsultarCliente, 0);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.Location = new System.Drawing.Point (10, 582);
            this.buttonCerrar.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size (290, 30);
            this.label1.Text = "     Procesos de ventas";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font ("Arial", 14.25F);
            this.linkLabel1.Location = new System.Drawing.Point (13, 77);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size (167, 22);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Código del Cliente";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler (this.linkLabel1_LinkClicked_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font ("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point (197, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size (262, 29);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler (this.txtNombre_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font ("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtCodigo.Location = new System.Drawing.Point (197, 74);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size (154, 29);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextChanged += new System.EventHandler (this.txtCodigo_TextChanged_1);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler (this.txtCodigo_KeyPress);
            this.txtCodigo.Validating += new System.ComponentModel.CancelEventHandler (this.txtCodigo_Validating_1);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Font = new System.Drawing.Font ("Arial", 14F);
            this.txtCodigoProducto.Location = new System.Drawing.Point (197, 175);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size (154, 29);
            this.txtCodigoProducto.TabIndex = 5;
            this.txtCodigoProducto.TextChanged += new System.EventHandler (this.txtCodigoProducto_TextChanged);
            this.txtCodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler (this.txtCodigoProducto_KeyPress);
            this.txtCodigoProducto.Validating += new System.ComponentModel.CancelEventHandler (this.txtCodigoProducto_Validating);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font ("Arial", 14F);
            this.txtNombreProducto.Location = new System.Drawing.Point (197, 212);
            this.txtNombreProducto.Multiline = true;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size (262, 28);
            this.txtNombreProducto.TabIndex = 6;
            // 
            // txtCantidadAVender
            // 
            this.txtCantidadAVender.Font = new System.Drawing.Font ("Arial", 14F);
            this.txtCantidadAVender.Location = new System.Drawing.Point (197, 318);
            this.txtCantidadAVender.Name = "txtCantidadAVender";
            this.txtCantidadAVender.Size = new System.Drawing.Size (154, 29);
            this.txtCantidadAVender.TabIndex = 7;
            this.txtCantidadAVender.TextChanged += new System.EventHandler (this.txtCantidadAVender_TextChanged);
            this.txtCantidadAVender.KeyPress += new System.Windows.Forms.KeyPressEventHandler (this.txtCantidadProducto_KeyPress);
            this.txtCantidadAVender.Validating += new System.ComponentModel.CancelEventHandler (this.txtCantidadAVender_Validating);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Font = new System.Drawing.Font ("Arial", 14F);
            this.txtPrecioProducto.Location = new System.Drawing.Point (197, 283);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.ReadOnly = true;
            this.txtPrecioProducto.Size = new System.Drawing.Size (153, 29);
            this.txtPrecioProducto.TabIndex = 8;
            this.txtPrecioProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler (this.txtPrecioProducto_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb (((int) (((byte) (86)))), ((int) (((byte) (101)))), ((int) (((byte) (115)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font ("Arial", 14F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image) (resources.GetObject ("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point (493, 310);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding (0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size (121, 41);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "  Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler (this.btnAgregar_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font ("Arial", 14.25F);
            this.linkLabel2.Location = new System.Drawing.Point (12, 180);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size (185, 22);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Código del Producto";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler (this.linkLabel2_LinkClicked);
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.BackColor = System.Drawing.Color.FromArgb (((int) (((byte) (165)))), ((int) (((byte) (105)))), ((int) (((byte) (189)))));
            this.btnConsultarCliente.FlatAppearance.BorderSize = 0;
            this.btnConsultarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCliente.Font = new System.Drawing.Font ("Arial", 12F);
            this.btnConsultarCliente.ForeColor = System.Drawing.Color.White;
            this.btnConsultarCliente.Image = ((System.Drawing.Image) (resources.GetObject ("btnConsultarCliente.Image")));
            this.btnConsultarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarCliente.Location = new System.Drawing.Point (10, 360);
            this.btnConsultarCliente.Margin = new System.Windows.Forms.Padding (0);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size (121, 46);
            this.btnConsultarCliente.TabIndex = 11;
            this.btnConsultarCliente.Text = "      Consulta          Cliente";
            this.btnConsultarCliente.UseVisualStyleBackColor = false;
            this.btnConsultarCliente.Click += new System.EventHandler (this.btnConsultarCliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point (12, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size (602, 215);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler (this.dataGridView1_CellContentClick);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font ("Arial", 14F);
            this.txtTotal.Location = new System.Drawing.Point (506, 595);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size (110, 28);
            this.txtTotal.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font ("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point (450, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (50, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font ("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point (16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (173, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nombre del Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font ("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point (3, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size (191, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nombre del Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font ("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point (23, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size (166, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Cantidad a Vender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font ("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point (16, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size (178, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "Precio del Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font ("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point (10, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size (182, 22);
            this.label7.TabIndex = 35;
            this.label7.Text = "Unidad del Producto";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Font = new System.Drawing.Font ("Arial", 14F);
            this.txtUnidad.Location = new System.Drawing.Point (197, 246);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.ReadOnly = true;
            this.txtUnidad.Size = new System.Drawing.Size (153, 29);
            this.txtUnidad.TabIndex = 34;
            // 
            // FormProcesosVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (785, 633);
            this.Controls.Add (this.label7);
            this.Controls.Add (this.txtUnidad);
            this.Controls.Add (this.label6);
            this.Controls.Add (this.label5);
            this.Controls.Add (this.label4);
            this.Controls.Add (this.label3);
            this.Controls.Add (this.label2);
            this.Controls.Add (this.btnAgregar);
            this.Controls.Add (this.txtTotal);
            this.Controls.Add (this.dataGridView1);
            this.Controls.Add (this.linkLabel2);
            this.Controls.Add (this.txtPrecioProducto);
            this.Controls.Add (this.txtCantidadAVender);
            this.Controls.Add (this.txtNombreProducto);
            this.Controls.Add (this.txtCodigoProducto);
            this.Controls.Add (this.txtNombre);
            this.Controls.Add (this.txtCodigo);
            this.Controls.Add (this.linkLabel1);
            this.LabelonParent = "     Procesos de ventas";
            this.Name = "FormProcesosVentas";
            this.Text = "Procesos dde ventas";
            this.Load += new System.EventHandler (this.FormProcesosVentas_Load);
            this.Controls.SetChildIndex (this.linkLabel1, 0);
            this.Controls.SetChildIndex (this.txtCodigo, 0);
            this.Controls.SetChildIndex (this.txtNombre, 0);
            this.Controls.SetChildIndex (this.txtCodigoProducto, 0);
            this.Controls.SetChildIndex (this.txtNombreProducto, 0);
            this.Controls.SetChildIndex (this.txtCantidadAVender, 0);
            this.Controls.SetChildIndex (this.txtPrecioProducto, 0);
            this.Controls.SetChildIndex (this.linkLabel2, 0);
            this.Controls.SetChildIndex (this.dataGridView1, 0);
            this.Controls.SetChildIndex (this.txtTotal, 0);
            this.Controls.SetChildIndex (this.panel1, 0);
            this.Controls.SetChildIndex (this.btnAgregar, 0);
            this.Controls.SetChildIndex (this.panel2, 0);
            this.Controls.SetChildIndex (this.label2, 0);
            this.Controls.SetChildIndex (this.label3, 0);
            this.Controls.SetChildIndex (this.label4, 0);
            this.Controls.SetChildIndex (this.label5, 0);
            this.Controls.SetChildIndex (this.label6, 0);
            this.Controls.SetChildIndex (this.txtUnidad, 0);
            this.Controls.SetChildIndex (this.label7, 0);
            this.panel1.ResumeLayout (false);
            this.panel2.ResumeLayout (false);
            this.panel2.PerformLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.DS)).EndInit ();
            ((System.ComponentModel.ISupportInitialize) (this.ep)).EndInit ();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit ();
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCantidadAVender;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.LinkLabel linkLabel2;
        public System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUnidad;

    }
}