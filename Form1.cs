using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class btncalcularopciones : Form
    {
        public btncalcularopciones()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta=0;
            num1 = double.Parse(txb1.Text);
            num2 = double.Parse(txb2.Text);
            if (optsuma.Checked) {
            respuesta = num1 + num2;
            }
            if (optresta.Checked)
            {
                respuesta = num1 - num2;
            }
            if (optmultiplicacion.Checked)
            {
                respuesta = num1 * num2;
            }
            if (optdivicion.Checked)
            {
                respuesta = num1 / num2;
            }
            if (optexponente.Checked)
            {
                respuesta = Math.Pow(num1, num2);
            }
            //porcentaje
            //factorial 5! = 5*4*3*2*1=120.
            //
           
            lblrespuesta.Text = "Respuesta: " + respuesta;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = double.Parse(txb1.Text);
            num2 = double.Parse(txb2.Text);

            switch (cboopciones.SelectedIndex)
            {
                case 0:
                    respuesta = num1 + num2;
                    break;
                case 1:
                    respuesta = num1 - num2;
                    break;
                case 2:
                    respuesta = num1 * num2;
                    break;
                case 3:
                    respuesta = num1 / num2;
                    break;
                  
            }
            lblrespuesta.Text = "Respuesta: " + respuesta;
        }

        private void lblrespuesta_Click(object sender, EventArgs e)
        {

        }
    }
}
