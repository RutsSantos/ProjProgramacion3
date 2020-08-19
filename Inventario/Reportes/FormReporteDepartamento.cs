using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventario.Reportes;
using Microsoft.Reporting.WinForms;

namespace Inventario {
    public partial class FormReporteDepartamento : FormReporte {
        public FormReporteDepartamento () {
            InitializeComponent ();
        }
        public object ds;
        private void FormReporteDepartamento_Load (object sender, EventArgs e) {
            ReportDataSource rds = new ReportDataSource ("DataSet1", ds);
            this.reportViewer1.LocalReport.DataSources.Clear ();
            this.reportViewer1.LocalReport.DataSources.Add (rds);
            this.reportViewer1.LocalReport.Refresh ();
            this.reportViewer1.RefreshReport ();
        }
    }
}