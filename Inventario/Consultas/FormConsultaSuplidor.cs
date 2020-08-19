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
    public partial class FormConsultaDeSuplidor : FormConsulta {
        public FormConsultaDeSuplidor () {
            InitializeComponent ();
            this.Consultar ();
        }

        public override void Consultar () {
            string query = "SELECT * FROM suplidor WHERE ";
            string value = clearString (txtNombre);
            if (!string.IsNullOrEmpty (value)) {
                query += string.Format (" ( nombre_suplidor LIKE('%{0}%')) AND ", value);
            }
            query += whereEstado (comboBoxEstado, "suplidor") + " AND " + whereGenero (comboBoxGenero);
            DS = Execution.Ejecutar (query);
            int countTable = DS.Tables.Count;
            if (countTable > 0) {
                dataGridView.DataSource = DS.Tables[0];
            }
        }

        public override void Imprimir () {
            if (dataGridView.Rows.Count == 0) return;
            object dataSet = dataGridView.DataSource;
            FormReporteSuplidor ReporteSuplidor = new FormReporteSuplidor ();
            ReporteSuplidor.ds = dataSet;
            ReporteSuplidor.Show ();
        }
        public override void Seleccionar () {
            if (dataGridView.Rows.Count == 0) return;
            Codigo = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString ();
            DialogResult = DialogResult.OK;
            Close ();
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

        private void comboBoxGenero_KeyPress (object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void comboBoxEstado_KeyPress (object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void comboBoxGenero_SelectedIndexChanged (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void comboBoxEstado_SelectedIndexChanged (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void txtNombre_KeyPress (object sender, KeyPressEventArgs e) {
            onlyString (sender, e);
        }
    }
}