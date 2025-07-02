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
        MySqlConnection con;
        public frmCuentaEmpresa()
        {
            InitializeComponent();
        }

        private void frmCuentaEmpresa_Load(object sender, EventArgs e)
        {
            coneccion = new clsConeccion();
            con = coneccion.getConecction();
            con.Close();
            loadData();
        }

        private void loadData()
        {
            con.Open();
            if (con != null)
            {
                //creamos la consulta 
                string consulta = "SELECT usuario.id, usuario.nombre, usuario.password, rol.nombre from"
                    +" usuario, rol where usuario.rol_id = rol.id ORDER BY usuario.id ";
                string consulta3 = "select * from usuario";
                //creamos un adapter que es una especie de
                //traductor para el datasource
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, con);
                //creamos un datatable 
                DataTable datos = new DataTable();
                //cargamos al tadatable con el metodo fill del adapter
                adapter.Fill(datos);
                dgvData.DataSource = datos;
                dgvData.Columns["id"].Visible = false;

                //llenamos el combo
                string consulta2 = "select * from rol";
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(consulta2, con);
                con.Close();
                DataTable data = new DataTable();
                adapter2.Fill(data);
                cmbRol.DataSource = data;
                cmbRol.ValueMember = "id";
                cmbRol.DisplayMember = "nombre";
            }
            else
            {
                MessageBox.Show("No fue posible Conectar a la base de datos...");
            }
        }

        private void dgvData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvData.Rows[e.RowIndex];
                txtNombre.Text = fila.Cells["nombre"].Value?.ToString();
                //txtPassword.Text = fila.Cells["password"].Value?.ToString();
                cmbRol.Text = fila.Cells["nombre1"].Value?.ToString();
                lblid.Text = fila.Cells["id"].Value?.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string nom = txtNombre.Text;
            string pass = txtPassword.Text;
            int rol = Convert.ToInt32(cmbRol.SelectedValue);

            con.Open();
            pass = BCrypt.Net.BCrypt.HashPassword(pass);
            //creamos la consulta 
            string consulta = "insert into usuario (nombre, password,rol_id)"+
                "values (@nombre, @password, @rol_id)";
            MySqlCommand command = new MySqlCommand(consulta, con);
            command.Parameters.AddWithValue("@nombre", nom);
            command.Parameters.AddWithValue("@password", pass);
            command.Parameters.AddWithValue("@rol_id", rol);
            int filasAfectadas=command.ExecuteNonQuery();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Registro exitoso...");
                loadData();
            }
            else
            {
                MessageBox.Show("Error al agregar nuevo registro...");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nom = txtNombre.Text;
            string pass = txtPassword.Text;
            int rol = Convert.ToInt32(cmbRol.SelectedValue);
            int id = Convert.ToInt32(lblid.Text);

            string passHash = "";
            if (!string.IsNullOrEmpty(pass))
            {
                passHash = BCrypt.Net.BCrypt.HashPassword(pass);
            }
            con.Open();

            MySqlCommand command;
            if (!string.IsNullOrEmpty(passHash))
            {
                //creamos la consulta
                string consulta = "update usuario set nombre=@nombre, password=@password," +
                    " rol_id=@rol_id where id=@id";
                command = new MySqlCommand(consulta, con);
                command.Parameters.AddWithValue("@password", passHash);
            }
            else
            {
                string consulta = "update usuario set nombre=@nombre, rol_id=@rol_id where id=@id";
                command = new MySqlCommand(consulta, con);
            }
            command.Parameters.AddWithValue("@nombre", nom);
            command.Parameters.AddWithValue("@rol_id", rol);
            command.Parameters.AddWithValue("@id", id);
            int filasafectadas = command.ExecuteNonQuery();
            con.Close();
            if (filasafectadas > 0)
            {
                MessageBox.Show("Actualizacion Correcta");
                loadData();
            }
            else
            {
                MessageBox.Show("hay pex");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblid.Text);
            string nombre = txtNombre.Text;

            DialogResult result = MessageBox.Show("En realidad quieres eliminar al usuario : "+nombre,
                "Eliminar",MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }


            con.Open();

            try
            {
                string consulta = "delete from usuario where id=@id";
                MySqlCommand command = new MySqlCommand(consulta, con);
                command.Parameters.AddWithValue("@id", id);
                int filasAfectadas = command.ExecuteNonQuery();
                con.Close();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Registro eliminado Correctamente...");
                    loadData();
                }
                else
                {
                    MessageBox.Show("No se elimino ningun registro");
                }
            }
            catch(MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show("Imposible eliminar registro por que existen relaciones ligadas a el...");
                }
                else
                {
                    MessageBox.Show("Imposible Elimnar Registro " + ex.Number);
                }
                
            }
            
            
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string criterio = txtBusqueda.Text;

            con.Open();

            string consulta = "SELECT usuario.id, usuario.nombre, usuario.password, rol.nombre from"
                    + " usuario, rol where usuario.rol_id = rol.id and usuario.nombre like @criterio  ORDER BY usuario.id ";

            MySqlCommand command = new MySqlCommand(consulta, con);
            command.Parameters.AddWithValue("@criterio","%"+ criterio +"%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvData.DataSource = table;
            dgvData.Columns["id"].Visible = false;
            con.Close();
        }
    }
}
