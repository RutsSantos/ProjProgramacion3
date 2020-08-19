using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Utilidades {
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
                        string lastText = control.Name.Substring (control.Name.Length - 2, 2);
                        if (lastText != "NV" && string.IsNullOrEmpty (control.Text.Trim ())) {
                            ep.SetError (control, "Campo Obligatorio");
                            haveError = true;
                        } else {
                            ep.SetError (control, "");
                        }
                        if (control.Name.Contains ("txtCod") && !control.Name.Contains ("Codigo")) {
                            int num;
                            if (!Int32.TryParse (control.Text.Trim (), out num)) {
                                ep.SetError (control, "Debe ser un numero valido");
                                haveError = true;
                            } else {
                                ep.SetError (control, "");
                            }
                        }
                        if (control.Name.Contains ("Codigo")) {
                            int num;
                            if (!Int32.TryParse (control.Text.Trim (), out num) && !string.IsNullOrEmpty (control.Text.Trim ())) {
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