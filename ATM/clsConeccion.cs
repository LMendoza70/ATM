using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM
{
    class clsConeccion
    {
        //Marcamos el atributo Cadena de coneccion
        private string cadenaConeccion;

        //constructor para inicializar mi cadena de coneccion 
        public clsConeccion()
        {
            cadenaConeccion = "Server=127.0.0.1; Database=ejemplo_clase; Uid=root; Pwd=; Port=3306;";
        }

        //agregamos el metodo getConecction 
        public MySqlConnection getConecction()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cadenaConeccion);
                con.Open();
                return con;
            }
            catch
            { 
                return null;
            }
        }
       
    }
}
