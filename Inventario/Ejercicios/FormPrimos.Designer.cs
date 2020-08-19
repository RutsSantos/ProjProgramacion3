namespace Inventario {
    partial class FormPrimos {
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
            this.textBox1 = new System.Windows.Forms.TextBox ();
            this.button1 = new System.Windows.Forms.Button ();
            this.label2 = new System.Windows.Forms.Label ();
            this.button2 = new System.Windows.Forms.Button ();
            this.label3 = new System.Windows.Forms.Label ();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox ();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer ();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape ();
            this.SuspendLayout ();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font ("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point (27, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point (107, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size (100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font ("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.Location = new System.Drawing.Point (231, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size (75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Es primo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler (this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (28, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (0, 13);
            this.label2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point (333, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size (100, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Primeros 100";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler (this.button2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font ("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point (150, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (168, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Números primos";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point (31, 129);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size (402, 203);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point (0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding (0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange (new Microsoft.VisualBasic.PowerPacks.Shape[] {
                this.lineShape1
            });
            this.shapeContainer1.Size = new System.Drawing.Size (460, 364);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 3;
            this.lineShape1.X2 = 456;
            this.lineShape1.Y1 = 51;
            this.lineShape1.Y2 = 51;
            // 
            // FormPrimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (460, 364);
            this.Controls.Add (this.richTextBox1);
            this.Controls.Add (this.label3);
            this.Controls.Add (this.button2);
            this.Controls.Add (this.label2);
            this.Controls.Add (this.button1);
            this.Controls.Add (this.textBox1);
            this.Controls.Add (this.label1);
            this.Controls.Add (this.shapeContainer1);
            this.Name = "FormPrimos";
            this.Text = "Primos";
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}