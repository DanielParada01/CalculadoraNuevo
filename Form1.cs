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
            double num1, num2, respuesta = 0;
            num1 = double.Parse(txb1.Text);
            num2 = double.Parse(txb2.Text);
            if (optsuma.Checked)
            {
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
            
            if (optFactorial.Checked) {
                respuesta = (int)num1;
               for (int i=(int)num1 -1; i>1; i--)
                    {
                        respuesta *= i;
                    }

               }
      
            lblrespuesta.Text = "Respuesta: " + respuesta;





            if (optprimo.Checked)
            {
                int i = 0, acum = 0;
                while (i <= num1 && acum < 3)
                {
                    if (num1 % i == 0)
                    {
                        acum++; //acum = acum+0
                    }
                    i++;
                    if (acum <= 2)
                    {
                        lblrespuesta.Text = "Respuesta: " + num1 + "Es primo";
                    }
                    else
                    {
                        lblrespuesta.Text = "Respuesta: " + num1 + " No es primo";
                    }

                }
            }
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
