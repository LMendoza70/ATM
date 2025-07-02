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
    public partial class frmPrincipal : Form
    {
        //creamos instancias de los formularios que vamos a abrir dentro
        //de nuestro MDI
        private Form1 form1;
        private frmCuentaEmpresa empresa;
        private frmCuentas cuentas;
        string user;
        int rol;
        public frmPrincipal(string usuario, int rolid)
        {
            InitializeComponent();
            user = usuario;
            rol = rolid;
        }

        private void tsmFrom1_Click(object sender, EventArgs e)
        {
            if (form1==null || form1.IsDisposed)
            {
                form1 = new Form1();
                form1.MdiParent = this;
                form1.Show();
            }
            else
            {
                form1.BringToFront();
            }
            
        }

        private void tsmEmpresa_Click(object sender, EventArgs e)
        {
            if(empresa==null || empresa.IsDisposed)
            {
                empresa = new frmCuentaEmpresa();
                empresa.MdiParent = this;
                empresa.Show();
            }
            else
            {
                empresa.BringToFront();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cuentas==null || cuentas.IsDisposed)
            {
                cuentas = new frmCuentas();
                cuentas.MdiParent = this;
                cuentas.Show();
            }
            else
            {
                cuentas.BringToFront();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Welcome user : " + user+" Rol id : "+rol;

            if (rol == 2)
            {
                tsmFrom1.Visible = false;
            }
        }
    }
}
