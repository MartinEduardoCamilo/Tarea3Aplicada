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
    public partial class DiseñoDeInventario : Form
    {
        public DiseñoDeInventario()
        {
            InitializeComponent();
        }

        private void MostrarDatosButton_Click(object sender, EventArgs e)
        {
            DiseñoDeInventario.DiseñoInventario tienda = new DiseñoDeInventario.DiseñoInventario();
            try
            {
                int ID = Convert.ToInt32(IDProductoNumericUpDown1.Value);
                string departamento = Convert.ToString(DepartamentoComboBox.SelectedItem);
                string nombreProducto = NombreTextBox.Text;
                double costroProducto = Convert.ToDouble(CostoTextBox.Text);
                double PrecioProducto = Convert.ToDouble(PrecioTextBox.Text);
                int cantidadProducto = Convert.ToInt32(CantidadmaskedTextBox.Text);
                string descripcionProducto = DescripcionTextBox.Text;
                double ITBIS = Convert.ToDouble(ITBISTextBox.Text);
                tienda = new DiseñoDeInventario.DiseñoInventario(ID, nombreProducto, departamento, costroProducto, PrecioProducto, cantidadProducto, descripcionProducto, ITBIS);
                MessageBox.Show(tienda.ToString());
            }
            catch (Exception error)
            {

                MessageBox.Show("Error" + error);
            }
        }

        private class DiseñoInventario
        {
            private int iD;
            private string nombreProducto;
            private string departamento;
            private double costroProducto;
            private double precioProducto;
            private int cantidadProducto;
            private string descripcionProducto;
            private double iTBIS;

            public DiseñoInventario()
            {
            }

            public DiseñoInventario(int iD, string nombreProducto, string departamento, double costroProducto, double precioProducto, int cantidadProducto, string descripcionProducto, double iTBIS)
            {
                this.iD = iD;
                this.nombreProducto = nombreProducto;
                this.departamento = departamento;
                this.costroProducto = costroProducto;
                this.precioProducto = precioProducto;
                this.cantidadProducto = cantidadProducto;
                this.descripcionProducto = descripcionProducto;
                this.iTBIS = iTBIS;
            }
        }
    }
}
