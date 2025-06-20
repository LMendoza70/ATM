using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ATM
{
    public partial class frmCuentas : Form
    {
        ArrayList Cuentas;
        public frmCuentas()
        {
            InitializeComponent();
        }

        private void frmCuentas_Load(object sender, EventArgs e)
        {
            Cuentas = new ArrayList();
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

            //agregamos esta lista al source del datagrit
            dgvCuentas.DataSource = Cuentas;
        }

        private void dgvCuentas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
                CuentaJR seleccionado = (CuentaJR)dgvCuentas.Rows[e.RowIndex].DataBoundItem;
                txtNombre.Text = seleccionado.Nombre;
                txtCuenta.Text = seleccionado.NumCuenta;
                txtSaldo.Text = "$" + seleccionado.Saldo;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Cuentas.RemoveAt(dgvCuentas.SelectedRows[0].Index);
            Cuentas.Add(new CuentaJR(txtCuenta.Text,txtNombre.Text,float.Parse(txtSaldo.Text)));
            dgvCuentas.DataSource = null;
            dgvCuentas.DataSource = Cuentas;
            
        }
    }
}
