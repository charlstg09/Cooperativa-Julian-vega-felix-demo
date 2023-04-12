using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cooperativa_Julian_vega_felix.capa_de_datos
{
    internal class Class1
    {
        string cadena_conexion = @"Data Source=LAPTOP-U15LF2GP;Initial Catalog=login;Integrated Security=True";

        private SqlConnection conexion;


        public Class1()
        {
            SqlConnection conexion = new SqlConnection(cadena_conexion);
           
        }

        public void abrir_conexion()
        {
            conexion.Open();
        }

        public void cerrar_conexion()
        {
            conexion.Close();
        }
        
       
        


    }
}
