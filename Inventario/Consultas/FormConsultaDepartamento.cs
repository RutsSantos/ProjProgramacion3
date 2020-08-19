using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Execution = Utilidades.ExecutionDB;
using Inventario.Reportes;

namespace Inventario {
    public partial class FormConsultaDeDepartamento : FormConsulta {
        public FormConsultaDeDepartamento () {
            InitializeComponent ();
            this.Consultar ();
        }

        public override void Seleccionar () {
            if (dataGridView.Rows.Count == 0) return;
            Codigo = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString ();
            DialogResult = DialogResult.OK;
            Close ();
        }

        public override void Consultar () {
            string query = "SELECT * FROM departamento WHERE ";
            string value = clearString (txtNombre);
            if (!string.IsNullOrEmpty (value)) {
                query += string.Format (" ( nombre_departamento LIKE('%{0}%')) AND ", value);
            }
            query += whereEstado (comboBoxEstado, "departamento");
            DS = Execution.Ejecutar (query);
            int countTable = DS.Tables.Count;
            if (countTable > 0) {
                dataGridView.DataSource = DS.Tables[0];
            }
        }

        public override void Imprimir () {
            if (dataGridView.Rows.Count == 0) return;
            object dataSet = dataGridView.DataSource;
            FormReporteDepartamento ReporteDepartamento = new FormReporteDepartamento ();
            ReporteDepartamento.ds = dataSet;
            ReporteDepartamento.Show ();
        }

        private void label2_Click (object sender, EventArgs e) {

        }

        private void txtNombre_TextChanged (object sender, EventArgs e) {

        }

        private void label1_Click (object sender, EventArgs e) {

        }

        private void txtCodigo_TextChanged (object sender, EventArgs e) {

        }

        private void dataGridView1_CellContentClick (object sender, DataGridViewCellEventArgs e) {

        }

        private void btnSeleccionar_Click (object sender, EventArgs e) {

        }

        private void btnBuscar_Click (object sender, EventArgs e) {

        }

        private void btnImprimir_Click (object sender, EventArgs e) {
            Imprimir ();
        }

        private void txtNombre_TextChanged_1 (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void label2_Click_1 (object sender, EventArgs e) {

        }

        private void comboBoxEstado_SelectedIndexChanged (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void comboBoxEstado_KeyPress (object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void txtNombre_KeyPress (object sender, KeyPressEventArgs e) {
            onlyString (sender, e);
        }
    }
}