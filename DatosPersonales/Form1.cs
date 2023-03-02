using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos_Personales__repaso_
{
    public partial class FrmDatosPersonales : Form
    {
        public FrmDatosPersonales()
        {
            //comentario de prueba para gitHub :)
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, edad ,direccion;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            edad = txtEdad.Text;
            direccion = txtDireccion.Text;
            
            if (nombre == "")
                txtNombre.BackColor = Color.Crimson;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Window;
            if (apellido == "")
                txtApellido.BackColor = Color.Crimson;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Window;
            if (edad == "")
                txtEdad.BackColor = Color.Crimson;
            else
                txtEdad.BackColor = System.Drawing.SystemColors.Window;
            if (direccion == "")
                txtDireccion.BackColor = Color.Crimson;
            else
                txtDireccion.BackColor = System.Drawing.SystemColors.Window;

            string datos ="Nombre: " +nombre + "\r\n" +"Apellido: "+ apellido + " \r\n" +"Edad: "+ edad + "\r\n" +"Direccion: " +direccion;

            if(nombre != "" && apellido != "" && edad != "" && direccion != "")
            {
                if(!primerPerfil)
                {
                primerPerfil = true;

                txtResultado.Text = datos;
                }
                 else
                    txtResultado.Text += "\r\n" + "\r\n" + datos;

            }

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
            

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDatosPersonales_Load(object sender, EventArgs e)
        {
          primerPerfil = false;
        }
    }
}
