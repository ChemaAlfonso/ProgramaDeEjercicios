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
    public partial class F_3_4_2 : Form
    {
        private string usuario;
        private string clave1;
        private string clave2;
        private int counter = 0;
        private int limit   = 2;

        public F_3_4_2()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_usuario.Text.Length == 0 || tb_contrasenia.Text.Length == 0)
                {
                    MessageBox.Show("Rellene todos los campos");
                    return;
                }

                if (lb_resultText.Visible)
                {
                    lb_resultText.Visible = false;
                    lb_clave2Result.Text = "Clave 2:";
                }

                usuario = tb_usuario.Text;

                if (counter == 0)
                {
                    guardarPrimeraClave();

                    lb_usuarioResult.Text = "Usuario:" + usuario;
                    lb_clave1Result.Text  = "Clave 1:" + clave1;

                    lb_resultText.ForeColor = System.Drawing.Color.YellowGreen;
                    lb_resultText.Text = "Repita la clave";
                    lb_resultText.Visible = true;

                    tb_contrasenia.Text = null;

                    counter++;
                }
                else
                {
                    clave2 = tb_contrasenia.Text;

                    lb_clave2Result.Text = "Clave 2:" + clave2;
                    lb_resultText.Visible = true;

                    if (validarClaves())
                    {
                        lb_resultText.Text = "La clave coincide!!";
                        lb_resultText.ForeColor = System.Drawing.Color.Green;
                        tb_contrasenia.Text = null;
                        counter = 0;
                    }
                    else
                    {
                        lb_resultText.Text = "La clave no coincide!";
                        lb_resultText.ForeColor = System.Drawing.Color.Red;
                        lb_clave1Result.Text = "Clave 1:";
                        lb_clave2Result.Text = "Clave 2:";
                        tb_contrasenia.Text = null;
                        counter = 0;
                    }
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void guardarPrimeraClave()
        {
            clave1 = tb_contrasenia.Text;
        }

        private Boolean validarClaves()
        {
            if (clave1 == clave2)
            {
                return true;
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void LimpiarDatos()
        {
            tb_contrasenia.Text = null;
            tb_usuario.Text = null;
            lb_usuarioResult.Text = "Usuario:";
            lb_clave1Result.Text = "Clave 1:";
            lb_clave2Result.Text = "Clave 2:";
            lb_resultText.Visible = false;
        }
    }
}
