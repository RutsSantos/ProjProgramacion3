using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventario.Consultas;
using Inventario.Mantenimiento;
using Inventario.Procesos;
using Inventario.Reportes;

namespace Inventario {
    public partial class FormMenu : Form {
        private int childFormNumber = 0;

        public FormMenu () {
            InitializeComponent ();
        }

        private void ShowNewForm (object sender, EventArgs e) {
            Form childForm = new Form ();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show ();
        }

        private void OpenFile (object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog ();
            openFileDialog.InitialDirectory = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog (this) == DialogResult.OK) {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click (object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog ();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog (this) == DialogResult.OK) {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click (object sender, EventArgs e) {
            this.Close ();
        }

        private void CutToolStripMenuItem_Click (object sender, EventArgs e) { }

        private void CopyToolStripMenuItem_Click (object sender, EventArgs e) { }

        private void PasteToolStripMenuItem_Click (object sender, EventArgs e) { }

        private void ToolBarToolStripMenuItem_Click (object sender, EventArgs e) {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click (object sender, EventArgs e) {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click (object sender, EventArgs e) {
            LayoutMdi (MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click (object sender, EventArgs e) {
            LayoutMdi (MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click (object sender, EventArgs e) {
            LayoutMdi (MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click (object sender, EventArgs e) {
            LayoutMdi (MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click (object sender, EventArgs e) {
            foreach (Form childForm in MdiChildren) {
                childForm.Close ();
            }
        }

        private void toolStripMenuItem1_Click (object sender, EventArgs e) {

        }

        private void primosToolStripMenuItem_Click (object sender, EventArgs e) {
            FormPrimos fp = new FormPrimos ();
            fp.MdiParent = this;
            fp.Show ();
        }

        private void matricesToolStripMenuItem_Click (object sender, EventArgs e) {
            FormMatrices fm = new FormMatrices ();
            fm.MdiParent = this;
            fm.Show ();
        }

        private void cRUDToolStripMenuItem_Click (object sender, EventArgs e) {
            FormCrud fc = new FormCrud ();
            fc.MdiParent = this;
            fc.Show ();
        }

        private void numerosToolStripMenuItem_Click (object sender, EventArgs e) {
            FormNumeros fn = new FormNumeros ();
            fn.MdiParent = this;
            fn.Show ();
        }

        private void matrizOpToolStripMenuItem_Click (object sender, EventArgs e) {
            FormMatrizOp fmp = new FormMatrizOp ();
            fmp.MdiParent = this;
            fmp.Show ();
        }

        private void Menu_Load (object sender, EventArgs e) {

        }

        private void reportesToolStripMenuItem_Click (object sender, EventArgs e) {

        }

        private void mantenimientosToolStripMenuItem_Click (object sender, EventArgs e) {

        }

        private void Menu_MdiChildActivate (object sender, EventArgs e) {
            if (ActiveMdiChild is FormBase) {
                FormBase obj = (FormBase) ActiveMdiChild;
                saveToolStripButton.Enabled = obj.puedeSalvar;
                printToolStripButton.Enabled = obj.puedeImprimir;
                printPreviewToolStripButton.Enabled = obj.puedeConsultar;

            }
        }

        private void saveToolStripButton_Click (object sender, EventArgs e) {
            if (ActiveMdiChild is FormBase) {
                FormBase obj = (FormBase) ActiveMdiChild;
                obj.Salvar ();
            }
        }

        private void printToolStripButton_Click (object sender, EventArgs e) {
            if (ActiveMdiChild is FormBase) {
                FormBase obj = (FormBase) ActiveMdiChild;
                obj.Imprimir ();
            }
        }

        private void printPreviewToolStripButton_Click (object sender, EventArgs e) {
            if (ActiveMdiChild is FormBase) {
                FormBase obj = (FormBase) ActiveMdiChild;
                obj.Consultar ();
            }
        }

        private void deClienteToolStripMenuItem_Click (object sender, EventArgs e) {
            FormConsultaDeCliente ConsultaDeCliente = new FormConsultaDeCliente ();
            ConsultaDeCliente.MdiParent = this;
            ConsultaDeCliente.Show ();
        }

        private void deDepartamentoToolStripMenuItem_Click (object sender, EventArgs e) {
            FormConsultaDeDepartamento ConsultaDeDepartamento = new FormConsultaDeDepartamento ();
            ConsultaDeDepartamento.MdiParent = this;
            ConsultaDeDepartamento.Show ();
        }

        private void deSuplidorToolStripMenuItem_Click (object sender, EventArgs e) {
            FormConsultaDeSuplidor ConsultaDeSuplidor = new FormConsultaDeSuplidor ();
            ConsultaDeSuplidor.MdiParent = this;
            ConsultaDeSuplidor.Show ();
        }

        private void deClienteToolStripMenuItem1_Click (object sender, EventArgs e) {
            FormMantenimientoDeCliente MantenimientoDeCliente = new FormMantenimientoDeCliente ();
            MantenimientoDeCliente.MdiParent = this;
            MantenimientoDeCliente.Show ();
        }

        private void deDepartamentoToolStripMenuItem1_Click (object sender, EventArgs e) {

            FormMantenimientoDeDepartamento MantenimientoDeDepartamento = new FormMantenimientoDeDepartamento ();
            MantenimientoDeDepartamento.MdiParent = this;
            MantenimientoDeDepartamento.Show ();
        }

        private void deSuplidorToolStripMenuItem1_Click (object sender, EventArgs e) {
            FormMantenimientoDeSuplidor MantenimientoDeSuplidor = new FormMantenimientoDeSuplidor ();
            MantenimientoDeSuplidor.MdiParent = this;
            MantenimientoDeSuplidor.Show ();
        }

        private void toolStripMenuItem8_Click (object sender, EventArgs e) {

        }

        private void toolStripMenuItem6_Click (object sender, EventArgs e) {

        }

        private void toolStripMenuItem7_Click (object sender, EventArgs e) {

        }

        private void toolStripMenuItem2_Click (object sender, EventArgs e) {
            FormReporte FormReporte = new FormReporte ();
            FormReporte.MdiParent = this;
            FormReporte.Show ();
        }

        private void deProductoToolStripMenuItem_Click (object sender, EventArgs e) {
            FormMantenimientoDeProducto FormMantenimientoDeProducto = new FormMantenimientoDeProducto ();
            FormMantenimientoDeProducto.MdiParent = this;
            FormMantenimientoDeProducto.Show ();
        }

        private void deUnidadToolStripMenuItem_Click (object sender, EventArgs e) {
            FormMantenimientoUnidades FormMantenimientoUnidades = new FormMantenimientoUnidades ();
            FormMantenimientoUnidades.MdiParent = this;
            FormMantenimientoUnidades.Show ();
        }

        private void deVentasToolStripMenuItem_Click (object sender, EventArgs e) {
            FormConsultaFactura ConsultaFactura = new FormConsultaFactura ();
            ConsultaFactura.MdiParent = this;
            ConsultaFactura.Show ();
        }

        private void deProductoToolStripMenuItem1_Click (object sender, EventArgs e) {
            FormConsultaProducto ConsultaDeProducto = new FormConsultaProducto ();
            ConsultaDeProducto.MdiParent = this;
            ConsultaDeProducto.Show ();
        }

        private void deUnidadesToolStripMenuItem_Click (object sender, EventArgs e) {
            FormConsultaDeUnidad ConsultaDeUnidades = new FormConsultaDeUnidad ();
            ConsultaDeUnidades.MdiParent = this;
            ConsultaDeUnidades.Show ();
        }

        private void toolStripMenuItem3_Click (object sender, EventArgs e) {
            FormProcesosVentas ProcesosVentas = new FormProcesosVentas ();
            ProcesosVentas.MdiParent = this;
            ProcesosVentas.Show ();
        }

        private void toolStripMenuItem2_Click_1 (object sender, EventArgs e) {

        }

    }
}