using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pry_Martinez_Sistema_Gestion_Libreria
{
    public partial class FrmClientes : Form
    {
        string connectionString =
      "Server=localhost\\SQLEXPRESS;Database=LibreriaDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Clientes (Nombre, Apellido, Telefono, Email) VALUES (@Nombre, @Apellido, @Telefono, @Email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente agregado correctamente");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT IdCliente, LTRIM(RTRIM(Nombre)) AS Nombre, LTRIM(RTRIM(Apellido)) AS Apellido, Telefono, Email FROM Clientes";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvClientes.AutoGenerateColumns = true; // asegura que se generen bien
                dgvClientes.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["IdCliente"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Clientes SET Nombre=@Nombre, Apellido=@Apellido, Telefono=@Telefono, Email=@Email WHERE IdCliente=@IdCliente";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente modificado correctamente");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["IdCliente"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Clientes WHERE IdCliente=@IdCliente";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente eliminado correctamente");
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {


        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}