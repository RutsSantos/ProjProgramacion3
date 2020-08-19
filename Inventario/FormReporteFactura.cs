using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventario.Reportes;

namespace Inventario {
    public partial class FormReporteFactura : FormReporte {
        public FormReporteFactura () {
            InitializeComponent ();
        }

        private void FormReporteFactura_Load (object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'DataSet1.consultarVentas' table. You can move, or remove it, as needed.
            // this.consultarVentasTableAdapter.Fill(this.DataSet1.consultarVentas);

            this.reportViewer1.RefreshReport ();
        }
    }
}