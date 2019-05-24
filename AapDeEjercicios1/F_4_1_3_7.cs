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
    public partial class F_4_1_3_7 : Form
    {
        private List<string> nombres = new List<string> { };
        private int limit = 100;
        private int counter = 0;

        public F_4_1_3_7()
        {
            InitializeComponent();
        }

        private void tb_nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (counter == 0)
                Limpiarlista();

            if ((int)e.KeyCode == (int)Keys.Enter)
            {
                // Eliminar beep
                e.SuppressKeyPress = true;

                if (counter < limit -1 && tb_nombre.Text.Length > 0)
                {
                    SumarAlista();
                }
                else
                {
                    SumarAlista();
                    MostrarLista();
                }
            }

        }

        // Lista

        private void MostrarLista()
        {
            int count = nombres.Count();
            for (int i = 0; i < count; i++)
            {
                listb_nombres.Items.Add(nombres[i]);
            }
            counter = 0;
        }

        private void SumarAlista()
        {
            nombres.Add(tb_nombre.Text);
            tb_nombre.Text = null;
            counter++;
        }

        private void Limpiarlista()
        {
            int count = nombres.Count();
            for (int i = 0; i < count; i++)
            {
                listb_nombres.Items.Remove(nombres[i]);
            }
            nombres = new List<string> { };
        }

        // Botones

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            Limpiarlista();
            counter = 0;
        }
    }
}
