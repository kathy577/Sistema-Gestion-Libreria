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
    public partial class frmNuevasVentas : Form
    {
        public frmNuevasVentas()
        {
            InitializeComponent();
        }

        private void btnVentaNeuva_Click(object sender, EventArgs e)
        {
            string cliente = cmbClientes.SelectedItem.ToString();
            string producto = cmbProductos.SelectedItem.ToString();
            int cantidad = int.Parse(txtCantidad.Text);

            
            decimal precioUnitario = ObtenerPrecioProducto(producto);
            decimal total = cantidad * precioUnitario;

            MessageBox.Show($"Cliente: {cliente}\nProducto: {producto}\nCantidad: {cantidad}\nTotal: {total:C}",
                            "Nueva Venta");
        }
    }
}
