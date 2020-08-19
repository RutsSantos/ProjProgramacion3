using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using utNumeros = Utilidades.Numeros;

namespace Inventario {
    public partial class FormNumeros : Form {
        public FormNumeros () {
            InitializeComponent ();
        }

        private void label2_Click (object sender, EventArgs e) {

        }

        private void button2_Click (object sender, EventArgs e) {
            long num = 0;
            try {
                num = Convert.ToInt64 (textBox1.Text);
            } catch (Exception) {
                MessageBox.Show ("Ingrese un número valido.");
            }

            string numToText = utNumeros.ConvertirATexto (num, false);
            richTextBox1.Text = numToText;
        }

        private void button1_Click (object sender, EventArgs e) {
            long num = 0;
            try {
                num = Convert.ToInt64 (textBox1.Text);
            } catch (Exception) {
                MessageBox.Show ("Ingrese un número valido.");
            }

            string numToVoiceText = utNumeros.ConvertirATexto (num);
            try {
                utNumeros.ConvertirAVoz (numToVoiceText);
            } catch (Exception) {
                MessageBox.Show ("Ha ocurrido un error al tratar de reproducir en voz.");
                throw;

            }
        }

    }
}