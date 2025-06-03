using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        //atributos
        private CuentaFree cuenta;
        public Form1()
        {
            cuenta = new CuentaFree();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = cuenta.Nombre;
            this.txtNumCuenta.Text = cuenta.NumCuenta;
            txtSaldo.Text = "$ " + cuenta.Saldo;

        }

        private void btnDesposito_Click(object sender, EventArgs e)
        {
            if(txtCantidad.Text != "")
            {

                cuenta.Deposito(float.Parse(txtCantidad.Text));
                txtSaldo.Text = "$ " + cuenta.Saldo;
                txtCantidad.Text = "";

            }
        }
    }
}
