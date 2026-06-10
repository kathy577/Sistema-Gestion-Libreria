using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_Martinez_Sistema_Gestion_Libreria
{
    public partial class frmMenuPrincipal : Form
    {
        string connectionString =
    "Server=localhost\\SQLEXPRESS;Database=LibreriaDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores frm = new FrmProveedores();
            frm.ShowDialog();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al Sistema de Librería", "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Librería v1.0\nDesarrollado por Martinez Katherina \n2026\nComision : Turno Noche\nContacto: kmartinez00896@gmail.com",
                "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void nuevasVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevasVentas frm = new frmNuevasVentas();
            frm.ShowDialog();
        }

        private void productosConBajoStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes();
            frm.ShowDialog();
        }

        private void clientesRegistradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesRegistrado frm = new frmClientesRegistrado();
            frm.ShowDialog();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorialVentas frm = new frmHistorialVentas();
            frm.ShowDialog();
        }
    }
}
