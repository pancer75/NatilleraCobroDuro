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
    public partial class Prestamos : Form
    {

        string nombre_cliente;
        string[] tipos_documento = { "Cedula ciudadania", "Pasaporte", "Tarjeta identidad" };
        int[] cuotas_disponibles = { 1, 3, 5, 7, 8, 9, 10 };
        string[] barrios_disponibles;
        Dictionary<int, double> intereses_base;



        public Prestamos(String nombre)
        {
            InitializeComponent();
            nombre_cliente = nombre;

            string listado_barrios = Properties.Resources.Barrios.ToString();
            barrios_disponibles = listado_barrios.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            intereses_base = new Dictionary<int, double>();
            int i;
            double interes;
            for (i = 0, interes = 3.0; i < cuotas_disponibles.Length; i++, interes += 0.5)
            {
                intereses_base[cuotas_disponibles[i]] = interes;
            }
        }


        private void Prestamos_Load(object sender, EventArgs e)
        {
            popularCuotas();
            populardocumentos();
            popularbarrios();
            Saludo.Text += nombre_cliente;
        }

        void popularCuotas()
        {
            for (int i = 0; i < cuotas_disponibles.Length; i++)
            {
                cuotas.Items.Add(cuotas_disponibles[i]);
            }

        }

        void populardocumentos()
        {
            for (int i = 0; i < tipos_documento.Length; i++)
            {
                tipodocumento.Items.Add(tipos_documento[i]);
            }
        }

        void popularbarrios()
        {
            for (int i = 0; i < barrios_disponibles.Length; i++)
            {
                barrio.Items.Add(barrios_disponibles[i]);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        double calcularinteres()
        {
            int cuotas_pedidas = (int)cuotas.SelectedItem;
            string documento_seleccionado = tipodocumento.SelectedItem.ToString().ToLower();
            string barrio_seleccionado = barrio.SelectedItem.ToString().ToLower();
            double interes = intereses_base[cuotas_pedidas];
            if (new[] { "Pasaporte", "Tarjeta identidad" }.Contains(documento_seleccionado))
            {
                interes += 0.3;
            }
            if (new[] { "Barrio Popular", "Santa Cruz", "Manrique", "Aranjuez" }.Contains(barrio_seleccionado))
            {
                interes -= 0.3;
            }
            return interes;
        }

        private void BtnConfirmarSolicitud_Click(object sender, EventArgs e)
        {
            switch (validaciones())
            {
                case 0:
                    {
                        errorProvider1.SetError(DatosPersonales, "");
                        errorProvider1.SetError(DatosPrestamo, "");
                        double interes_mensual = calcularinteres();
                        double monto_pedido = double.Parse(monto.Text);
                        int cuotas_pedidas = (int)cuotas.SelectedItem;
                        double interes_total = monto_pedido * (interes_mensual / 100) * cuotas_pedidas;
                        double monto_a_pagar = monto_pedido + interes_total;
                        string mensaje = "Su préstamo por " + monto_pedido + "en" + cuotas_pedidas + "cuotas se concederá con un ienterés del " + interes_mensual + "% mensual\nEl monto final asciende a " + monto_a_pagar;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Cálculo de interéses", buttons);
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(DatosPersonales, "Debe completar todos los datos personales");
                        errorProvider1.SetError(DatosPrestamo, "");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(DatosPrestamo, "Debe ingresar un monto numérico y una cantidad de cuotas");
                        errorProvider1.SetError(DatosPersonales, "");
                        break;
                    }


            }




            int validaciones()
            {
                if ((tipodocumento.SelectedIndex <= -1) || (barrio.SelectedIndex <= -1))
                {
                    return 1;
                }
                else
                {
                    if (!(monto.Text.All(Char.IsDigit)) || (monto.Text == "") || (cuotas.SelectedIndex <= -1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }

                }


            }



        }
    }
            
            
             
        
}


