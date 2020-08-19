using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Execution = Utilidades.ExecutionDB;
using Inventario.Consultas;

namespace Inventario.Mantenimiento {
    public partial class FormMantenimientoDeProducto : FormMantenimiento {
        public FormMantenimientoDeProducto () {
            InitializeComponent ();
        }

        public void consultarDepartamento () {
            FormConsultaDeDepartamento ConsultaDeDepartamento = new FormConsultaDeDepartamento ();
            if (ConsultaDeDepartamento.ShowDialog () == DialogResult.OK) {
                txtCodigoDpto.Text = ConsultaDeDepartamento.Codigo;
                SendKeys.Send ("{TAB}");
            }
            ConsultaDeDepartamento.Dispose ();
            searchDataForegin ("departamento", "nombre_departamento", "codigo_departamento", txtCodigoDpto, txtDepartamento);

        }

        public void consultarSuplidor () {
            FormConsultaDeSuplidor ConsultaDeSuplidor = new FormConsultaDeSuplidor ();
            if (ConsultaDeSuplidor.ShowDialog () == DialogResult.OK) {
                txtCodigoSuplidor.Text = ConsultaDeSuplidor.Codigo;
                SendKeys.Send ("{TAB}");
            }
            ConsultaDeSuplidor.Dispose ();
            searchDataForegin ("suplidor", "nombre_suplidor", "codigo_suplidor", txtCodigoSuplidor, txtSuplidor);

        }

        public void consultarUnidad () {
            FormConsultaDeUnidad ConsultaDeUnidad = new FormConsultaDeUnidad ();
            if (ConsultaDeUnidad.ShowDialog () == DialogResult.OK) {
                txtCodigoUnidad.Text = ConsultaDeUnidad.Codigo;
                SendKeys.Send ("{TAB}");
            }
            ConsultaDeUnidad.Dispose ();
            searchDataForegin ("unidad", "nombre_unidad", "codigo_unidad", txtCodigoUnidad, txtUnidad);

        }

        public void searchDataForegin (string tableName, string columna, string where, TextBox TextCodigo, TextBox TextName) {
            string value = clearString (TextCodigo);
            if (string.IsNullOrEmpty (value)) return;
            string query = string.Format ("SELECT {0} FROM {1} WHERE {2} = {3}", columna, tableName, where, value);
            DS = Execution.Ejecutar (query);
            int countTable = DS.Tables.Count;
            int countRows = DS.Tables[0].Rows.Count;
            if (countTable > 0 && countRows > 0) {
                DataRow row = DS.Tables[0].Rows[0];
                TextName.Text = row[columna].ToString ();
            } else {
                MessageBox.Show ("No se encuentra dicho codigo");
                TextCodigo.Text = "";
                TextName.Text = "";
            }

        }

        public override void Limpiar () {
            txtNombre.Text = "";
            txtCodigoDpto.Text = "";
            txtCodigoSuplidor.Text = "";
            txtCantidadExistente.Text = "";
            txtPunReo.Text = "";
            txtCodigoUnidad.Text = "";
            txtPrecio.Text = "";
            checkBoxEstado.Checked = false;
            txtCodigo.Text = "";
            txtSuplidor.Text = "";
            txtUnidad.Text = "";
            txtDepartamento.Text = "";
        }

        public bool validatePuntoDeReorden () {
            float punto_reo = float.Parse (clearString (txtPunReo));
            float cantidadExistente = float.Parse (clearString (txtCantidadExistente));
            return cantidadExistente <= punto_reo;
        }

        public string makeStoreProcedure () {
            string codigo = clearString (txtCodigo);
            string nombre = clearString (txtNombre);
            string codigoDepartamento = clearString (txtCodigoDpto);
            string codigoSuplidor = clearString (txtCodigoSuplidor);
            string cantidadExistente = clearString (txtCantidadExistente);
            string punto_reo = clearString (txtPunReo);
            string codigoUnidad = clearString (txtCodigoUnidad);
            string estado = (checkBoxEstado.Checked) ? "1" : "0";
            string precio = clearString (txtPrecio);
            string storeProcedureUpsertProducto = string.Format ("EXEC upsertProducto @codigo_producto = {0}, @nombre_producto = '{1}',@codigo_departamento = {2}, @codigo_suplidor = {3}, @cantidad_existente = {4}, @punto_reo = {5}, @codigo_unidad = {6}, @estado = {7},  @precio_de_venta = {8}", codigo, nombre, codigoDepartamento, codigoSuplidor, cantidadExistente, punto_reo, codigoUnidad, estado, precio);
            return storeProcedureUpsertProducto;

        }

