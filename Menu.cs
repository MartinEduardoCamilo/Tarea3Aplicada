using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea3.UI;

namespace Tarea3
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void EstructuraDeUnaTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos tienda = new Productos();
            tienda.MdiParent = this;
            tienda.Show();
        }

        private void EstucturaDelDueñoDeLaMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DueñodelaMascota mascota = new DueñodelaMascota();
            mascota.MdiParent = this;
            mascota.Show();

        }

        private void EnumeracionDeNeumaticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeumaticoEnumeracioncs neumatico = new NeumaticoEnumeracioncs();
            neumatico.MdiParent = this;
            neumatico.Show();
        }

        private void DiseñoDelInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiseñoDeInventario inventario = new DiseñoDeInventario();
            inventario.MdiParent = this;
            inventario.Show();
        }

        private void EscuelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Escuela escuela = new Escuela();
            escuela.MdiParent = this;
            escuela.Show();
        }

       

        private void PoligonoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PoligonoForm poligono = new PoligonoForm();
            poligono.MdiParent = this;
            poligono.Show();
        }
    }
}
