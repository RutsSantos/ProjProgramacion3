using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using utPrimos = Utilidades.Primos;

namespace Utilidades {
    public class Matrices {
        public static string getTextMatriz (int[, ] m) {
            string resultado = "";

            for (int f = 0; f < 5; f++) {
                for (int c = 0; c < 5; c++) {
                    resultado += m[f, c].ToString () + "\t";
                }
                resultado += "\n";
            }

            return resultado;
        }

        public static int[, ] matriz1 () {
            int n = 0;
            int[, ] m = new int[5, 5];

            for (int f = 0; f < 5; f++) {
                for (int c = 0; c < 5; c++) {
                    m[f, c] = ++n;
                }
            }

            return m;

        }

        public static int[, ] matriz2 () {
            int[, ] m = new int[5, 5];

            for (int f = 0; f < 5; f++) {
                for (int c = 0; c < 5; c++) {
                    if (f == c) m[f, c] = 1;
                    else if (f + c == 4) m[f, c] = 2;
                    else {
                        if (f < c) {
                            if (f + c < 4) m[f, c] = 3;
                            else m[f, c] = 4;
                        } else {
                            if (f + c < 4) m[f, c] = 6;
                            else m[f, c] = 5;
                        }
                    }
                }
            }

            return m;

        }

        public static int[, ] matriz3 () {
            int[, ] m = new int[5, 5];

            for (int f = 0; f < 5; f++) {
                for (int c = 0; c < 5; c++) {
                    if (f % 2 == 0) m[f, c] = f * c + c;
                    else m[f, c] = f - c;
                }
            }

            return m;

        }

        public static int[, ] matriz4 () {
            int[, ] m = new int[5, 5];

            for (int f = 0; f < 5; f++) {
                for (int c = 0; c < 5; c++) {
                    if (f == c) m[f, c] = (f + 1) * 2;
                    else if (f + c == 4) m[f, c] = f;
                    else if (c < 2) m[f, c] = f;
                    else if (c == 2) m[f, c] = f - c;
                    else if (c == 3) m[f, c] = f * c;
                    else m[f, c] = 3;
                    //if (f % 2 == 0) m[f, c] = f * c + c;
                    //else m[f, c] = f - c;
                }
            }

            return m;

        }

        public static int cantPrimo (int[, ] matriz) {
            int cantPrimos = 0;

            List<int> matrizElements = getElements (matriz);

            foreach (var number in matrizElements) {
                if (utPrimos.isPrime (number)) {
                    cantPrimos++;
                }
            }

            return cantPrimos;
        }

        public static int sum (int[, ] matriz) {
            int result = 0;

            List<int> matrizElements = getElements (matriz);

            foreach (var number in matrizElements) {
                result += number;
            }
            return result;
        }

        public static int mayor (int[, ] matriz) {

            int mayor = matriz[0, 0];

            List<int> matrizElements = getElements (matriz);

            foreach (var number in matrizElements) {
                if (number > mayor) mayor = number;
            }

            return mayor;

        }

        public static List<int> getElements (int[, ] matriz) {
            List<int> elements = new List<int> ();
            for (int f = 0; f < 5; f++) {
                for (int c = 0; c < 5; c++) {
                    elements.Add (matriz[f, c]);
                }
            }

            return elements;
        }

    }
}