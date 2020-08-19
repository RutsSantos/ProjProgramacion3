using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventario.Procesos {
    public partial class FormProcesos : FormBase {
        public FormProcesos () {
            InitializeComponent ();
            this.puedeEliminar = true;
            this.puedeImprimir = true;
            this.puedeSalvar = true;
        }
    }
}