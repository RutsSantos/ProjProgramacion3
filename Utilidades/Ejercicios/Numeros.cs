using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;

namespace Utilidades {
    public class Numeros {
        public static string Convertir999 (int numero, Boolean conEspacios = true) {
            if (numero > 999 || numero <= 0) return "";

            string cadNum = numero.ToString ().PadLeft (3, '0');
            int unidades = Convert.ToInt16 (cadNum[2].ToString ());
            int decenas = Convert.ToInt16 (cadNum[1].ToString ());
            int centenas = Convert.ToInt16 (cadNum[0].ToString ());
            int unidades2 = Convert.ToInt16 (cadNum[1].ToString () + cadNum[2].ToString ());

            List<string> numInic = new List<string> {
                null,
                "uno",
                "dos",
                "tres",
                "cuatro",
                "cinco",
                "seis",
                "siete",
                "ocho",
                "nueve",
                "diez",
                "once",
                "doce",
                "trece",
                "catorce",
                "quince",
                "dieciseis",
                "diecisiete",
                "dieciocho",
                "diecinueve",
                "vente",
                "veintiuno",
                "veintidos",
                "veintitres",
                "veinticuatro",
                "veinticinco",
                "veintiseis",
                "veintisiete",
                "veintiocho",
                "veintinueve",
                "treinta"
            };

            List<string> numDec = new List<string> { null, null, null, "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };

            Dictionary<string, string> dictionary = new Dictionary<string, string> () { { "unocientos", "cientos" }, { "cincocientos", "quinientos" }, { "uno cientos", "cientos" }, { "cinco cientos", "quinientos" }
            };

            string result = "";

            if (centenas > 0) { result += numInic[centenas] + (conEspacios ? " " : "") + "cientos"; }
            if (unidades2 <= 30 && unidades2 != 0) result += (result == "" ? "" : " ") + numInic[unidades2];
            else if (unidades2 > 30) {
                result += (result == "" ? "" : " ") + numDec[decenas];
                if (unidades > 0) result += " y " + numInic[unidades];
            }

            //Arreglos

            foreach (var element in dictionary) {
                result = result.Replace (element.Key, element.Value);
            }

            if (result == "cientos") result = "cien";

            return result;
        }

        public static string ConvertirATexto (long numero, Boolean conEspacios = true) {
            //Constantes y variables
            List<string> numFinales = new List<string> { "billones", "mil", "millones", "mil", "" };
            List<string> numFin1 = new List<string> { "billon", "mil", "millon", "mil", "", "" };
            string resultado = "";

            Dictionary<string, string> dictionary = new Dictionary<string, string> () { { "uno billon", "un billon" }, { "uno millon", "un millon" }, { "uno mil", "un mil" }, { "uno billones", "un billones" }, { "uno millones", "un millones" },
            };

            //Obtener el numero en formato 999,999,999...
            string[] cadNum = String.Format ("{0:n0}", numero).Split (',');

            int iPrefijo = numFinales.Count - cadNum.Length;
            for (int i = 0; i < cadNum.Length; i++) {
                string numText = cadNum[i];
                int num = Convert.ToInt16 (numText);

                //Si el numero es igual a uno usar prefijos singulares
                string prefijo = num == 1 ? numFin1[iPrefijo + i] : numFinales[iPrefijo + i];

                //Concatenar y añadir el prefijo correspondiente
                resultado += Convertir999 (num, conEspacios) == "" ? "" : Convertir999 (num, conEspacios) + " " + prefijo + " ";

            }

            //Arreglos
            foreach (var element in dictionary) {
                resultado = resultado.Replace (element.Key, element.Value);
            }

            return resultado;
        }

        public static void ConvertirAVoz (string numero) {
            string[] cadNum = numero.Trim ().Split (' ');
            string path = Directory.GetCurrentDirectory () + @"\sonidos\";

            foreach (string numPart in cadNum) {
                SoundPlayer sound = new SoundPlayer (path + numPart + ".wav");
                sound.PlaySync ();
            }
        }

    }
}