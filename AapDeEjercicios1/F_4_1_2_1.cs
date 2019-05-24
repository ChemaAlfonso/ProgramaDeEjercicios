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
    public partial class F_4_1_2_1 : Form
    {
        

        public F_4_1_2_1()
        {
            InitializeComponent();
            setDiccionario();
        }        

        private void setDiccionario()
        {
            //Creación de nuevo diccionario
            Dictionary<string, int> meses = new Dictionary<string, int>();
            meses.Add("Enero", 31);
            meses.Add("Febrero", 28);
            meses.Add("Marzo", 31);
            meses.Add("Abril", 30);
            meses.Add("Mayo", 31);
            meses.Add("Junio", 30);
            meses.Add("Julio", 31);
            meses.Add("Agosto", 31);
            meses.Add("Septiembre", 30);
            meses.Add("Octubre", 31);
            meses.Add("Noviembre", 30);
            meses.Add("Diciembre", 31);

            // Bind datos combobox 
            cb_meses.DataSource = new BindingSource(meses, null);
            cb_meses.DisplayMember = "Key";
            cb_meses.ValueMember = "Value";

            // Seteo del primer dato por primera vez
            cb_meses.Text = "Enero";
            MostrarDias();
        }

        private void MostrarDias()
        {
           lb_dias.Text = cb_meses.Text + " Tiene " + cb_meses.SelectedValue.ToString() + " dias";
        }

        // Eventos

        private void cb_meses_SelectedIndexChanged(object sender, EventArgs e)
        {
           MostrarDias();
        }
    }
}