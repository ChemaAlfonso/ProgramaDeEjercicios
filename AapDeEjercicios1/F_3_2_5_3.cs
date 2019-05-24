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
    public partial class F_3_2_5_3 : Form
    {
        public F_3_2_5_3()
        {
            InitializeComponent();
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_ancho.Text.Length > 0 && tb_alto.Text.Length > 0)
                {
                    double ancho = Convert.ToDouble(tb_ancho.Text);
                    double alto = Convert.ToDouble(tb_alto.Text);


                    double perimetro = ancho * 2 + alto * 2;
                    double area = ancho * alto;
                    double diagonal = Math.Sqrt(ancho * ancho + alto * alto);

                    lb_perimetro.Text = "Perímetro: " + Math.Round(perimetro, 3).ToString("#.00");
                    lb_area.Text = "Area: " + Math.Round(area, 3).ToString("#.00");
                    lb_diagonal.Text = "Diagonal: " + Math.Round(diagonal, 3).ToString("#.00");
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

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            tb_alto.Text = null;
            tb_ancho.Text = null;

            lb_perimetro.Text = "Perímetro:";
            lb_area.Text      = "Area:";
            lb_diagonal.Text  = "Diagonal;";
        }
    }
}
