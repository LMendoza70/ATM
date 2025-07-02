using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ATM
{
    public partial class frmLogin : Form
    {
        clsConeccion coneccion;
        MySqlConnection con;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            coneccion = new clsConeccion();
            con = coneccion.getConecction();
            con.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPassword.Text;
            int rol;

            con.Open();
            string consulta = "select * from usuario where nombre=@user";
            MySqlCommand command = new MySqlCommand(consulta, con);
            command.Parameters.AddWithValue("@user", user);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string passHash = reader["password"].ToString();
                rol =Convert.ToInt32( reader["rol_id"]);

                bool verifica = BCrypt.Net.BCrypt.Verify(pass,passHash);

                if (verifica == true)
                {
                    MessageBox.Show("Logueo Correcto...\nwelcome "+user);

                    this.Hide();
                    con.Close();
                    frmPrincipal principal = new frmPrincipal(user,rol);
                    principal.Show();
                }
                else
                {
                    MessageBox.Show("Password incorrecto...");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Usuatio inexitente... ");
                con.Close();
            }


        }
    }
}
