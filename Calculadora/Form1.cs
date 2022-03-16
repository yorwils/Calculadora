using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char operador;
            
        public Form1()
        {
            InitializeComponent();
        }

        private void agregaNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (txtResultado.Text == "0")
            {
                txtResultado.Text ="";

              
            }
            txtResultado.Text += boton.Text;
        }
        private void clicKOperador(object sender, EventArgs e)
        {

            var boton = ((Button)sender);
            Numero1 = Convert.ToDouble(txtResultado.Text);
            operador = Convert.ToChar(boton.Tag);
            if (operador == '²')
            {
                Numero1 = Math.Pow(Numero1, 2);
                txtResultado.Text = Numero1.ToString();

            }
            if (operador == '√')
            {
                Numero1 = Math.Sqrt(Numero1);
                txtResultado.Text = Numero1.ToString();

            }
            else
            {
            
            txtResultado.Text = "0";
            }
           

            
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble  (txtResultado.Text);
            operador = '+';
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(txtResultado.Text);
            if (operador == '+')
            {
                txtResultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
                
            }
            else if (operador == '-')
            {
                txtResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '*')
            {
                txtResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '/')
            {
                if (txtResultado.Text != "0")
                {
             txtResultado.Text = (Numero1 / Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
                }
                else
                {
                    MessageBox.Show("no se puede divir entre cero");
                }
              
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length >1 )
            {
                txtResultado.Text = txtResultado.Text.Substring(0,txtResultado.Text.Length);

            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            txtResultado.Text = "0";




        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0"; 
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Contains("."));

            {
                    txtResultado.Text +=".";
            }
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Numero1 *= -1;
            txtResultado.Text = Numero1.ToString(); 
        }

      


    
    }
}
