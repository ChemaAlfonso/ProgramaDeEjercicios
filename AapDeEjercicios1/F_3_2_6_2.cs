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
    public partial class F_3_2_6_2 : Form
    {
        private string lastColor;

        public F_3_2_6_2()
        {
            InitializeComponent();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            if (tb_rojo.Text.Length > 0 && tb_verde.Text.Length > 0 && tb_azul.Text.Length > 0)
            {
                try
                {
                    int rojo = Convert.ToInt32(tb_rojo.Text);
                    int verde = Convert.ToInt32(tb_verde.Text);
                    int azul = Convert.ToInt32(tb_azul.Text);

                    string rojoHex = Convert.ToString(rojo, 16);
                    string verdeHex = Convert.ToString(verde, 16);
                    string azulHex = Convert.ToString(azul, 16);


                    lb_hex.Text = "Hexadecimal: #" + rojoHex + verdeHex + azulHex;
                    lastColor = rojoHex + verdeHex + azulHex;
                    bt_copiar.Visible = true;
                }
                catch
                {
                    MessageBox.Show("No se ha podido realizar la conversión, introduzca un numero correcto");
                }

            }
            else
            {
                return;
            }
        }

        private void bt_copiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lastColor);
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            tb_rojo.Text = null;
            tb_verde.Text = null;
            tb_azul.Text = null;
            lb_hex.Text = "Hexadecimal:";
            bt_copiar.Visible = false;
        }
    }
}
