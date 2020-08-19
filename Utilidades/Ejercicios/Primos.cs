using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilidades {
    public class Primos {
        public static string getFirstPrimes (int cant) {
            string result = "";
            int n = 0;
            for (int i = 0; i < cant; i++) {
                n = getNextPrime (n);
                result += n + "\n";
            }

            return result;
        }

        public static int getNextPrime (int start) {
            for (int i = start + 1; true; i++) {
                if (isPrime (i)) return i;
            }
        }

        public static bool isPrime (int n) {
            int i = 0;
            for (i = 2; i < n; i++) {
                if (n % i == 0) break;
            }

            return i >= n;
        }
    }
}