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
    public partial class F_3_2_5_4 : Form
    {
        public F_3_2_5_4()
        {
            InitializeComponent();
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            tb_radio.Text = null;
            lb_superficie.Text = "Superficie:";
            lb_volumen.Text = "Volumen:";
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_radio.Text.Length > 0)
                {

                    double radio = Convert.ToDouble(tb_radio.Text);

                    double superficie = 4 * Math.PI * Math.Pow(radio, 2);
                    double volumen = 4 / 3 * Math.PI * Math.Pow(radio, 3);

                    lb_superficie.Text = "Superficie: " + Math.Round(superficie, 5);
                    lb_volumen.Text = "Volumen: " + Math.Round(volumen, 5);
                }
                else
                {
                    return;
                }
            }
            catch
            {
               MessageBox.Show("No se ha podido completar la operación, inserte datos correctos");
            }
        }
    }
}
