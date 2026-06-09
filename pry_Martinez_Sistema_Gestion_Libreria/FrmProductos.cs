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
    public partial class FrmProductos : Form
    {
        string connectionString =
    "Server=localhost\\SQLEXPRESS;Database=LibreriaDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Productos (Descripcion, Precio, Stock) VALUES (@Descripcion, @Precio, @Stock)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text));
                cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto agregado correctamente");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Productos";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdProducto"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Productos SET Descripcion=@Descripcion, Precio=@Precio, Stock=@Stock WHERE IdProducto=@IdProducto";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text));
                cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));
                cmd.Parameters.AddWithValue("@IdProducto", idProducto);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto modificado correctamente");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdProducto"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Productos WHERE IdProducto=@IdProducto";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdProducto", idProducto);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto eliminado correctamente");
            }

        }

        private void lblStock_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
