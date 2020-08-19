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
            DataSet dataSet = new DataSet ();
            try {
                SqlConnection connnector = new SqlConnection (@"Server=DESKTOP-4JCPM98\SQLEXPRESS;Database=inventario;Trusted_Connection=True;");
                connnector.Open ();
                SqlDataAdapter op = new SqlDataAdapter (query, connnector);
                op.Fill (dataSet);
                return dataSet;
            } catch (Exception e) {
                Console.WriteLine (Convert.ToString (e) + "");
                throw;
            }
        }

    }
}