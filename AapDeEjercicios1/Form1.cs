using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AapDeEjercicios1
{
    public partial class F_principal : Form
    {    
        private Form ultimoEjercicio;

        public F_principal()
        {
            InitializeComponent();
            ultimoEjercicio = null;
            AbrirEjercicio(new F_intro());
        }

        // Arrastrar ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // Llamadas a ejercicios
        private void AbrirEjercicio(object ejercicio)
        {
            /*
            if (this.panel_contenedor.Controls.Count < 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            */
            if (ultimoEjercicio != null)
                ultimoEjercicio.Close();

            Form ejerc = ejercicio as Form;
            ejerc.TopLevel = false;
            ejerc.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(ejerc);
            this.panel_contenedor.Tag = ejerc;
            ultimoEjercicio = ejerc;
            ejerc.Show();
        }

        // Close, max, min, arrastrar
        private void pb_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pb_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pb_resize.Visible = true;
            pb_max.Visible = false;
        }

        private void pb_resize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pb_max.Visible = true;
            pb_resize.Visible = false;
        }

        private void pb_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_superior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }


        // Botones ejercicios
        private void bt_3_2_5_3_Click(object sender, EventArgs e)
        {
            AbrirEjercicio(new F_3_2_5_3());
        }

        private void bt_3_2_5_4_Click(object sender, EventArgs e)
        {
            AbrirEjercicio(new F_3_2_5_4());
        }

        private void bt_3_2_6_2_Click(object sender, EventArgs e)
        {
           AbrirEjercicio(new F_3_2_6_2());
        }

        private void bt_3_3_2_1_Click(object sender, EventArgs e)
        {
           AbrirEjercicio(new F_3_3_2_1());
        }

        private void bt_4_1_1_2_Click(object sender, EventArgs e)
        {
           AbrirEjercicio(new F_4_1_1_2());
        }

        private void bt_4_1_2_1_Click(object sender, EventArgs e)
        {
           AbrirEjercicio(new F_4_1_2_1());
        }

        private void bt_4_1_3_7_Click(object sender, EventArgs e)
        {
           AbrirEjercicio(new F_4_1_3_7());
        }

        private void bt_4_1_3_8_Click(object sender, EventArgs e)
        {
           AbrirEjercicio(new F_4_1_3_8());
        }

        private void bt_3_4_2_Click(object sender, EventArgs e)
        {
           AbrirEjercicio(new F_3_4_2());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           AbrirEjercicio(new F_intro());
        }

        private void bt_inicio_Click(object sender, EventArgs e)
        {
           AbrirEjercicio(new F_intro());
        }
    }
}
