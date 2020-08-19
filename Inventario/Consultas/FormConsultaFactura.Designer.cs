namespace Inventario.Consultas {
    partial class FormConsultaFactura {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerInicial = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSuplidor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(9, 423);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Location = new System.Drawing.Point(9, 232);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.ep.SetIconAlignment(this.btnEliminar, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnEliminar.Location = new System.Drawing.Point(9, 481);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(232, 112);
            this.txtNombre.Size = new System.Drawing.Size(199, 29);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(253, 76);
            this.label2.Size = new System.Drawing.Size(162, 22);
            this.label2.Text = "Buscar por cliente";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.Location = new System.Drawing.Point(9, 292);
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.Location = new System.Drawing.Point(9, 351);
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1207, 0);
            this.panel1.Size = new System.Drawing.Size(141, 593);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.Location = new System.Drawing.Point(9, 539);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(304, 30);
            this.label1.Text = "    Consulta de Facturas";
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1336, 52);
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(445, 112);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(237, 29);
            this.txtProducto.TabIndex = 3;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducto_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(471, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "Buscar por producto";
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoFactura.Location = new System.Drawing.Point(17, 112);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(202, 29);
            this.txtNoFactura.TabIndex = 1;
            this.txtNoFactura.TextChanged += new System.EventHandler(this.txtSuplidor_TextChanged);
            this.txtNoFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoFactura_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "Buscar por No. Factura";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(17, 292);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 40;
            this.dataGridView.Size = new System.Drawing.Size(1172, 289);
            this.dataGridView.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(599, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "Buscar por rango de fecha";
            // 
            // dateTimePickerInicial
            // 
            this.dateTimePickerInicial.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerInicial.Font = new System.Drawing.Font("Arial", 14.25F);
            this.dateTimePickerInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInicial.Location = new System.Drawing.Point(565, 208);
            this.dateTimePickerInicial.Name = "dateTimePickerInicial";
            this.dateTimePickerInicial.Size = new System.Drawing.Size(155, 29);
            this.dateTimePickerInicial.TabIndex = 39;
            this.dateTimePickerInicial.ValueChanged += new System.EventHandler(this.dateTimePickerInicial_ValueChanged_1);
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerFinal.Font = new System.Drawing.Font("Arial", 14.25F);
            this.dateTimePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFinal.Location = new System.Drawing.Point(726, 208);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(155, 29);
            this.dateTimePickerFinal.TabIndex = 40;
            this.dateTimePickerFinal.ValueChanged += new System.EventHandler(this.dateTimePickerFinal_ValueChanged);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(701, 112);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(237, 29);
            this.txtDepartamento.TabIndex = 41;
            this.txtDepartamento.TextChanged += new System.EventHandler(this.txtDepartamento_TextChanged_1);
            this.txtDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepartamento_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(707, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 22);
            this.label4.TabIndex = 42;
            this.label4.Text = "Buscar por departamento";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidad.Location = new System.Drawing.Point(12, 208);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(260, 29);
            this.txtUnidad.TabIndex = 43;
            this.txtUnidad.TextChanged += new System.EventHandler(this.txtUnidad_TextChanged);
            this.txtUnidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnidad_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 22);
            this.label7.TabIndex = 44;
            this.label7.Text = "Buscar por unidad del producto";
            // 
            // txtSuplidor
            // 
            this.txtSuplidor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuplidor.Location = new System.Drawing.Point(297, 208);
            this.txtSuplidor.Name = "txtSuplidor";
            this.txtSuplidor.Size = new System.Drawing.Size(237, 29);
            this.txtSuplidor.TabIndex = 45;
            this.txtSuplidor.TextChanged += new System.EventHandler(this.txtSuplidor_TextChanged_1);
            this.txtSuplidor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSuplidor_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 22);
            this.label8.TabIndex = 46;
            this.label8.Text = "Buscar por suplidor";
            // 
            // FormConsultaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 593);
            this.Controls.Add(this.txtSuplidor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerFinal);
            this.Controls.Add(this.dateTimePickerInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNoFactura);
            this.Controls.Add(this.label5);
            this.LabelonParent = "    Consulta de Facturas";
            this.Name = "FormConsultaFactura";
            this.Text = "Consultas de Facturas";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtNoFactura, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtProducto, 0);
            this.Controls.SetChildIndex(this.dataGridView, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dateTimePickerInicial, 0);
            this.Controls.SetChildIndex(this.dateTimePickerFinal, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtDepartamento, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtUnidad, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtSuplidor, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtProducto;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtNoFactura;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicial;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        public System.Windows.Forms.TextBox txtDepartamento;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtUnidad;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtSuplidor;
        public System.Windows.Forms.Label label8;
    }
}