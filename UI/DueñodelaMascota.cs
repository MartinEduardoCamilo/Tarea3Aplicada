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
    public partial class DueñodelaMascota : Form
    {
        public DueñodelaMascota()
        {
            InitializeComponent();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            MascotaDueño.Dueño dueño = new MascotaDueño.Dueño();
            try
            {
                string nombreDueño = NombreTextBox.Text;
                string apellidoDueño = ApellidoTextBox.Text;
                int edadDueño = Convert.ToInt32(EdadTextBox.Text);
                string nombreMascota = NombreMascotaTextBox.Text;
                string colorMascota = ColorMascotaTextBox.Text;
                string razaMascota = RazaMascotaTextBox.Text;
                double pesoMascota = Convert.ToDouble(PesoTextBox.Text);
                dueño = new MascotaDueño.Dueño(nombreDueño, apellidoDueño, edadDueño, nombreMascota, colorMascota, razaMascota, pesoMascota);
                MessageBox.Show(dueño.ToString());
            }
            catch (Exception error)
            {

                MessageBox.Show("Error " + error);
            }
        }
    }
}
