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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("tu_cadena_de_conexion"))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // Insertar cabecera
                    string sqlVenta = "INSERT INTO Ventas (IdCliente, Total) OUTPUT INSERTED.IdVenta VALUES (@IdCliente, @Total)";
                    decimal total = productos.Sum(p => p.cantidad * p.precio);

                    SqlCommand cmdVenta = new SqlCommand(sqlVenta, conn, tran);
                    cmdVenta.Parameters.AddWithValue("@IdCliente", idCliente);
                    cmdVenta.Parameters.AddWithValue("@Total", total);

                    int idVenta = (int)cmdVenta.ExecuteScalar();

                    // Insertar detalle
                    foreach (var p in productos)
                    {
                        string sqlDetalle = "INSERT INTO DetalleVenta (IdVenta, IdProducto, Cantidad, PrecioUnitario) VALUES (@IdVenta, @IdProducto, @Cantidad, @Precio)";
                        SqlCommand cmdDetalle = new SqlCommand(sqlDetalle, conn, tran);
                        cmdDetalle.Parameters.AddWithValue("@IdVenta", idVenta);
                        cmdDetalle.Parameters.AddWithValue("@IdProducto", p.idProducto);
                        cmdDetalle.Parameters.AddWithValue("@Cantidad", p.cantidad);
                        cmdDetalle.Parameters.AddWithValue("@Precio", p.precio);
                        cmdDetalle.ExecuteNonQuery();
                    }

                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }
    }
}
