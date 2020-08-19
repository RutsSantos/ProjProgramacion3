namespace Inventario {
    partial class FormCrud {
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
            this.components = new System.ComponentModel.Container ();
            this.button1 = new System.Windows.Forms.Button ();
            this.button2 = new System.Windows.Forms.Button ();
            this.button3 = new System.Windows.Forms.Button ();
            this.listView1 = new System.Windows.Forms.ListView ();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox ();
            this.label1 = new System.Windows.Forms.Label ();
            this.textBox1 = new System.Windows.Forms.TextBox ();
            this.errorProvider = new System.Windows.Forms.ErrorProvider (this.components);
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider)).BeginInit ();
            this.SuspendLayout ();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point (32, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size (92, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler (this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point (32, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size (92, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler (this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point (32, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size (92, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Abrir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler (this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point (32, 32);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size (92, 163);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point (158, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size (307, 239);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point (158, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del archivo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point (267, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size (198, 20);
            this.textBox1.TabIndex = 6;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (492, 328);
            this.Controls.Add (this.textBox1);
            this.Controls.Add (this.label1);
            this.Controls.Add (this.richTextBox1);
            this.Controls.Add (this.listView1);
            this.Controls.Add (this.button3);
            this.Controls.Add (this.button2);
            this.Controls.Add (this.button1);
            this.Name = "FormCrud";
            this.Text = "CRUD";
            this.Load += new System.EventHandler (this.FormCrud_Load);
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider)).EndInit ();
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}