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
            //lista de cuentas 
            ArrayList Cuentas = new ArrayList();
            //creamos algunas cuentas aleatorias
            Cuentas.Add(new CuentaJR("5436423654852", "Luis Alberto Mendoza", 5000));
            Cuentas.Add(new CuentaJR("1234567890123", "Juan Perez Gomez", 4500));
            Cuentas.Add(new CuentaJR("9876543210987", "Maria Lopez Diaz", 3200));
            Cuentas.Add(new CuentaJR("4567891234567", "Carlos Sanchez Ruiz", 7800));
            Cuentas.Add(new CuentaJR("7891234567891", "Ana Garcia Torres", 1500));
            Cuentas.Add(new CuentaJR("3216549873216", "Pedro Martinez Luna", 6200));
            Cuentas.Add(new CuentaJR("6549873216549", "Sofia Hernandez Cruz", 2900));
            Cuentas.Add(new CuentaJR("1472583691472", "Luis Gonzalez Vega", 5100));
            Cuentas.Add(new CuentaJR("2583691472583", "Elena Ramirez Soto", 8700));
            Cuentas.Add(new CuentaJR("3691472583691", "Miguel Castro Nunez", 4300));
            Cuentas.Add(new CuentaJR("7418529637418", "Laura Morales Pena", 6600));
            dgvCategorias.DataSource = Cuentas;
        

            cmbCategorias.DataSource = categoria;
            cmbCategorias.DisplayMember = "nombre";
            cmbCategorias.ValueMember = "id";

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

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CuentaJR seleccionado = (CuentaJR)dgvCategorias.Rows[e.RowIndex].DataBoundItem;
                txtCliente.Text = seleccionado.Nombre;
                txtCuenta.Text = seleccionado.NumCuenta;
                txtSaldoG.Text = "$"+seleccionado.Saldo;
            }
        }

        private void dgvCategorias_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CuentaJR seleccionado = (CuentaJR)dgvCategorias.Rows[e.RowIndex].DataBoundItem;
            txtCliente.Text = seleccionado.Nombre;
            txtCuenta.Text = seleccionado.NumCuenta;
            txtSaldoG.Text = "$" + seleccionado.Saldo;

        }

        private void btnIngre_Click(object sender, EventArgs e)
        {
            string lista = "Su pizza ";
            //ifs para la especialidad
            if (rdbSarten.Checked)
                lista += "de Sarten ";
            if (rdbQueso.Checked)
                lista += "con Orilla rellena de queso ";
            if (rdbItaliana.Checked)
                lista += "Italiana ";

            //ifs de los radio solo va a tomar 1 
            if (rdbIndividual.Checked)
                lista += "Individual es de \n";
            if (rdbMediano.Checked)
                lista += "Mediana es de \n";
            if (rdbGrande.Checked)
                lista += "Grande es de \n";
            

            //ifs de los check puede tomar todos 
            if (chbPep.Checked)
                lista = lista + "* Peperoni\n";
            if (chbPina.Checked)
                lista += "* Piña\n";
            if (chbTosino.Checked == true)
            {
                lista = lista + "* Tocino\n";
            }
            if (chbChamp.Checked)
                lista += "* Champiñones";

            MessageBox.Show(lista);
        }
    }
}
