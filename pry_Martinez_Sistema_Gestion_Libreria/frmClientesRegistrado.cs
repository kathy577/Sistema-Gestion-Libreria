using System;
using System.Collections;
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
    public partial class frmClientesRegistrado : Form
    {
        public frmClientesRegistrado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarReporte_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("tu_cadena_de_conexion"))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvClientesR.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmClientesRegistrado_Load(object sender, EventArgs e)
        {

        }
    }
}
