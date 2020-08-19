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
    public partial class FormReporteFactuca2 : FormReporte {
        public FormReporteFactuca2 () {
            InitializeComponent ();
        }

        public object ds;
        private void FormReporteFactuca2_Load (object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'DataSet1.consultarVentas' table. You can move, or remove it, as needed.
            // this.consultarVentasTableAdapter.Fill(this.DataSet1.consultarVentas);
            // TODO: This line of code loads data into the 'DataSet1.consultarVentas' table. You can move, or remove it, as needed.
            //this.consultarVentasTableAdapter.Fill(this.DataSet1.consultarVentas);
            ReportDataSource rds = new ReportDataSource ("DataSet1", ds);
            this.reportViewer1.LocalReport.DataSources.Clear ();
            this.reportViewer1.LocalReport.DataSources.Add (rds);
            this.reportViewer1.LocalReport.Refresh ();
            this.reportViewer1.RefreshReport ();

        }

        private void panel1_Paint (object sender, PaintEventArgs e) {

        }
    }
}