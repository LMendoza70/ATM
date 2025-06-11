using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class clsCategoria
    {
        //atributos
        private int id;
        private string nombre;
        private string descripcion;
        //propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        //constructor con parametros
        public clsCategoria(int _id, string _nombre,string _descripcion)
        {
            id = _id;
            nombre = _nombre;
            descripcion = _descripcion;
        }
    }
}
