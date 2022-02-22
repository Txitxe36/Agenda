using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaAgenda
{
    public partial class Form1 : Form
    {
        String [] dni = new String[10];
        String [] nombre = new String[10];
        String [] apellido = new String[10];
        String[] telefono = new String[10];
        String [] fecNac = new String[10];
        String[] direccion = new String[10];
        int indice;

        public Form1()
        {
            InitializeComponent();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            indice = Int32.Parse(bIndice.Text);

            dni[indice] = textDni.Text;
            nombre[indice] = textNombre.Text;
            apellido[indice] = textApellido.Text;
            telefono[indice] = textTel.Text;
            fecNac[indice] = textFec.Text;
            direccion[indice] = textDir.Text;
        }

        private void bAdelante_Click(object sender, EventArgs e)
        {
            indice = Int32.Parse(bIndice.Text);

            if (indice < 9)
            {
                indice = indice + 1;
            }
            textDni.Text = dni[indice];
            textNombre.Text = nombre[indice];
            textApellido.Text = apellido[indice];
            textTel.Text = telefono[indice];
            textFec.Text = fecNac[indice];
            textDir.Text = direccion[indice];

            bIndice.Text = indice.ToString();
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            indice = Int32.Parse(bIndice.Text);

            if (indice > 0)
            {
                indice = indice - 1;
            }
            textDni.Text = dni[indice];
            textNombre.Text = nombre[indice];
            textApellido.Text = apellido[indice];
            textTel.Text = telefono[indice];
            textFec.Text = fecNac[indice];
            textDir.Text = direccion[indice];

            bIndice.Text = indice.ToString();
        }

       
    }
}
