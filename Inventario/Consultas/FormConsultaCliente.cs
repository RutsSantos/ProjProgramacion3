using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Execution = Utilidades.ExecutionDB;
using Inventario.DataSets;
using Inventario.Reportes;

namespace Inventario {
    public partial class FormConsultaDeCliente : FormConsulta {
        public FormConsultaDeCliente () {
            InitializeComponent ();
            this.Consultar ();
        }

        public override void Consultar () {
            string query = "SELECT * FROM cliente WHERE ";
            string value = clearString (txtNombre);
            if (!string.IsNullOrEmpty (value)) {
                query += string.Format (" ( nombre_cliente LIKE('%{0}%')) AND ", value);
            }
            query += whereEstado (comboBoxEstado, "cliente") + " AND " + whereGenero (comboBoxGenero);
            DS = Execution.Ejecutar (query);
            int countTable = DS.Tables.Count;
            if (countTable > 0) {
                dataGridView.DataSource = DS.Tables[0];
            }
        }

        public override void Seleccionar () {
            FormMantenimientoDeCliente MantenimientoDeCliente = new FormMantenimientoDeCliente ();
            if (dataGridView.Rows.Count == 0) return;
            Codigo = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString ();
            DialogResult = DialogResult.OK;
            Close ();

        }

        public override void Imprimir () {
            if (dataGridView.Rows.Count == 0) return;
            object dataSet = dataGridView.DataSource;
            FormReporteCliente ReporteCliente = new FormReporteCliente ();
            ReporteCliente.ds = dataSet;
            ReporteCliente.Show ();
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

        private void label7_Click (object sender, EventArgs e) {

        }

        private void comboBoxGenero_SelectedIndexChanged (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void comboBoxEstado_SelectedIndexChanged (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void comboBoxGenero_KeyPress (object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void comboBoxEstado_KeyPress (object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void txtNombre_KeyPress (object sender, KeyPressEventArgs e) {
            onlyString (sender, e);
        }

    }
}