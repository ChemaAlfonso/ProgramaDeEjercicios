using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AapDeEjercicios1
{
    public partial class F_4_1_3_8 : Form
    {
        private double[] numeros = new double[3];
        private double modulo;

        public F_4_1_3_8()
        {
            InitializeComponent();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (tb_numero1.Text.Length == 0 || tb_numero2.Text.Length == 0 || tb_numero3.Text.Length == 0)
                {
                    MessageBox.Show("Rellene todos los campos");
                    return;
                }
                double num1 = Convert.ToDouble(tb_numero1.Text);
                double num2 = Convert.ToDouble(tb_numero2.Text);
                double num3 = Convert.ToDouble(tb_numero3.Text);

                numeros[0] = Math.Pow(num1,2);
                numeros[1] = Math.Pow(num2, 2);
                numeros[2] = Math.Pow(num3, 2);

                modulo = Math.Sqrt(numeros.Sum());

                lb_modulo.Text = "Modulo: " + modulo.ToString("0.##");

            }
            catch
            {
                MessageBox.Show("No se ha podido completar la operación, introduzca datos adecuados a la operación");
            }
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            lb_modulo.Text = "Modulo:";
            tb_numero1.Text = null;
            tb_numero2.Text = null;
            tb_numero3.Text = null;
        }
    }
}
