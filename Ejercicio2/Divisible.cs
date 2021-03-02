using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Divisible : Form
    {
        public Divisible()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int Resultado = 0, Residuo = 0, numero1=0,numero2=0;
            if (btnDividir.Text.Equals("Dividir"))
            {
                
                if ((esEntero(txtNumero1.Text)) && ((esEntero(txtNumero2.Text))))
                {
                    numero1 = Int32.Parse(txtNumero1.Text);
                    numero2 = Int32.Parse(txtNumero2.Text);
                    Resultado = numero1 / numero2;
                    Residuo = numero1 % numero2;
                    lblNumero1.Text = "Resultado";
                    txtNumero1.Text = Resultado.ToString();
                    txtNumero1.Enabled = false;
                    lblNumero2.Text = "Residuo";
                    txtNumero2.Text = Residuo.ToString();
                    txtNumero2.Enabled = false;
                    if(Residuo==0)
                        MessageBox.Show("El número " + numero1.ToString() + " si es divisible entre el número " + numero2.ToString() + ".") ;
                    else
                        MessageBox.Show("El número " + numero1.ToString() + " No es divisible entre el número " + numero2.ToString() + ".");
                    btnDividir.Text="Nuevo";
                }
                else { MessageBox.Show("Los numeros no son enteros"); }
            }
            else {
                lblNumero1.Text = "Numero 1";
                txtNumero1.Enabled = true;
                lblNumero2.Text = "Numero 2";
                txtNumero2.Enabled = true;
                btnDividir.Text = "Dividir";

            }
        }

        private bool esEntero(string numero)
        {
            try
            {
                Int32.Parse(numero);
                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}
