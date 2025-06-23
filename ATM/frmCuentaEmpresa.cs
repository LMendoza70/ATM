using MySql.Data.MySqlClient;
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
    public partial class frmCuentaEmpresa : Form
    {
        clsConeccion coneccion;
        public frmCuentaEmpresa()
        {
            InitializeComponent();
        }

        private void frmCuentaEmpresa_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            coneccion = new clsConeccion();
            MySqlConnection con = coneccion.getConecction();
            if (con != null)
            {
                //creamos la consulta 
                string consulta = "SELECT nombre,descripcion FROM categoria";
                //creamos un adapter que es una especie de
                //traductor para el datasource
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);
                con.Close();
                //creamos un datatable 
                DataTable datos = new DataTable();
                //cargamos al tadatable con el metodo fill del adapter
                adapter.Fill(datos);
                dgvData.DataSource = datos;
            }
            else
            {
                MessageBox.Show("No fue posible Conectar a la base de datos...");
            }
        }
    }
}