        public override void Salvar () {
            if (Controles.ValidarForm (this, ep, false)) return;
            if (validatePuntoDeReorden ()) { messageExlamation ("El producto no supera el punto de reoden"); return; }
            string storeProcedureUpsertProducto = makeStoreProcedure ();
            DS = Execution.Ejecutar (storeProcedureUpsertProducto);
            messageSucess ();
            Limpiar ();
        }

        public void fillCampos (DataSet DS) {
            DataRow row = DS.Tables[0].Rows[0];
            txtNombre.Text = row["nombre_producto"].ToString ();
            txtCodigoDpto.Text = row["codigo_departamento"].ToString ();
            txtCodigoSuplidor.Text = row["codigo_suplidor"].ToString ();
            txtCantidadExistente.Text = row["cantidad_existente"].ToString ();
            txtPunReo.Text = row["punto_reo"].ToString ();
            txtCodigoUnidad.Text = row["codigo_unidad"].ToString ();
            txtPrecio.Text = row["precio_de_venta"].ToString ();
            checkBoxEstado.Checked = Convert.ToBoolean (row["estado"].ToString ());
            searchDataForegin ("departamento", "nombre_departamento", "codigo_departamento", txtCodigoDpto, txtDepartamento);
            searchDataForegin ("suplidor", "nombre_suplidor", "codigo_suplidor", txtCodigoSuplidor, txtSuplidor);
            searchDataForegin ("unidad", "nombre_unidad", "codigo_unidad", txtCodigoUnidad, txtUnidad);
        }

        public void Consulta () {
            string codigo = txtCodigo.Text.Trim ();
            if (string.IsNullOrEmpty (codigo)) return;

            string storeProcedureConsultarProducto = string.Format ("EXEC consultarProducto {0}", codigo);
            DS = Execution.Ejecutar (storeProcedureConsultarProducto);
            int countTable = DS.Tables.Count;
            int countRows = DS.Tables[0].Rows.Count;
            if (countTable > 0 && countRows > 0) {
                fillCampos (DS);
            }
        }

        public override void Consultar () {
            FormConsultaProducto ConsultaDeProducto = new FormConsultaProducto ();
            if (ConsultaDeProducto.ShowDialog () == DialogResult.OK) {
                txtCodigo.Text = ConsultaDeProducto.Codigo;
                SendKeys.Send ("{TAB}");
            }
            ConsultaDeProducto.Dispose ();
        }

        public void focus () {
            txtCodigo.Focus ();
        }

        public override void Eliminar () {
            string codigo = clearString (txtCodigo);
            if (!string.IsNullOrEmpty (codigo)) {
                string storeProcedureEliminarProducto = string.Format ("EXEC eliminarProducto {0}", codigo);
                DialogResult dialogResult = MessageBox.Show ("Estas seguro de que desea eliminar este producto?\nSi lo hace todo registro relacionado a dicho producto igualmente sera eliminado.\nUna opcion es cambiarle su estado a inactivo", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes) {
                    DS = Execution.Ejecutar (storeProcedureEliminarProducto);
                    messageWarning ();
                    Limpiar ();
                    focus ();
                }

            } else {
                messageExlamation ("No ha especificado que Producto desea eliminar");
            }
        }

        public override void onlyInteger (object sender, KeyPressEventArgs e) {
            base.onlyInteger (sender, e);
        }

        private void label2_Click (object sender, EventArgs e) {

        }

        private void txtNombre_TextChanged (object sender, EventArgs e) {

        }

        private void label6_Click (object sender, EventArgs e) {

        }

        private void textBox2_TextChanged (object sender, EventArgs e) {

        }

        private void btnSalvar_Click (object sender, EventArgs e) {
            Salvar ();
        }

        private void txtCodigo_KeyPress (object sender, KeyPressEventArgs e) {
            onlyInteger (sender, e);
        }

