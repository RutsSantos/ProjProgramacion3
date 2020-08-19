using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using utMatriz = Utilidades.Matrices;

namespace Inventario {
    public partial class FormMatrices : Form {
        public FormMatrices () {
            InitializeComponent ();
        }

        private void button1_Click (object sender, EventArgs e) {
            int[, ] m1 = utMatriz.matriz1 ();
            richTextBox1.Text = utMatriz.getTextMatriz (m1);
        }

        private void button2_Click (object sender, EventArgs e) {
            int[, ] m2 = utMatriz.matriz2 ();
            richTextBox1.Text = utMatriz.getTextMatriz (m2);
        }

        private void button3_Click (object sender, EventArgs e) {
            int[, ] m3 = utMatriz.matriz3 ();
            richTextBox1.Text = utMatriz.getTextMatriz (m3);
        }
    }
}