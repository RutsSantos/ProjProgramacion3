using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Utilidades {
    public class Crud {
        public static Boolean CrearArchivo (string nombre, string contenido, string path = @"C:\", string ext = ".txt") {
            try {
                FileStream fs = File.Create (path + nombre + ext);
                byte[] content = new UTF8Encoding (true).GetBytes (contenido);
                fs.Write (content, 0, content.Length);
                fs.Close ();
            } catch (Exception) {
                return false;
            }

            return true;
        }

        public static string LeerArchivo (string nombre, string path = @"C:\", string ext = ".txt") {
            try {
                StreamReader sr = File.OpenText (path + nombre + ext);
                string linea = "", contenido = "";
                while ((linea = sr.ReadLine ()) != null) {
                    contenido += linea + "\n";
                }

                return contenido;
            } catch (Exception) {
                return "";
            }
        }

        public static Boolean BorrarArchivo (string nombre, string path = @"C:\", string ext = ".txt") {
            try {
                File.Delete (path + nombre + ext);

                return true;
            } catch (Exception) {
                return false;
            }
        }

    }
}