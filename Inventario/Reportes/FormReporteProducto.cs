using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Inventario.Reportes {
    public partial class FormReporteProducto : FormReporte {
        public FormReporteProducto () {
            InitializeComponent ();
        }
        public object ds;
        private void FormReporteProducto_Load (object sender, EventArgs e) {
            ReportDataSource rds = new ReportDataSource ("DataSet1", ds);
            this.reportViewer1.LocalReport.DataSources.Clear ();
            this.reportViewer1.LocalReport.DataSources.Add (rds);
            this.reportViewer1.LocalReport.Refresh ();
            this.reportViewer1.RefreshReport ();
        }
    }
}