using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace pry_Martinez_Sistema_Gestion_Libreria
{
    public class ClientesDAO
    {
        private string connectionString = "Server=.;Database=LibreriaDB;Trusted_Connection=True;";
        public void Agregar(Cliente cliente)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Clientes (Nombre, Apellido, Telefono, Email) VALUES (@Nombre, @Apellido, @Telefono, @Email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }



    }
}
