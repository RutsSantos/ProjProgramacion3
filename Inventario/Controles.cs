using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventario {
    public class Controles {
        public static bool ValidarForm (Control obj, ErrorProvider ep, bool haveError = false) {
            if (obj.Controls.Count == 0) return false;
            foreach (Control control in obj.Controls) {
                if (control.Controls.Count > 0) {
                    if (ValidarForm (control, ep)) {
                        haveError = true;
                    }
                } else {

                    if (control is TextBox) {
                        ep.SetError (control, "Campo Obligatorio");

                        string fourFirst = control.Name.Substring (0, 3);
                        string value = control.Text.Trim ();

                        bool isNullOrEmpty = fourFirst == "txt" && string.IsNullOrEmpty (value);
                        bool containDobleWhiteSpace = value.Contains ("  ");

                        if (isNullOrEmpty) {
                            ep.SetError (control, "Campo Obligatorio");
                            haveError = true;
                        } else if (containDobleWhiteSpace) {
                            ep.SetError (control, "No puede haber doble espacio en blanco");
                            haveError = true;
                        } else {
                            ep.SetError (control, "");
                        }
                        if (control.Name.Contains ("txtCod") && !control.Name.Contains ("Codigo")) {
                            int num;
                            if (!Int32.TryParse (value, out num)) {
                                ep.SetError (control, "Debe ser un numero valido");
                                haveError = true;
                            } else {
                                ep.SetError (control, "");
                            }
                        }
                        bool isTxtCodigo = control.Name.Contains ("Codigo");
                        if (isTxtCodigo) {
                            int num;
                            bool validateCodigo = !Int32.TryParse (value, out num) && !string.IsNullOrEmpty (value);
                            if (validateCodigo) {
                                ep.SetError (control, "Debe ser un numero valido o en blanco para un nuevo registro.");
                                haveError = true;
                            } else {
                                ep.SetError (control, "");
                            }
                        }
                    }
                }
            }
            return haveError;
        }
    }
}