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
    public partial class FormConsulta : FormBase {
        public FormConsulta () {
            this.puedeConsultar = true;
            this.puedeImprimir = true;
            InitializeComponent ();
        }
        public string Codigo = "";

        public virtual void Seleccionar () {
            MessageBox.Show ("Seleccionando");
        }

        private void buttonCerrar_Click (object sender, EventArgs e) {

        }

        private void btnEliminar_Click (object sender, EventArgs e) {

        }

        private void btnBuscar_Click (object sender, EventArgs e) {
            this.Consultar ();
        }

        private void btnSalvar_Click (object sender, EventArgs e) {

        }

        private void dataGridView_CellContentClick (object sender, DataGridViewCellEventArgs e) {

        }

        private void btnSeleccionar_Click (object sender, EventArgs e) {
            this.Seleccionar ();
        }

        public virtual string whereGenero (ComboBox ComboBoxgenero) {
            string genero = ComboBoxgenero.Text;
            string condition = "";
            switch (genero) {
                case "Masculino":
                    condition += " (sexo = 'Masculino') ";
                    break;
                case "Femenino":
                    condition += " (sexo = 'Femenino') ";
                    break;
                default:
                    condition += " (sexo = 'Masculino' OR sexo = 'Femenino') ";
                    break;
            }
            return condition;

        }

        public virtual string whereEstado (ComboBox ComboBoxEstado, string table) {
            string estado = ComboBoxEstado.Text;
            string condition = "";
            switch (estado) {
                case "Activo":
                    condition += string.Format("({0}.estado = 1)", table);
                    break;
                case "Inactivo":
                    condition += string.Format("({0}.estado = 0)", table);
                    break;
                default:
                    condition += string.Format("({0}.estado = 1 OR {0}.estado = 0)", table);
                    break;
            }
            return condition;

        }

    }
}