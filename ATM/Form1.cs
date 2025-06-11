using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
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

            //trabajo con el combo
            //creo un arraylist de categorias
            ArrayList categoria = new ArrayList();
            //cargamos algunos registros al arraylist
            categoria.Add(new clsCategoria(1,"Caballero","xxxx"));
            categoria.Add(new clsCategoria(2, "Damas","dddddd"));
            categoria.Add(new clsCategoria(3,"Niños","ttttttt"));
            categoria.Add(new clsCategoria(5, "Accesorios","tttttt"));
            //asignamos el array como datasource en el combo
            cmbCategorias.DataSource = categoria;
            cmbCategorias.DisplayMember = "nombre";
            cmbCategorias.ValueMember = "id";

            //creo un arraylist de productos
            ArrayList productos = new ArrayList();
            //creo 15 registros variados al array de productos 
            productos.Add(new clsProductos(1,"chamarra",100,10,1));
            productos.Add(new clsProductos(2, "pantalon",200,20,2));
            productos.Add(new clsProductos(3,"camisa",300,30,3));
            productos.Add(new clsProductos(5, "calcetin",400,40,5));
            productos.Add(new clsProductos(6, "calcetin",400,40,5));
            productos.Add(new clsProductos(7, "calcetin",400,40,5));
            productos.Add(new clsProductos(8, "calcetin",400,40,5));
            productos.Add(new clsProductos(9, "calcetin",400,40,5));
            productos.Add(new clsProductos(10, "calcetin",400,40,5));
            productos.Add(new clsProductos(11, "calcetin",400,40,5));
            productos.Add(new clsProductos(12, "calcetin",400,40,5));
            productos.Add(new clsProductos(13, "calcetin",400,40,5));
            productos.Add(new clsProductos(14, "calcetin",400,40,5));
            productos.Add(new clsProductos(15, "calcetin",400,40,5));
            //asignamos el array como datasource en el combo
            cmbCategorias.DataSource = categoria;
            cmbCategorias.DisplayMember = "nombre";
            cmbCategorias.ValueMember = "id";
            //trabajamos con el datagritview
            dgvCategorias.DataSource = productos;

        }

        private void btnDesposito_Click(object sender, EventArgs e)
        {
            if(txtCantidad.Text != "")
            {
                try
                {
                    cuenta.Deposito(float.Parse(txtCantidad.Text));
                    txtSaldo.Text = "$ " + cuenta.Saldo;
                    txtCantidad.Text = "";
                }
                catch
                {
                    MessageBox.Show("Datos capturados no validos");
                    txtCantidad.Text = "";
                }
            }
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "solo numeros";
            }
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text!="")
            {
                try
                {
                    cuenta.Retiro(float.Parse(txtCantidad.Text));
                    txtCantidad.Text = "";
                    txtSaldo.Text = "$ " + cuenta.Saldo;
                }
                catch
                {
                    MessageBox.Show("Datos capturados no validos");
                    txtCantidad.Text = "";
                }
               
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cuenta.Estado());
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(" ");
            /*if (!char.IsDigit(e.KeyChar) )
            {
                if(e.KeyChar != (char) Keys.Back)
                    //if(e.KeyChar != '-' || ((TextBox)sender).Text.Length!=0)
                        e.Handled = true;
            }*/
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(""+e.KeyCode);
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("hola"+cmbCategorias.SelectedIndex);
            clsCategoria seleccionada = (clsCategoria) cmbCategorias.SelectedItem;
            txtId.Text = ""+seleccionada.Id;
            txtCategoria.Text = seleccionada.Nombre;
        }
    }
}
