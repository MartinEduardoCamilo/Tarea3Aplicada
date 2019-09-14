using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3.UI
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            ProductoTienda.TiendaProductos tienda = new ProductoTienda.TiendaProductos();
            try
            {
                int Codigo = Convert.ToInt32(CodigoNumericUpDown.Value);
                string nombre = NombreTextBox.Text;
                int cantidad = Convert.ToInt32(CantidadTextBox.Text);
                double precio = Convert.ToDouble(PrecioTextBox.Text);
                string departamento = DepartamentoTextBox.Text;
                tienda = new ProductoTienda.TiendaProductos(Codigo, nombre, cantidad, precio, departamento);
                MessageBox.Show(tienda.ToString());
            }
            catch (FormatException error)
            {
                MessageBox.Show("Errro " + error);
            }
        }
    }
}
