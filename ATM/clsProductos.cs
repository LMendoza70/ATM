using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class clsProductos
    {
        //atributos
        private int id;
        private string nombre;
        private double precio;
        private int stock;
        private int categoria;
        //propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        //constructor
        public clsProductos(int _id, string _nombre, double _precio, int _stock, int _categoria)
        {
            id = _id;
            nombre = _nombre;
            precio = _precio;
            stock = _stock;
            categoria = _categoria;
        }
    }
}
