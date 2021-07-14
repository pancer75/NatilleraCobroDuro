using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatilleraCobroDuro
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            btnSolicitudPrestamo.Enabled = false;
        }


        private void controlBotones()
        {
            if (Nombre.Text.Trim() != string.Empty && Nombre.Text.All(char.IsLetter))
            {
                btnSolicitudPrestamo.Enabled = true;
                errorProvider1.SetError(Nombre, "");
            }
            else
            {
                if (!(Nombre.Text.All(char.IsLetter)))
                {
                    errorProvider1.SetError(Nombre, "El nombre sólo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(Nombre, "Debe introducir su nombre");
                }
                btnSolicitudPrestamo.Enabled = false;
                Nombre.Focus();
            }
        }


        private void nombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void btnSolicitudPrestamo_Click(object sender, EventArgs e)
        {
            using (Prestamos ventanaPrestamos = new Prestamos(Nombre.Text))
                ventanaPrestamos.ShowDialog();
        }
    }
}
