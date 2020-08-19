namespace Inventario {
    partial class FormNumeros {
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
            this.label1 = new System.Windows.Forms.Label ();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer ();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape ();
            this.label2 = new System.Windows.Forms.Label ();
            this.textBox1 = new System.Windows.Forms.TextBox ();
            this.label3 = new System.Windows.Forms.Label ();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox ();
            this.button1 = new System.Windows.Forms.Button ();
            this.button2 = new System.Windows.Forms.Button ();
            this.SuspendLayout ();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font ("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point (200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (263, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Números a voz/texto";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point (0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding (0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange (new Microsoft.VisualBasic.PowerPacks.Shape[] {
                this.lineShape1
            });
            this.shapeContainer1.Size = new System.Drawing.Size (649, 226);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 644;
            this.lineShape1.Y1 = 43;
            this.lineShape1.Y2 = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font ("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point (33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (141, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el número:";
            this.label2.Click += new System.EventHandler (this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point (196, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size (193, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font ("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point (34, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Texto:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point (102, 141);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size (517, 67);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point (483, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size (136, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Escuchar en voz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler (this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point (404, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size (59, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Convertir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler (this.button2_Click);
            // 
            // FormNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (649, 226);
            this.Controls.Add (this.button2);
            this.Controls.Add (this.button1);
            this.Controls.Add (this.richTextBox1);
            this.Controls.Add (this.label3);
            this.Controls.Add (this.textBox1);
            this.Controls.Add (this.label2);
            this.Controls.Add (this.label1);
            this.Controls.Add (this.shapeContainer1);
            this.Name = "FormNumeros";
            this.Text = "Numeros a voz/texto";
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}