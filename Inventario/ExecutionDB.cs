using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Crud = Utilidades.Crud;

namespace Utilidades {
    class ExecutionDB {
        public static DataSet Ejecutar (string query) {
            DataSet DS = new DataSet ();
            try {
                SqlConnection connector = new SqlConnection(@"Server=DESKTOP-4JCPM98\SQLEXPRESS;Database=inventario;Trusted_Connection=True;");
                connector.Open ();
                SqlDataAdapter adp = new SqlDataAdapter (query, connector);
                adp.Fill (DS);
                connector.Close ();
                return DS;
            } catch (Exception) {
                throw;
            }
        }
    }
}