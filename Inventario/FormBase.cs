using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Inventario {
    public partial class FormBase : Form {
        public bool puedeSalvar { set; get; }
        public bool puedeEliminar { set; get; }
        public bool puedeConsultar { set; get; }
        public bool puedeImprimir { set; get; }
        public string LabelonParent {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public DataSet DS = new DataSet ();
        public ErrorProvider ep = new ErrorProvider ();

        public FormBase () {
            InitializeComponent ();
            buttonCerrar.FlatStyle = FlatStyle.Flat;
        }

        public virtual void messageExlamation (string messageTxt) {
            MessageBox.Show (messageTxt, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        public virtual void messageSucess () {
            MessageBox.Show ("Accion realizada con exito", "Accion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public virtual void limitadorDeCantidad (object sender, EventArgs e, string message, int cantidad) {
            var textbox = sender as TextBox;
            int value;
            if (int.TryParse (textbox.Text, out value)) {
                if (value > cantidad) {
                    messageExlamation (message + cantidad);
                    textbox.Text = cantidad + "";
                } else if (value < 0) {
                    textbox.Text = "0";
                }
            }
        }

        public virtual float removeMoneySymbol (string value) {
            value = value.Trim ();
            string symbol = "RD$";
            return float.Parse (value.Replace (symbol, ""));

        }

        public virtual string addMoneySymbol (string value) {
            value = value.Trim ();
            string symbol = "RD$";
            return string.Format ("{0}{1}", symbol, value);
        }

        public virtual void messageWarning () {
            MessageBox.Show ("Acaba de eliminar dicho elemento", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public virtual void Limpiar () {
            MessageBox.Show ("Limpiando");
        }

        public virtual void Salvar () {
            MessageBox.Show ("Salvando...");
        }

        public virtual void Eliminar () {
            MessageBox.Show ("Eliminando...");
        }

        public virtual void Consultar () {
            MessageBox.Show ("Consultando...");
        }

        public virtual void Imprimir () {
            MessageBox.Show ("Imprimiendo...");
        }
        public virtual bool validarCamposEspeciales (DateTimePicker fecha, ComboBox combobox, string email, MaskedTextBox phone) {
            return isValidDate (fecha) && isValidComboBox (combobox) && isValidEmail (email) && isValidPhone (phone);

        }
        public virtual bool isValidEmail (string email) {
            try {
                var addr = new System.Net.Mail.MailAddress (email);
                return addr.Address == email;
            } catch {
                messageExlamation ("El email que ingreso no es valido");
                return false;
            }
        }

        public virtual bool checkFechaCaucidad () {
            return true;
        }

        public virtual bool isValidDate (DateTimePicker fecha) {
            int anoDeNacimiento = DateTime.Parse (fecha.Text).Year;
            int anoDeActual = DateTime.Today.Year;
            int edad = anoDeActual - anoDeNacimiento;
            bool isValid = edad > 18;
            if (!isValid) {
                messageExlamation ("Solamente aceptamos personas mayores de edad");
            }
            return isValid;

        }

        public virtual bool isValidComboBox (ComboBox combobox) {
            string genero = combobox.Text;
            bool isValid = genero == "Masculino" || genero == "Femenino";
            if (!isValid) {
                messageExlamation ("Debe de elegir un genero");
            }
            return isValid;
        }

        public virtual bool isValidPhone (MaskedTextBox phone) {
            bool isValid = phone.MaskCompleted;
            if (!isValid) {
                messageExlamation ("Debe de completar el campo telefono");
            }
            return isValid;
        }

        public virtual string clearString (TextBox str) {
            if (string.IsNullOrEmpty (str.Text)) return "";
            return str.Text.Trim ();
        }

        public virtual void onlyInteger (object sender, KeyPressEventArgs e) {
            if (!char.IsControl (e.KeyChar) && !char.IsDigit (e.KeyChar)) {
                e.Handled = true;
            }

            if (((sender as TextBox).Text.IndexOf ('.') > -1)) {
                e.Handled = true;
            }

        }

        public virtual void onlyString (object sender, KeyPressEventArgs e) {
            if (!char.IsLetter (e.KeyChar) && !char.IsControl (e.KeyChar) && !char.IsWhiteSpace (e.KeyChar)) { e.Handled = true; }
        }

        public virtual void onlyFloat (object sender, KeyPressEventArgs e, TextBox txtBox) {
            if (!char.IsControl (e.KeyChar) &&
                !char.IsDigit (e.KeyChar) &&
                e.KeyChar != '.') {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' &&
                (sender as TextBox).Text.IndexOf ('.') > -1) {
                e.Handled = true;
            }

        }

        private void buttonCerrar_Click (object sender, EventArgs e) {

        }

        private void FormBase_Load (object sender, EventArgs e) {

        }

        private void panel2_Paint (object sender, PaintEventArgs e) {

        }

        private void buttonCerrar_Click_1 (object sender, EventArgs e) {
            Dispose ();
        }

        private void label1_Click (object sender, EventArgs e) {

        }

        private void panel2_Paint_1 (object sender, PaintEventArgs e) {

        }

        private void FormBase_FormClosed (object sender, FormClosedEventArgs e) {
            Application.Exit ();
        }

    }
}