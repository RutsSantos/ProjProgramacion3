using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilidades {
    class Gestor {
        private int port = 4343;
        private string host = "database";

        public Gestor (string host, int port) {
            this.port = port;
            this.host = host;
        }

        public Gestor () { }

        public virtual Boolean Conectar () {
            Console.WriteLine ("Conexion exitosa.");
            return true;
        }
    }

    class MySqlGestor : Gestor {
        public override bool Conectar () {
            Console.WriteLine ("Conexion con MySql Exitosa.");
            return true;
        }
    }

    class PolimorfismoEjemplo {
        public static void Main () {
            Gestor gestorNormal = new Gestor ();
            MySqlGestor msqlGestor = new MySqlGestor ();

            gestorNormal.Conectar ();
            msqlGestor.Conectar ();
        }
    }
}