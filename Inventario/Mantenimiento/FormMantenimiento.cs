using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Execution = Utilidades.ExecutionDB;

namespace Inventario {
    public partial class FormMantenimiento : FormBase {
        public FormMantenimiento () {
            this.puedeSalvar = true;
            this.puedeEliminar = true;
            this.puedeConsultar = true;
            InitializeComponent ();
        }

        private void buttonCerrar_Click (object sender, EventArgs e) {
            Dispose ();
        }

    }
}