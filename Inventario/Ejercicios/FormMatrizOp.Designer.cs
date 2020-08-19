namespace Inventario {
    partial class FormMatrizOp {
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox ();
            this.label1 = new System.Windows.Forms.Label ();
            this.label2 = new System.Windows.Forms.Label ();
            this.label3 = new System.Windows.Forms.Label ();
            this.label4 = new System.Windows.Forms.Label ();
            this.label5 = new System.Windows.Forms.Label ();
            this.label6 = new System.Windows.Forms.Label ();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox ();
            this.label7 = new System.Windows.Forms.Label ();
            this.button1 = new System.Windows.Forms.Button ();
            this.button2 = new System.Windows.Forms.Button ();
            this.SuspendLayout ();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point (26, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size (295, 227);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point (357, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (357, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sumatoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point (357, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Letras:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point (357, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size (79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero Mayor:";
            this.label4.Click += new System.EventHandler (this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point (403, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size (35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point (431, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size (35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point (406, 117);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size (151, 77);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point (465, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size (35, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "label7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point (468, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size (75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hablar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler (this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point (26, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size (75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler (this.button2_Click);
            // 
            // formMatrizOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (613, 419);
            this.Controls.Add (this.button2);
            this.Controls.Add (this.button1);
            this.Controls.Add (this.label7);
            this.Controls.Add (this.richTextBox2);
            this.Controls.Add (this.label6);
            this.Controls.Add (this.label5);
            this.Controls.Add (this.label4);
            this.Controls.Add (this.label3);
            this.Controls.Add (this.label2);
            this.Controls.Add (this.label1);
            this.Controls.Add (this.richTextBox1);
            this.Name = "formMatrizOp";
            this.Text = "formMatrizOp";
            this.Load += new System.EventHandler (this.formMatrizOp_Load);
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}