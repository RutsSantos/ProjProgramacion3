using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Execution = Utilidades.ExecutionDB;
using System.Text.RegularExpressions;
using Inventario.Reportes;

namespace Inventario.Consultas {
    public partial class FormConsultaProducto : FormConsulta {
        public FormConsultaProducto () {
            InitializeComponent ();
            this.Consultar ();
        }

        public override void Seleccionar () {
            if (dataGridView.Rows.Count == 0) return;
            Codigo = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString ();
            DialogResult = DialogResult.OK;
            Close ();
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

        public string concatWhere () {
            string where = " WHERE ";
            where += formulateWhere (txtNombre, "producto.nombre_producto");
            where += formulateWhere (txtDepartamento, "departamento.nombre_departamento");
            where += formulateWhere (txtSuplidor, "suplidor.nombre_suplidor");
            where += formulateWhere (txtUnidad, "unidad.nombre_unidad");
            where += whereEstado (comboBoxEstado, "producto");
            return where;
        }

        public override void Consultar () {
            string query = @"
                        SELECT  producto.codigo_producto,
                            producto.nombre_producto,
                            departamento.codigo_departamento,
                            departamento.nombre_departamento,
                            suplidor.nombre_suplidor,
                            producto.cantidad_existente,
                            unidad.nombre_unidad,
                            producto.precio_de_venta,
                            producto.estado
                        FROM producto
                            INNER JOIN departamento
                                ON producto.codigo_departamento = departamento.codigo_departamento
                            INNER JOIN suplidor
                                ON producto.codigo_suplidor = suplidor.codigo_suplidor
                            INNER JOIN unidad
                                ON producto.codigo_unidad =  unidad.codigo_unidad";

            string where = concatWhere ();
            query += condicionarWhere (where);
            DS = Execution.Ejecutar (query);
            int countTable = DS.Tables.Count;
            if (countTable > 0) {
                dataGridView.DataSource = DS.Tables[0];
            }
        }

        public override void Imprimir () {
            if (dataGridView.Rows.Count == 0) return;
            object dataSet = dataGridView.DataSource;
            FormReporteProducto ReporteProducto = new FormReporteProducto ();
            ReporteProducto.ds = dataSet;
            ReporteProducto.Show ();
        }

        private void btnBuscar_Click (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void btnSeleccionar_Click (object sender, EventArgs e) {
            this.Seleccionar ();
        }

        private void btnImprimir_Click (object sender, EventArgs e) {
            Imprimir ();
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

        private void txtUnidad_TextChanged (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void txtDepartamento_KeyPress (object sender, KeyPressEventArgs e) {
            onlyString (sender, e);
        }

        private void txtSuplidor_KeyPress (object sender, KeyPressEventArgs e) {
            onlyString (sender, e);
        }

        private void txtUnidad_KeyPress (object sender, KeyPressEventArgs e) {
            onlyString (sender, e);
        }

        private void comboBoxEstado_SelectedIndexChanged (object sender, EventArgs e) {
            this.Consultar ();
        }
    }
}