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

namespace pry_Martinez_Sistema_Gestion_Libreria
{
    public partial class FrmProveedores : Form
    {
        string connectionString =
    "Server=localhost\\SQLEXPRESS;Database=LibreriaDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void lblRazonSocial_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Proveedores (RazonSocial, Telefono, Email) VALUES (@RazonSocial, @Telefono, @Email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RazonSocial", txtRazonSocial.Text);
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Proveedor agregado correctamente");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idProveedor = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdProveedor"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Proveedores SET RazonSocial=@RazonSocial, Telefono=@Telefono, Email=@Email WHERE IdProveedor=@IdProveedor";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RazonSocial", txtRazonSocial.Text);
                cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Proveedor modificado correctamente");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idProveedor = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdProveedor"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Proveedores WHERE IdProveedor=@IdProveedor";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Proveedor eliminado correctamente");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Proveedores";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
