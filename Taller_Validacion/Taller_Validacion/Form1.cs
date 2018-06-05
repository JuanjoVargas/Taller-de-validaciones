using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Validacion
{
    public partial class FrmPrestacionServicio : Form
    {
      
        public FrmPrestacionServicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Collections.Generic.List<TipoDocumento>
               tiposDocumentos = new List<TipoDocumento>();

            tiposDocumentos.Add(new TipoDocumento { IdPaciente = 1, Nombre = "Cédula de Ciudadanía" });
            tiposDocumentos.Add(new TipoDocumento { IdPaciente = 2, Nombre = "NUIP" });
            tiposDocumentos.Add(new TipoDocumento { IdPaciente = 3, Nombre = "Tarjeta de Extranjería" });
            tiposDocumentos.Add(new TipoDocumento { IdPaciente = 4, Nombre = "Tarjeta de Identidad" });

            cbxTipoDocumento.DataSource = tiposDocumentos;
            cbxTipoDocumento.DisplayMember = "Nombre";


            System.Collections.Generic.List<Rango>
                Rango = new List<Rango>();

            Rango.Add(new Rango { IdPaciente = 1, Nombre = "A" });
            Rango.Add(new Rango { IdPaciente = 2, Nombre = "B" });
            Rango.Add(new Rango { IdPaciente = 3, Nombre = "C" });

            cbxRango.DataSource = Rango;
            cbxRango.DisplayMember = "Nombre";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty (txtNombre.Text)) 
            {
                MessageBox.Show ("Debes escribir tu Nombre");
            }
                      
            if (string.IsNullOrEmpty (cbxTipoDocumento.Text))
            {
                MessageBox.Show ("Seleccione un tipo de documento");
            }
                       
            if (string.IsNullOrEmpty (rbtnFemenino.Text))
            {
                MessageBox.Show ("Seleccione algun sexo");
            }

            if (string.IsNullOrEmpty (rbtnMasculino.Text))
            {
                MessageBox.Show ("Seleccione algun sexo");
            }

            if (string.IsNullOrEmpty (txtNumeroDocumento.Text))
            {
                MessageBox.Show ("Ingresa tu numero de documento");
            }
         
            if (string.IsNullOrEmpty (cbxRango.Text))
            {
                MessageBox.Show ("Ingrese el rango");
            }
                                 
            if (((TipoDocumento)cbxTipoDocumento.SelectedItem).IdPaciente == 2)
            {
                if (Convert.ToInt64(txtNumeroDocumento.Text) > 1000000000)
                {
                    MessageBox.Show ("Se debe ingresar un número de documento valido");
                }

                if (Convert.ToInt64(txtNumeroDocumento.Text) < 9999999999)
                {
                    MessageBox.Show ("Se debe ingresar un número de documento valido");
                }

                return;
            }

            if (string.IsNullOrEmpty(txtCostoServicio.Text))
            {
                MessageBox.Show ("Ingrese el costo del servicio");
            }

            if ((Convert.ToInt64(txtCostoServicio.Text) <= 0))
            {
                MessageBox.Show ("Ingrese un costo de servicio valido");
            }
            else
            {
                MessageBox.Show("Todo está en orden, Muchas Gracias."); 
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double TotalPago = 0;

            if (((Rango)cbxRango.SelectedItem).IdPaciente == 1)
            {
                TotalPago = (Convert.ToInt64(txtCostoServicio.Text) - ((Convert.ToInt64(txtCostoServicio.Text) * 0.30)));
            }

            if (((Rango)cbxRango.SelectedItem).IdPaciente == 2)
            {
                TotalPago = (Convert.ToInt64(txtCostoServicio.Text) - ((Convert.ToInt64(txtCostoServicio.Text) * 0.20)));
            }

            if (((Rango)cbxRango.SelectedItem).IdPaciente == 3)
            {
                TotalPago = (Convert.ToInt64(txtCostoServicio.Text) - ((Convert.ToInt64(txtCostoServicio.Text) * 0.10)));
            }

            MessageBox.Show("Valor que debe pagar: " + TotalPago);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
