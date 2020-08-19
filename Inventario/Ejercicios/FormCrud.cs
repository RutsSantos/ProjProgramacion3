using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using utCrud = Utilidades.Crud;

namespace Inventario {
    public partial class FormCrud : Form {
        public List<string> files = new List<string> ();

        public FormCrud () {
            InitializeComponent ();
        }

        private void button1_Click (object sender, EventArgs e) {
            string contenido = richTextBox1.Text;
            string nombre = textBox1.Text;

            Boolean isFileCreated = utCrud.CrearArchivo (nombre, contenido);
            if (isFileCreated) {
                MessageBox.Show ("Archivo creado correctamente!.");
                listView1.Items.Add (nombre);
            } else MessageBox.Show ("Error al crear el archivo");

        }

        private void button3_Click (object sender, EventArgs e) {
            ListViewItem item = listView1.SelectedItems[0];
            richTextBox1.Text = utCrud.LeerArchivo (item.Text);
            textBox1.Text = item.Text;
        }

        private void FormCrud_Load (object sender, EventArgs e) {
            DirectoryInfo di = new DirectoryInfo (@"C:\");
            foreach (var file in di.GetFiles ("*.txt")) {
                string nombre = file.Name.Replace (".txt", "");
                listView1.Items.Add (nombre);
            }
        }

        private void button2_Click (object sender, EventArgs e) {
            ListViewItem item = listView1.SelectedItems[0];

            Boolean isFileDelete = utCrud.BorrarArchivo (item.Text);
            if (isFileDelete) {
                MessageBox.Show ("Archivo borrado correctamente!.");
                listView1.Items.Remove (item);
            } else MessageBox.Show ("Error al borrar el archivo");

        }
    }
}