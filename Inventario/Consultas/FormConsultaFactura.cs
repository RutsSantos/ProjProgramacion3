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

namespace Inventario.Consultas {
    public partial class FormConsultaFactura : FormConsulta {
        public FormConsultaFactura () {
            InitializeComponent ();
            setDate ();
            this.Consultar ();
        }

        public override void Imprimir () {
            if (dataGridView.Rows.Count == 0) return;
            object dataSet = dataGridView.DataSource;
            FormReporteFactuca2 ReporteFactuca = new FormReporteFactuca2 ();
            ReporteFactuca.ds = dataSet;
            ReporteFactuca.Show ();
        }

        public override void Limpiar () {
            if (dataGridView.Rows.Count == 0) return;
            object dataSet = dataGridView.DataSource;
            FormReporteFactura ReporteFactura = new FormReporteFactura ();
            ReporteFactura.Show ();
        }

        public override void Seleccionar () {
            if (dataGridView.Rows.Count == 0) return;
            Codigo = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString ();
            DialogResult = DialogResult.OK;
            Close ();
        }

        public void setDate () {
            dateTimePickerInicial.Value = DateTime.ParseExact ("2020-01-01", "yyyy-mm-dd", CultureInfo.InvariantCulture);
            dateTimePickerFinal.Value = DateTime.Now;
        }

        public string condicionarWhere (string query) {
            string[] separatingStrings = { ")(" };
            string[] conditions = query.Split (separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            string where = "";
            foreach (string condition in conditions) {
                where += condition + " AND ";
            }
            return where.Remove (where.Length - 4);
        }

        public string formulateWhere (TextBox txtCampos, string columna) {
            string valor = clearString (txtCampos);
            return string.Format ("({0} LIKE('%{1}%'))", columna, valor);
        }

        public string betweenDate () {
            DateTime fechaInicial = dateTimePickerInicial.Value;
            DateTime fechaFinal = dateTimePickerFinal.Value;
            if (fechaInicial > fechaFinal) {
                messageExlamation ("No la fecha inicial sobrepasó la fecha final");
                setDate ();
                return "";
            }
            string where = string.Format ("(venta.fecha >= '{0}' AND venta.fecha <= '{1}')", fechaInicial.ToShortDateString (), fechaFinal.ToShortDateString ());
            return where;

        }

        public string concatWhere () {
            string where = " WHERE ";
            where += formulateWhere (txtNoFactura, "venta.numero_factura");
            where += formulateWhere (txtNombre, "cliente.nombre_cliente");
            where += formulateWhere (txtProducto, "producto.nombre_producto");
            where += formulateWhere (txtDepartamento, "departamento.nombre_departamento");
            where += formulateWhere (txtUnidad, "unidad.nombre_unidad");
            where += formulateWhere (txtSuplidor, "suplidor.nombre_suplidor");
            where += betweenDate ();
            return where;
        }

        public override void Consultar () {
            string query = @"
  SELECT venta.numero_factura AS 'No_Factura', venta.fecha AS 'Fecha', cliente.codigo_cliente AS 'No_Cliente', cliente.nombre_cliente AS 'Cliente', 
departamento.nombre_departamento AS 'Departamento', suplidor.nombre_suplidor AS 'Suplidor',
producto.codigo_producto AS 'Codigo_Producto', producto.nombre_producto AS 'Descripcion', unidad.nombre_unidad AS 'Unidad',
detalles.cantidad_vendida AS 'Cantidad_Vendida', detalles.precio_de_venta AS 'Precio', detalles.cantidad_vendida * detalles.precio_de_venta AS Importe,
venta.total AS 'Total' 
  FROM venta
  INNER JOIN detalles
    ON venta.numero_factura = detalles.numero_factura
  INNER JOIN cliente
    ON venta.codigo_cliente = cliente.codigo_cliente
  INNER JOIN producto
    ON detalles.codigo_producto = producto.codigo_producto
  INNER JOIN departamento
	ON producto.codigo_departamento = departamento.codigo_departamento
  INNER JOIN unidad
    ON producto.codigo_unidad = unidad.codigo_unidad
  INNER JOIN suplidor
    ON producto.codigo_suplidor = suplidor.codigo_suplidor
";

            string where = concatWhere ();
            query += condicionarWhere (where) + " ORDER BY venta.numero_factura DESC";
            DS = Execution.Ejecutar (query);
            int countTable = DS.Tables.Count;
            if (countTable > 0) {
                dataGridView.DataSource = DS.Tables[0];
            }
        }

        private void txtNombre_TextChanged (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void txtDepartamento_TextChanged (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void txtSuplidor_TextChanged (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void txtProducto_TextChanged (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void txtNoFactura_KeyPress (object sender, KeyPressEventArgs e) {
            onlyInteger (sender, e);
        }

        private void dateTimePickerInicial_ValueChanged (object sender, EventArgs e) {

        }

        private void dateTimePickerInicial_ValueChanged_1 (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void dateTimePickerFinal_ValueChanged (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void txtUnidad_TextChanged (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void txtSuplidor_TextChanged_1 (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void txtDepartamento_TextChanged_1 (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void btnImprimir_Click (object sender, EventArgs e) {
            Imprimir ();
        }

        private void txtNombre_KeyPress (object sender, KeyPressEventArgs e) {
            onlyString (sender, e);
        }

        private void txtProducto_KeyPress (object sender, KeyPressEventArgs e) {
            onlyString (sender, e);
        }

        private void txtDepartamento_KeyPress (object sender, KeyPressEventArgs e) {
            onlyString (sender, e);
        }

        private void txtUnidad_KeyPress (object sender, KeyPressEventArgs e) {
            onlyString (sender, e);
        }

        private void txtSuplidor_KeyPress (object sender, KeyPressEventArgs e) {
            onlyString (sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Consultar();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            return;
        }

    }
}