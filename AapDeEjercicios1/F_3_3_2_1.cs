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
    public partial class F_3_3_2_1 : Form
    {
        public F_3_3_2_1()
        {
            InitializeComponent();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_letra1.Text.Length > 1 || tb_letra2.Text.Length > 1 || tb_letra3.Text.Length > 1 || tb_letra4.Text.Length > 1)
                {
                    MessageBox.Show("Solo se admite un caracter por campo");
                    return;
                }

                if (tb_letra1.Text.Length < 1 || tb_letra2.Text.Length < 1 || tb_letra3.Text.Length < 1 || tb_letra4.Text.Length < 1)
                {
                    MessageBox.Show("Complete todos los campos");
                    return;
                }


                lb_inverso.Text = "Inverso: \"" + tb_letra4.Text + tb_letra3.Text + tb_letra2.Text + tb_letra1.Text + "\"";
            }
            catch
            {
                MessageBox.Show("No se ha podido realizar la conversion, introduzca solo 1 letra");
            }
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            tb_letra1.Text = null;
            tb_letra2.Text = null;
            tb_letra3.Text = null;
            tb_letra4.Text = null;
            lb_inverso.Text = "Inverso:";
        }
    }
}
