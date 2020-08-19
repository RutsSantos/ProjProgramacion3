using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Utilidades {
    public partial class label : System.Windows.Forms.Label {
        public label () {
            InitializeComponent ();
        }

        public label (IContainer container) {
            container.Add (this);

            InitializeComponent ();
        }
    }
}