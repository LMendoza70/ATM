using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Cuenta_Empresa:Cuenta
    {
        //atributos ya estan heredados solo agregamos RFC
        private string rfc;
        //ya heredamos tambien las propiedades
        public string RFC
        {
            get { return rfc; }
            set { rfc = value; }
        }

        //constructor opcional 
        public Cuenta_Empresa() : base()
        {
            //solo cambio el nombre
            nombre = "Cuenta Empresa";
            rfc = "xxxx000000";
        }

        //metodos reescritos
        public override bool Deposito(float cantidad)
        {
            if (cantidad >= 1 && cantidad+50>saldo)
            {
                saldo = saldo + cantidad - 50;
                return true;
                
            }

            return false;
        }

        public override bool Retiro(float cantidad)
        {
            if (cantidad >= 1 && cantidad <= saldo-50)
            {
                saldo = saldo - cantidad;
                return true;
                
            }

            return false;
        }
    }
}
