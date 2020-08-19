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
using Inventario.Reportes;

namespace Inventario.Procesos {
    public partial class FormProcesosVentas : FormProcesos {
        DataTable table = new DataTable ();

        public FormProcesosVentas () {
            InitializeComponent ();
            txtTotal.Text = addMoneySymbol ("0");
        }

        public void activarProducto () {
            string codigoProducto = "";
            string storeProcedureActivarProducto = "";
            for (int row = 0; row < dataGridView1.Rows.Count; row++) {
                codigoProducto = dataGridView1.Rows[row].Cells[0].Value.ToString ();
                storeProcedureActivarProducto += string.Format ("EXEC activarProducto {0}\n", codigoProducto);
            }
            Execution.Ejecutar (storeProcedureActivarProducto);
            MessageBox.Show ("Todos los productos elegidos han sido activados", "Accion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void activarCliente () {
            string codigoCliente = clearString (txtCodigo);
            string nombreCliente = clearString (txtNombre);
            string storeProcedureActivarCliente = string.Format (@"EXEC activarCliente {0} ", codigoCliente);

            Execution.Ejecutar (storeProcedureActivarCliente);
            MessageBox.Show (string.Format ("El cliente {0} ha sido activado", nombreCliente), "Accion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LimpiarCliente () {
            txtNombre.Text = "";
            txtCodigo.Text = "";
        }

        public void LimpiarProducto () {
            txtCodigoProducto.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioProducto.Text = "";
            txtCantidadAVender.Text = "";
            txtUnidad.Text = "";
        }

        public void ConsultaCliente () {
            string codigo = txtCodigo.Text.Trim ();
            if (string.IsNullOrEmpty (codigo)) return;

            string storeProcedureConsultarCliente = string.Format ("EXEC consultarCliente {0}", codigo);
            DS = Execution.Ejecutar (storeProcedureConsultarCliente);
            int countTable = DS.Tables.Count;
            int countRows = DS.Tables[0].Rows.Count;

            if (countTable > 0 && countRows > 0) {
                DataRow row = DS.Tables[0].Rows[0];
                txtNombre.Text = row["nombre_cliente"].ToString ().Trim ();

            } else {

                txtNombre.Text = "";
            }

        }

        public void ConsultarCliente () {
            FormConsultaDeCliente ConsultaDeCliente = new FormConsultaDeCliente ();
            if (ConsultaDeCliente.ShowDialog () == DialogResult.OK) {
                txtCodigo.Text = ConsultaDeCliente.Codigo;
            }
            ConsultaDeCliente.Dispose ();
        }

        public void searchUnidad (string codigo) {
            string storeProcedureConsultarUnidad = string.Format ("EXEC consultarUnidad {0}", codigo);
            DS = Execution.Ejecutar (storeProcedureConsultarUnidad);
            int countTable = DS.Tables.Count;
            int countRows = DS.Tables[0].Rows.Count;
            if (countTable > 0 && countRows > 0) {
                DataRow row = DS.Tables[0].Rows[0];
                txtUnidad.Text = row["nombre_unidad"].ToString ().Trim ();
            }

        }

        public void helperConsultaProducto (DataSet DS) {
            DataRow row = DS.Tables[0].Rows[0];
            string cantidadExistente = row["cantidad_existente"].ToString ();
            txtNombreProducto.Text = row["nombre_producto"].ToString ();
            txtPrecioProducto.Text = row["precio_de_venta"].ToString ();
            string codigoUnidad = row["codigo_unidad"].ToString ();
            searchUnidad (codigoUnidad);

            if (cantidadExistente == "20") {
                string messageTxt = string.Format (string.Format ("Lo sentimos {0} pero aún no hemos abastecido los almacenes de este producto", clearString (txtNombre)));
                messageExlamation (messageTxt);
                LimpiarProducto ();
                return;
            }
        }

        public void ConsultaProducto () {
            string codigo = clearString (txtCodigoProducto);
            if (string.IsNullOrEmpty (codigo)) return;

            string storeProcedureConsultarProducto = string.Format ("EXEC consultarProducto {0}", codigo);
            DS = Execution.Ejecutar (storeProcedureConsultarProducto);
            int countTable = DS.Tables.Count;
            int countRows = DS.Tables[0].Rows.Count;
            if (countTable > 0 && countRows > 0) {
                helperConsultaProducto (DS);
            } else {

                LimpiarProducto ();

            }
        }

        public void ConsultarProducto () {
            FormConsultaProducto ConsultaDeProducto = new FormConsultaProducto ();
            if (ConsultaDeProducto.ShowDialog () == DialogResult.OK) {
                txtCodigoProducto.Text = ConsultaDeProducto.Codigo;
                SendKeys.Send ("{TAB}");
            }
            ConsultaDeProducto.Dispose ();

        }

        public void fillCliente () {
            string codigo = clearString (txtCodigo);
            if (string.IsNullOrEmpty (codigo)) {
                nuevoProcesos ();
            } else {
                SendKeys.Send ("{TAB}");
            }

        }

        public void fillProducto () {
            string codigo = clearString (txtCodigoProducto);
            if (string.IsNullOrEmpty (codigo)) {
                LimpiarProducto ();
            } else {
                SendKeys.Send ("{TAB}");
            }
        }

        public void nuevoProcesos () {
            dataGridView1.DataSource = null;
            LimpiarCliente ();
            LimpiarProducto ();
            txtTotal.Text = "RD$0";
            table.Clear ();
        }

        public bool validateTextBoxsCliente () {
            string codigoCliente = clearString (txtCodigo);
            string nombreCliente = clearString (txtNombre);
            return (string.IsNullOrEmpty (codigoCliente) || string.IsNullOrEmpty (nombreCliente));
        }

        public bool validateTextBoxsProducto () {
            string codigo = clearString (txtCodigoProducto);
            string nombreProducto = clearString (txtNombreProducto);
            string cantidadAVender = clearString (txtCantidadAVender);
            string precioProducto = clearString (txtPrecioProducto);
            return (string.IsNullOrEmpty (codigo) || string.IsNullOrEmpty (nombreProducto) || string.IsNullOrEmpty (cantidadAVender) || string.IsNullOrEmpty (precioProducto));

        }

        public bool validateDataGridView () {
            return dataGridView1.Rows.Count == 0;
        }

        public bool validateTextBoxs () {
            return validateTextBoxsCliente () || validateTextBoxsProducto ();
        }

        public void calculateTotal () {
            int sum = 0;
            for (int row = 0; row < dataGridView1.Rows.Count; row++) {
                sum += Convert.ToInt32 (removeMoneySymbol (dataGridView1.Rows[row].Cells[5].Value.ToString ()));
            }
            txtTotal.Text = "";
            txtTotal.Text = addMoneySymbol (sum.ToString ());

        }

        public void agregarProductos () {
            if (validateTextBoxs ()) { messageExlamation ("Debe de llenar todos los campos"); return; }
            string codigo = clearString (txtCodigoProducto);
            string nombreProducto = clearString (txtNombreProducto);
            string unidadProducto = clearString (txtUnidad);

            string cantidadAVender = clearString (txtCantidadAVender);

            string precioProducto = clearString (txtPrecioProducto);
            string precioProductoWithSymbol = addMoneySymbol (clearString (txtPrecioProducto));

            string importe = addMoneySymbol ((Int16.Parse (cantidadAVender) * Int16.Parse (precioProducto)).ToString ());

            table.Rows.Add (codigo, nombreProducto, unidadProducto, cantidadAVender, precioProductoWithSymbol, importe);
            dataGridView1.DataSource = table;
            calculateTotal ();
            LimpiarProducto ();

        }

        public void eliminarProductos () {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows) {
                dataGridView1.Rows.RemoveAt (item.Index);
            }
            calculateTotal ();
        }

        public void calcularCantidad (DataRow row, string cantidadAVender) {
            string nombreProducto = row["nombre_producto"].ToString ();
            int puntoDeReorden = Convert.ToInt16 (row["punto_reo"].ToString ());
            int cantidadExistente = Convert.ToInt16 (row["cantidad_existente"].ToString ());
            Int32 cantidadAVenderInt = Convert.ToInt32 (cantidadAVender);
            int cantidadRestante = (cantidadExistente - cantidadAVenderInt);
            int cantidadDisponible = cantidadExistente - puntoDeReorden;

            if (cantidadRestante < puntoDeReorden) {
                string messageText = string.Format ("Esta intentando vender una cantidad que excede el punto de reorden del producto: {0}\nEl punto de reorden es: {1}\nLa cantidad maxima que esta disponible es {2}", nombreProducto, puntoDeReorden, cantidadDisponible);
                messageExlamation (messageText);
                txtCantidadAVender.Text = cantidadDisponible + "";
            }

        }

        public void validarCantidad () {
            string codigo = clearString (txtCodigoProducto);
            string cantidadAVender = clearString (txtCantidadAVender);

            if (string.IsNullOrEmpty (codigo) || string.IsNullOrEmpty (cantidadAVender)) return;
            string storeProcedureConsultarProducto = string.Format ("EXEC consultarProducto {0}", codigo);

            DS = Execution.Ejecutar (storeProcedureConsultarProducto);
            int countTable = DS.Tables.Count;
            int countRows = DS.Tables[0].Rows.Count;
            if (countTable > 0 && countRows > 0) {
                DataRow row = DS.Tables[0].Rows[0];
                calcularCantidad (row, cantidadAVender);
            }

        }

        public void addColumns () {
            table.Columns.Add ("Codigo", typeof (string));
            table.Columns.Add ("Producto", typeof (string));
            table.Columns.Add ("Unidad", typeof (string));
            table.Columns.Add ("Cantidad", typeof (string));
            table.Columns.Add ("Precio", typeof (string));
            table.Columns.Add ("Importe", typeof (string));
            txtTotal.Text = "0";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;

        }

        public void actualizarDetalle (string numeroFactura) {
            string storeProceduresactualizarDetalles = "";
            string codigoProducto;
            string cantidadVentida;
            string precioVenta;
            string unidadProducto;
            for (int row = 0; row < dataGridView1.Rows.Count; row++) {
                codigoProducto = dataGridView1.Rows[row].Cells[0].Value.ToString ();
                unidadProducto = dataGridView1.Rows[row].Cells[2].Value.ToString ();
                cantidadVentida = removeMoneySymbol (dataGridView1.Rows[row].Cells[3].Value.ToString ()).ToString ();
                precioVenta = removeMoneySymbol (dataGridView1.Rows[row].Cells[4].Value.ToString ()).ToString ();
                storeProceduresactualizarDetalles += string.Format ("EXEC upsertDetalles @numero_factura = {0}, @codigo_producto = {1}, @unidad_producto = {4}, @cantidad_vendida = {2}, @precio_de_venta = {3}\n", numeroFactura, codigoProducto, cantidadVentida, precioVenta, unidadProducto);
            }
            DS = Execution.Ejecutar (storeProceduresactualizarDetalles);
        }

        public void generarFactura (string numeroFactura) {
            if (!validateDataGridView ()) {
                activarCliente ();
                activarProducto ();
                string storeProceduraConsultarVentas = string.Format ("EXEC consultarVentas {0}", numeroFactura);
                DS = Execution.Ejecutar (storeProceduraConsultarVentas);
                FormReporteFactura ReporteFactura = new FormReporteFactura ();
                ReporteFactura.reportViewer1.LocalReport.DataSources[0].Value = DS.Tables[0];
                ReporteFactura.ShowDialog ();
                nuevoProcesos ();
            }
        }

        public void procesarProductos () {
            if (validateTextBoxsCliente () || validateDataGridView ()) {
                messageExlamation ("Debe tener un cliente y productos para procesar");
                return;
            } else {
                string codigoCliente = clearString (txtCodigo);
                string totalVenta = removeMoneySymbol (clearString (txtTotal)).ToString ();
                string storeProcedureActualizarVentas = string.Format ("EXEC upsertVentas @codigo_cliente={0}, @total={1}", codigoCliente, totalVenta);
                DS = Execution.Ejecutar (storeProcedureActualizarVentas);
                DataRow row = DS.Tables[0].Rows[0];
                string numeroFactura = row["numero_factura"].ToString ().Trim ();
                actualizarDetalle (numeroFactura);
                generarFactura (numeroFactura);

            }
        }

        private void txtCodigo_TextChanged_1 (object sender, EventArgs e) {
            fillCliente ();
        }

        private void txtCodigo_Validating_1 (object sender, CancelEventArgs e) {
            ConsultaCliente ();
        }

        private void linkLabel1_LinkClicked_1 (object sender, LinkLabelLinkClickedEventArgs e) {
            ConsultarCliente ();
        }

        private void txtCodigo_KeyPress (object sender, KeyPressEventArgs e) {
            onlyInteger (sender, e);
        }

        private void btnNuevo_Click (object sender, EventArgs e) {
            nuevoProcesos ();
        }

        private void btnConsultar_Click (object sender, EventArgs e) {
            ConsultarProducto ();
        }

        private void txtCodigoProducto_TextChanged (object sender, EventArgs e) {
            fillProducto ();
        }

        private void txtCodigoProducto_Validating (object sender, CancelEventArgs e) {
            ConsultaProducto ();
        }

        private void txtCodigoProducto_KeyPress (object sender, KeyPressEventArgs e) {
            onlyInteger (sender, e);
        }

        private void txtCantidadProducto_KeyPress (object sender, KeyPressEventArgs e) {
            onlyInteger (sender, e);
        }

        private void txtPrecioProducto_KeyPress (object sender, KeyPressEventArgs e) {
            onlyInteger (sender, e);
        }

        private void linkLabel2_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e) {
            ConsultarProducto ();
        }

        private void txtCantidadAVender_Validating (object sender, CancelEventArgs e) {
            validarCantidad ();
        }

        private void btnConsultarCliente_Click (object sender, EventArgs e) {
            ConsultarCliente ();
        }

        private void btnAgregar_Click (object sender, EventArgs e) {
            agregarProductos ();
        }

        private void dataGridView1_CellContentClick (object sender, DataGridViewCellEventArgs e) {

        }

        private void FormProcesosVentas_Load (object sender, EventArgs e) {
            addColumns ();
            txtTotal.Text = "RD$0";
        }

        private void btnEliminar_Click (object sender, EventArgs e) {
            eliminarProductos ();
        }

        private void btnProcesar_Click (object sender, EventArgs e) {
            procesarProductos ();
        }

        private void txtCantidadAVender_TextChanged (object sender, EventArgs e) {
            limitadorDeCantidad (sender, e, "La mayor cantidad que el sistema puede vender es de ", 20);
        }

        private void txtNombre_KeyPress (object sender, KeyPressEventArgs e) {
            onlyString (sender, e);
        }

    }
}