        private void txtCodigoDpto_KeyPress (object sender, KeyPressEventArgs e) {
            onlyInteger (sender, e);
        }

        private void txtCodigoSuplidor_TextChanged (object sender, EventArgs e) {
            searchDataForegin ("suplidor", "nombre_suplidor", "codigo_suplidor", txtCodigoSuplidor, txtSuplidor);
        }

        private void txtCodigoSuplidor_KeyPress (object sender, KeyPressEventArgs e) {
            onlyInteger (sender, e);
        }

        private void txtCodigoUnidad_KeyPress (object sender, KeyPressEventArgs e) {
            onlyInteger (sender, e);
        }

        private void txtPrecio_KeyPress (object sender, KeyPressEventArgs e) {
            onlyFloat (sender, e, txtPrecio);
        }

        private void txtCantidadExistente_KeyPress (object sender, KeyPressEventArgs e) {
            onlyFloat (sender, e, txtCantidadExistente);
        }

        private void btnEliminar_Click (object sender, EventArgs e) {
            Eliminar ();
        }

        private void buttonCerrar_Click (object sender, EventArgs e) {
            Dispose ();
        }

        private void btnBuscar_Click (object sender, EventArgs e) {
            Consultar ();
        }

        private void txtCodigo_Validating (object sender, CancelEventArgs e) {
            Consulta ();
        }

        private void txtDepartamento_Validating (object sender, CancelEventArgs e) {

        }

        private void txtSuplidor_Validating (object sender, CancelEventArgs e) {

        }

        private void txtUnidad_Validating (object sender, CancelEventArgs e) {

        }

        private void txtCodigoDpto_Validating (object sender, CancelEventArgs e) {
            searchDataForegin ("departamento", "nombre_departamento", "codigo_departamento", txtCodigoDpto, txtDepartamento);
        }

        private void txtCodigoSuplidor_Validating (object sender, CancelEventArgs e) {
            searchDataForegin ("suplidor", "nombre_suplidor", "codigo_suplidor", txtCodigoSuplidor, txtSuplidor);
        }

        private void txtCodigoUnidad_Validating (object sender, CancelEventArgs e) {
            searchDataForegin ("unidad", "nombre_unidad", "codigo_unidad", txtCodigoUnidad, txtUnidad);
        }

        private void txtDepartamento_TextChanged (object sender, EventArgs e) {

        }

        private void linkLabel1_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e) {
            Consultar ();
        }

        private void txtCodigo_TextChanged (object sender, EventArgs e) {
            string codigo = clearString (txtCodigo);
            if (string.IsNullOrEmpty (codigo)) {
                Limpiar ();
            } else {
                SendKeys.Send ("{TAB}");
            }
        }

        private void txtPunReo_KeyPress (object sender, KeyPressEventArgs e) {
            onlyFloat (sender, e, txtPunReo);
        }

        private void linkLabel4_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e) {
            consultarUnidad ();
        }

        private void linkLabel3_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e) {
            consultarSuplidor ();
        }

        private void linkLabel2_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e) {
            consultarDepartamento ();
        }

        private void txtCodigoDpto_TextChanged (object sender, EventArgs e) {
            searchDataForegin ("departamento", "nombre_departamento", "codigo_departamento", txtCodigoDpto, txtDepartamento);
        }

        private void txtCodigoUnidad_TextChanged (object sender, EventArgs e) {
            searchDataForegin ("unidad", "nombre_unidad", "codigo_unidad", txtCodigoUnidad, txtUnidad);
        }

        private void txtCantidadExistente_TextChanged (object sender, EventArgs e) {
            limitadorDeCantidad (sender, e, "El numero muximo de existencia de un producto es ", 190);
        }

        private void txtPrecio_TextChanged (object sender, EventArgs e) {
            limitadorDeCantidad (sender, e, "El mayor precio que puede tener un producto es de ", 1000);
        }

        private void txtPunReo_TextChanged (object sender, EventArgs e) {
            limitadorDeCantidad (sender, e, "El maximo punto de reorden es de ", 20);
        }

        private void FormMantenimientoDeProducto_Load (object sender, EventArgs e) {

        }

        private void txtNombre_KeyPress (object sender, KeyPressEventArgs e) {
            onlyString (sender, e);
        }
    }
}