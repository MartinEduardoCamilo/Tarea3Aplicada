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
    public partial class NeumaticoEnumeracioncs : Form
    {
        public NeumaticoEnumeracioncs()
        {
            InitializeComponent();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            string complemeto = "El neumatico es: ";
            Enumeracion neumatico = new Enumeracion();
            MessageBox.Show(complemeto + neumatico.AsignarValoresEImprimir(NeumaticoComboBox.SelectedIndex).ToString() + " de " + CriterioTextBox.Text);
        }
    }
}
