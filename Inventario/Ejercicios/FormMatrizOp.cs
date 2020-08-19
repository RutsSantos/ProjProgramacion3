using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using utMatrices = Utilidades.Matrices;
using utNumeros = Utilidades.Numeros;

namespace Inventario {
    public partial class FormMatrizOp : Form {
        public FormMatrizOp () {
            InitializeComponent ();
        }

        private void label4_Click (object sender, EventArgs e) {

        }

        private void formMatrizOp_Load (object sender, EventArgs e) {
            int[, ] m4 = utMatrices.matriz4 ();
            int sumatoria = utMatrices.sum (m4);
            richTextBox1.Text = utMatrices.getTextMatriz (m4);

            label5.Text = utMatrices.cantPrimo (m4).ToString ();
            label6.Text = sumatoria.ToString ();
            richTextBox2.Text = utNumeros.ConvertirATexto (sumatoria);
            label7.Text = utMatrices.mayor (m4).ToString ();
        }

        private void button1_Click (object sender, EventArgs e) {
            int[, ] m4 = utMatrices.matriz4 ();
            int num = utMatrices.sum (m4);

            string numToVoiceText = utNumeros.ConvertirATexto (num);

            try {
                utNumeros.ConvertirAVoz (numToVoiceText);
            } catch (Exception) {
                MessageBox.Show ("Ha ocurrido un error al tratar de reproducir en voz.");
                throw;

            }
        }

        private void button2_Click (object sender, EventArgs e) {
            this.Close ();
        }
    }
}