namespace Inventario.Mantenimiento {
    partial class FormMantenimientoDeProducto {
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
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoDpto = new System.Windows.Forms.TextBox();
            this.txtCodigoSuplidor = new System.Windows.Forms.TextBox();
            this.txtPunReo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoUnidad = new System.Windows.Forms.TextBox();
            this.txtCantidadExistente = new System.Windows.Forms.TextBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSuplidor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnSalvar.Location = new System.Drawing.Point(11, 211);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "        Salvar           Producto";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnBuscar.Location = new System.Drawing.Point(11, 272);
            this.btnBuscar.Size = new System.Drawing.Size(121, 46);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "        Buscar           Producto";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnEliminar.Location = new System.Drawing.Point(11, 334);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "       Eliminar           Producto";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(141, 447);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.Location = new System.Drawing.Point(11, 393);
            this.buttonCerrar.TabIndex = 15;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(413, 30);
            this.label1.Text = "      Mantenimiento de productos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(181)))), ((int)(((byte)(176)))));
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(441, 296);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(198, 29);
            this.txtPrecio.TabIndex = 10;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(441, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(198, 29);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(193, 100);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(68, 29);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigo_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 22);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cantidad Existente";
            // 
            // txtCodigoDpto
            // 
            this.txtCodigoDpto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDpto.Location = new System.Drawing.Point(193, 149);
            this.txtCodigoDpto.Name = "txtCodigoDpto";
            this.txtCodigoDpto.Size = new System.Drawing.Size(68, 29);
            this.txtCodigoDpto.TabIndex = 3;
            this.txtCodigoDpto.TextChanged += new System.EventHandler(this.txtCodigoDpto_TextChanged);
            this.txtCodigoDpto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoDpto_KeyPress);
            this.txtCodigoDpto.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoDpto_Validating);
            // 
            // txtCodigoSuplidor
            // 
            this.txtCodigoSuplidor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoSuplidor.Location = new System.Drawing.Point(193, 199);
            this.txtCodigoSuplidor.Name = "txtCodigoSuplidor";
            this.txtCodigoSuplidor.Size = new System.Drawing.Size(68, 29);
            this.txtCodigoSuplidor.TabIndex = 5;
            this.txtCodigoSuplidor.TextChanged += new System.EventHandler(this.txtCodigoSuplidor_TextChanged);
            this.txtCodigoSuplidor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoSuplidor_KeyPress);
            this.txtCodigoSuplidor.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoSuplidor_Validating);
            // 
            // txtPunReo
            // 
            this.txtPunReo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPunReo.Location = new System.Drawing.Point(193, 338);
            this.txtPunReo.Name = "txtPunReo";
            this.txtPunReo.Size = new System.Drawing.Size(68, 29);
            this.txtPunReo.TabIndex = 11;
            this.txtPunReo.TextChanged += new System.EventHandler(this.txtPunReo_TextChanged);
            this.txtPunReo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPunReo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 22);
            this.label8.TabIndex = 32;
            this.label8.Text = "Punto de Reorden";
            // 
            // txtCodigoUnidad
            // 
            this.txtCodigoUnidad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoUnidad.Location = new System.Drawing.Point(193, 246);
            this.txtCodigoUnidad.Name = "txtCodigoUnidad";
            this.txtCodigoUnidad.Size = new System.Drawing.Size(68, 29);
            this.txtCodigoUnidad.TabIndex = 7;
            this.txtCodigoUnidad.TextChanged += new System.EventHandler(this.txtCodigoUnidad_TextChanged);
            this.txtCodigoUnidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoUnidad_KeyPress);
            this.txtCodigoUnidad.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoUnidad_Validating);
            // 
            // txtCantidadExistente
            // 
            this.txtCantidadExistente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadExistente.Location = new System.Drawing.Point(193, 293);
            this.txtCantidadExistente.Name = "txtCantidadExistente";
            this.txtCantidadExistente.Size = new System.Drawing.Size(68, 29);
            this.txtCantidadExistente.TabIndex = 9;
            this.txtCantidadExistente.TextChanged += new System.EventHandler(this.txtCantidadExistente_TextChanged);
            this.txtCantidadExistente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadExistente_KeyPress);
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEstado.Font = new System.Drawing.Font("Arial", 14F);
            this.checkBoxEstado.Location = new System.Drawing.Point(289, 344);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(89, 26);
            this.checkBoxEstado.TabIndex = 12;
            this.checkBoxEstado.Text = "Estado";
            this.checkBoxEstado.UseVisualStyleBackColor = false;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(441, 147);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.ReadOnly = true;
            this.txtDepartamento.Size = new System.Drawing.Size(198, 29);
            this.txtDepartamento.TabIndex = 4;
            this.txtDepartamento.TextChanged += new System.EventHandler(this.txtDepartamento_TextChanged);
            this.txtDepartamento.Validating += new System.ComponentModel.CancelEventHandler(this.txtDepartamento_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(282, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 22);
            this.label10.TabIndex = 38;
            this.label10.Text = "Nombre Dpto.";
            // 
            // txtSuplidor
            // 
            this.txtSuplidor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuplidor.Location = new System.Drawing.Point(441, 196);
            this.txtSuplidor.Name = "txtSuplidor";
            this.txtSuplidor.ReadOnly = true;
            this.txtSuplidor.Size = new System.Drawing.Size(198, 29);
            this.txtSuplidor.TabIndex = 6;
            this.txtSuplidor.Validating += new System.ComponentModel.CancelEventHandler(this.txtSuplidor_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(282, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 22);
            this.label11.TabIndex = 40;
            this.label11.Text = "Nombre Suplidor";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidad.Location = new System.Drawing.Point(441, 245);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.ReadOnly = true;
            this.txtUnidad.Size = new System.Drawing.Size(198, 29);
            this.txtUnidad.TabIndex = 8;
            this.txtUnidad.Validating += new System.ComponentModel.CancelEventHandler(this.txtUnidad_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(285, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 22);
            this.label12.TabIndex = 42;
            this.label12.Text = "Unidad";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.linkLabel1.Location = new System.Drawing.Point(28, 103);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 22);
            this.linkLabel1.TabIndex = 44;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Código";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.linkLabel2.Location = new System.Drawing.Point(28, 156);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(123, 22);
            this.linkLabel2.TabIndex = 45;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Código Dpto.";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.linkLabel3.Location = new System.Drawing.Point(28, 202);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(147, 22);
            this.linkLabel3.TabIndex = 46;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Código Suplidor";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel4.Font = new System.Drawing.Font("Arial", 14.25F);
            this.linkLabel4.Location = new System.Drawing.Point(24, 253);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(136, 22);
            this.linkLabel4.TabIndex = 47;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Código Unidad";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // FormMantenimientoDeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 447);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSuplidor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBoxEstado);
            this.Controls.Add(this.txtCantidadExistente);
            this.Controls.Add(this.txtCodigoUnidad);
            this.Controls.Add(this.txtPunReo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodigoSuplidor);
            this.Controls.Add(this.txtCodigoDpto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.LabelonParent = "      Mantenimiento de productos";
            this.Name = "FormMantenimientoDeProducto";
            this.Text = "Mantenimiento de productos";
            this.Load += new System.EventHandler(this.FormMantenimientoDeProducto_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtCodigoDpto, 0);
            this.Controls.SetChildIndex(this.txtCodigoSuplidor, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtPunReo, 0);
            this.Controls.SetChildIndex(this.txtCodigoUnidad, 0);
            this.Controls.SetChildIndex(this.txtCantidadExistente, 0);
            this.Controls.SetChildIndex(this.checkBoxEstado, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtDepartamento, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtSuplidor, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txtUnidad, 0);
            this.Controls.SetChildIndex(this.linkLabel1, 0);
            this.Controls.SetChildIndex(this.linkLabel2, 0);
            this.Controls.SetChildIndex(this.linkLabel3, 0);
            this.Controls.SetChildIndex(this.linkLabel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoDpto;
        private System.Windows.Forms.TextBox txtCodigoSuplidor;
        private System.Windows.Forms.TextBox txtPunReo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoUnidad;
        private System.Windows.Forms.TextBox txtCantidadExistente;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSuplidor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
    }
}