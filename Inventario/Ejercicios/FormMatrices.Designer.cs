namespace Inventario {
    partial class FormMatrices {
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
            this.button1 = new System.Windows.Forms.Button ();
            this.button2 = new System.Windows.Forms.Button ();
            this.button3 = new System.Windows.Forms.Button ();
            this.label1 = new System.Windows.Forms.Label ();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer ();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape ();
            this.SuspendLayout ();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point (127, 80);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size (224, 151);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point (53, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size (75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Matriz 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler (this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point (201, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size (75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Matriz 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler (this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point (346, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size (75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Matriz 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler (this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font ("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point (168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (129, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matrices";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point (0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding (0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange (new Microsoft.VisualBasic.PowerPacks.Shape[] {
                this.lineShape1
            });
            this.shapeContainer1.Size = new System.Drawing.Size (471, 329);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -1;
            this.lineShape1.X2 = 470;
            this.lineShape1.Y1 = 51;
            this.lineShape1.Y2 = 51;
            // 
            // FormMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (471, 329);
            this.Controls.Add (this.label1);
            this.Controls.Add (this.button3);
            this.Controls.Add (this.button2);
            this.Controls.Add (this.button1);
            this.Controls.Add (this.richTextBox1);
            this.Controls.Add (this.shapeContainer1);
            this.Name = "FormMatrices";
            this.Text = "Matrices";
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}