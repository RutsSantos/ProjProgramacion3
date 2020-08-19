using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Execution = Utilidades.ExecutionDB;
using System.Globalization;

namespace Inventario {
    public partial class FormMantenimientoDeCliente : FormMantenimiento {
        public FormMantenimientoDeCliente () {
            InitializeComponent ();
            dateTimePickerFechaNacimiento.Value = DateTime.Today.AddDays (-1);
        }

        public void focus () {
            txtCodigo.Focus ();
        }

        public override void Consultar () {
            FormConsultaDeCliente ConsultaDeCliente = new FormConsultaDeCliente ();
            if (ConsultaDeCliente.ShowDialog () == DialogResult.OK) {
                txtCodigo.Text = ConsultaDeCliente.Codigo;
            }
            ConsultaDeCliente.Dispose ();
        }

        public override void Limpiar () {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            checkBoxEstado.Checked = false;
            comboBoxGenero.Text = "Selecciona un género";
            dateTimePickerFechaNacimiento.Value = DateTime.Today.AddDays (-1);
        }

        public void fillCampos (DataSet DS) {
            DataRow row = DS.Tables[0].Rows[0];
            txtNombre.Text = row["nombre_cliente"].ToString ().Trim ();
            txtEmail.Text = row["email"].ToString ().Trim ();
            txtTelefono.Text = row["telefono"].ToString ();
            checkBoxEstado.Checked = Convert.ToBoolean (row["estado"]);
            comboBoxGenero.Text = row["sexo"].ToString ().Trim ();
            string fechaNacimiento = row["fecha_de_nacimiento"].ToString ().Trim ();
            string date = Convert.ToDateTime (fechaNacimiento).ToString ("yyyy-MM-dd", CultureInfo.InvariantCulture);
            dateTimePickerFechaNacimiento.Value = DateTime.ParseExact (date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        public void Consulta () {
            string codigo = txtCodigo.Text.Trim ();
            if (string.IsNullOrEmpty (codigo)) return;

            string storeProcedureConsultarCliente = string.Format ("EXEC consultarCliente {0}", codigo);
            DS = Execution.Ejecutar (storeProcedureConsultarCliente);
            int countTable = DS.Tables.Count;
            int countRows = DS.Tables[0].Rows.Count;

            if (countTable > 0 && countRows > 0) {
                fillCampos (DS);
            }

        }

        public string makeProcedure () {
            string nombre = clearString (txtNombre);
            string genero = comboBoxGenero.Text;
            string email = clearString (txtEmail);
            string codigo = clearString (txtCodigo);
            string telefono = txtTelefono.Text;
            string estado = (checkBoxEstado.Checked) ? "1" : "0";
            string fechaNacimiento = dateTimePickerFechaNacimiento.Value.Date.ToString ("yyyy-MM-dd");
            string storeProcedureUpsertCliente = string.Format ("EXEC upsertCliente @codigo_cliente = {0}, @nombre_cliente = '{1}', @sexo = '{2}', @email = '{3}', @telefono = '{4}', @estado = {5}, @fecha_de_nacimiento = '{6}'", codigo, nombre, genero, email, telefono, estado, fechaNacimiento);
            return storeProcedureUpsertCliente;
        }

        public override void Salvar () {

            if (Controles.ValidarForm (this, ep, false)) return;
            string email = clearString (txtEmail);
            string storeProcedureUpsertCliente = makeProcedure ();
            bool isValidCamposEspeciales = validarCamposEspeciales (dateTimePickerFechaNacimiento, comboBoxGenero, email, txtTelefono);
            if (isValidCamposEspeciales) {
                DS = Execution.Ejecutar (storeProcedureUpsertCliente);
                messageSucess ();
                Limpiar ();
                focus ();
            }

        }

        public override void Eliminar () {
            string codigo = clearString (txtCodigo);
            if (!string.IsNullOrEmpty (codigo)) {
                string storeProcedureEliminarCliente = string.Format ("EXEC eliminarCliente {0}", codigo);
                DialogResult dialogResult = MessageBox.Show ("Estas seguro de que desea eliminar este cliente?\nSi lo hace todo registro relacionado a dicha persona igualmente sera eliminado.\nUna opcion es cambiarle su estado a ainactivo", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes) {
                    DS = Execution.Ejecutar (storeProcedureEliminarCliente);
                    messageWarning ();
                    Limpiar ();
                    focus ();
                }

            } else {
                messageExlamation ("No ha especificado que Cliente desea eliminar");
            }
        }

        public override void onlyInteger (object sender, KeyPressEventArgs e) {
            base.onlyInteger (sender, e);
        }

        public override string clearString (TextBox str) {
            return base.clearString (str);
        }

        private void btnSalvar_Click (object sender, EventArgs e) {
            Salvar ();
        }

        private void txtCodigo_KeyPress (object sender, KeyPressEventArgs e) {
            onlyInteger (sender, e);
        }

        private void txtCodigo_Validating (object sender, CancelEventArgs e) {
            Consulta ();
        }

        private void btnEliminar_Click (object sender, EventArgs e) {
            Eliminar ();
        }

        private void btnBuscar_Click (object sender, EventArgs e) {
            Consultar ();
        }

        private void buttonCerrar_Click (object sender, EventArgs e) {
            Dispose ();
        }

        private void txtCodigo_TextChanged (object sender, EventArgs e) {
            string codigo = clearString (txtCodigo);
            if (string.IsNullOrEmpty (codigo)) {
                Limpiar ();
            } else {
                SendKeys.Send ("{TAB}");
            }
        }

        private void linkLabel1_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e) {
            Consultar ();
        }

        private void comboBoxGenero_KeyPress (object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void label3_Click (object sender, EventArgs e) {

        }

        private void checkBoxEstado_CheckedChanged (object sender, EventArgs e) {

        }

        private void dateTimePickerFechaNacimiento_ValueChanged (object sender, EventArgs e) {

        }

        private void comboBoxGenero_SelectedIndexChanged (object sender, EventArgs e) {

        }

        private void txtNombre_TextChanged (object sender, EventArgs e) {

        }

        private void txtNombre_KeyPress (object sender, KeyPressEventArgs e) {
            onlyString (sender, e);
        }

    }
}