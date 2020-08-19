using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using utPrimos = Utilidades.Primos;

namespace Inventario {
    public partial class FormPrimos : Form {
        public FormPrimos () {
            InitializeComponent ();
        }

        private void button1_Click (object sender, EventArgs e) {
            int n = 1;
            try {
                n = Convert.ToInt32 (textBox1.Text);
            } catch (Exception) {

                MessageBox.Show ("Ingrese un numero valido.");
                return;
            }

            Boolean isPrime = utPrimos.isPrime (n);
            string textToShow = isPrime ? "es primo" : "no es primo";
            richTextBox1.Text = "El número " + textBox1.Text + " " + textToShow;
        }

        private void button2_Click_1 (object sender, EventArgs e) {
            richTextBox1.Text = utPrimos.getFirstPrimes (100);
        }
    }
}