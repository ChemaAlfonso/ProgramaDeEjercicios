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
    public partial class F_4_1_1_2 : Form
    {
        private double[] datos; 
        private string resutl;

        public F_4_1_1_2()
        {
            InitializeComponent();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {

            datos = new double[5];
            resutl = null;

            try
            {
                double numero1 = Convert.ToDouble(tb_numero1.Text);
                double numero2 = Convert.ToDouble(tb_numero2.Text);
                double numero3 = Convert.ToDouble(tb_numero3.Text);
                double numero4 = Convert.ToDouble(tb_numero4.Text);
                double numero5 = Convert.ToDouble(tb_numero5.Text);

                datos[0] = numero1;
                datos[1] = numero2;
                datos[2] = numero3;
                datos[3] = numero4;
                datos[4] = numero5;

                double media = datos.Average();

                foreach (double dato in datos)
                {
                    resutl += ' ' + dato.ToString("0.##");
                }


                lb_datos.Text = "Datos: " + resutl;
                lb_media.Text = "Media: " + media;

            }
            catch
            {
                MessageBox.Show("No se ha podido completar la operacion", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            tb_numero1.Text = null;
            tb_numero2.Text = null;
            tb_numero3.Text = null;
            tb_numero4.Text = null;
            tb_numero5.Text = null;
            lb_datos.Text = "Datos:";
            lb_media.Text = "Media:";
        }
    }
}
