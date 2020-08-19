using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Inventario;
using Execution = Utilidades.ExecutionDB;
using System.Reflection;

namespace Inventario {
    public partial class FormLogin : Form {
        public FormLogin () {
            InitializeComponent ();
        }

        public DataSet DS = new DataSet ();
        public ErrorProvider ep = new ErrorProvider ();
        public string clearString (TextBox str) {
            if (string.IsNullOrEmpty (str.Text)) return "";
            return str.Text.Trim ();
        }
        public void Limpiar () {
            txtContrasena.Text = "";
            txtUsuario.Text = "";
            txtUsuario.Focus ();
        }

        public void displayMenu () {
            this.Hide ();
            FormMenu Menu = new FormMenu ();
            Menu.Closed += (s, args) => this.Close ();
            Menu.Show ();
            string nombre = txtUsuario.Text.Trim ();
            MessageBox.Show ("Bienvenido al INVENTARIO M&R " + nombre);
        }

        public string makeProcedure () {
            string usuario = clearString (txtUsuario);
            string contrasena = clearString (txtContrasena);
            string storeProcedureUpsertCliente = string.Format ("EXEC consultarUsuario @contrasena = '{0}', @nombre_usuario = '{1}'", contrasena, usuario);
            return storeProcedureUpsertCliente;
        }

        public void checkUsuarios () {
            string query = makeProcedure ();
            DS = Execution.Ejecutar (query);
            int countTable = DS.Tables.Count;
            int countRows = DS.Tables[0].Rows.Count;
            bool existeUsuario = countTable > 0 && countRows > 0;
            if (existeUsuario) {
                displayMenu ();
            } else {
                MessageBox.Show ("Por favor revise los datos ingresados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar ();
            }
        }

        public void login () {
            if (Controles.ValidarForm (this, ep, false)) return;
            checkUsuarios ();
        }

        private void btnEntrar_Click (object sender, EventArgs e) {
            login ();
        }

        private void button1_Click (object sender, EventArgs e) {
            Dispose ();
        }

        private void comboBoxGenero_KeyPress (object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void txtContrasena_Enter (object sender, EventArgs e) {

        }

    }
}