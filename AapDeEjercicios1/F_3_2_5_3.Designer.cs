namespace AapDeEjercicios1
{
    partial class F_3_2_5_3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ancho = new System.Windows.Forms.TextBox();
            this.tb_alto = new System.Windows.Forms.TextBox();
            this.lb_ancho = new System.Windows.Forms.Label();
            this.lb_alto = new System.Windows.Forms.Label();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.lb_perimetro = new System.Windows.Forms.Label();
            this.lb_area = new System.Windows.Forms.Label();
            this.lb_diagonal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_limpiar = new System.Windows.Forms.Button();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicio 3.2.5.3";
            // 
            // tb_ancho
            // 
            this.tb_ancho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ancho.Location = new System.Drawing.Point(122, 69);
            this.tb_ancho.Name = "tb_ancho";
            this.tb_ancho.Size = new System.Drawing.Size(164, 32);
            this.tb_ancho.TabIndex = 1;
            this.tb_ancho.Enter += new System.EventHandler(this.bt_calcular_Click);
            // 
            // tb_alto
            // 
            this.tb_alto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_alto.Location = new System.Drawing.Point(122, 120);
            this.tb_alto.Name = "tb_alto";
            this.tb_alto.Size = new System.Drawing.Size(164, 32);
            this.tb_alto.TabIndex = 2;
            this.tb_alto.Enter += new System.EventHandler(this.bt_calcular_Click);
            // 
            // lb_ancho
            // 
            this.lb_ancho.AutoSize = true;
            this.lb_ancho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ancho.Location = new System.Drawing.Point(30, 75);
            this.lb_ancho.Name = "lb_ancho";
            this.lb_ancho.Size = new System.Drawing.Size(74, 26);
            this.lb_ancho.TabIndex = 3;
            this.lb_ancho.Text = "Ancho";
            // 
            // lb_alto
            // 
            this.lb_alto.AutoSize = true;
            this.lb_alto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_alto.Location = new System.Drawing.Point(30, 126);
            this.lb_alto.Name = "lb_alto";
            this.lb_alto.Size = new System.Drawing.Size(50, 26);
            this.lb_alto.TabIndex = 4;
            this.lb_alto.Text = "Alto";
            // 
            // bt_calcular
            // 
            this.bt_calcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.bt_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calcular.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_calcular.Location = new System.Drawing.Point(107, 400);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(164, 38);
            this.bt_calcular.TabIndex = 5;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = false;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // lb_perimetro
            // 
            this.lb_perimetro.AutoSize = true;
            this.lb_perimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_perimetro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_perimetro.Location = new System.Drawing.Point(15, 124);
            this.lb_perimetro.Name = "lb_perimetro";
            this.lb_perimetro.Size = new System.Drawing.Size(123, 26);
            this.lb_perimetro.TabIndex = 6;
            this.lb_perimetro.Text = "Perímetro:";
            // 
            // lb_area
            // 
            this.lb_area.AutoSize = true;
            this.lb_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_area.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_area.Location = new System.Drawing.Point(67, 19);
            this.lb_area.Name = "lb_area";
            this.lb_area.Size = new System.Drawing.Size(69, 26);
            this.lb_area.TabIndex = 7;
            this.lb_area.Text = "Area:";
            // 
            // lb_diagonal
            // 
            this.lb_diagonal.AutoSize = true;
            this.lb_diagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diagonal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_diagonal.Location = new System.Drawing.Point(23, 69);
            this.lb_diagonal.Name = "lb_diagonal";
            this.lb_diagonal.Size = new System.Drawing.Size(113, 26);
            this.lb_diagonal.TabIndex = 8;
            this.lb_diagonal.Text = "Diagonal:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.lb_diagonal);
            this.panel1.Controls.Add(this.bt_calcular);
            this.panel1.Controls.Add(this.lb_area);
            this.panel1.Controls.Add(this.lb_perimetro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(517, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 450);
            this.panel1.TabIndex = 9;
            // 
            // bt_limpiar
            // 
            this.bt_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.bt_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_limpiar.Location = new System.Drawing.Point(122, 167);
            this.bt_limpiar.Name = "bt_limpiar";
            this.bt_limpiar.Size = new System.Drawing.Size(164, 38);
            this.bt_limpiar.TabIndex = 10;
            this.bt_limpiar.Text = "Limpiar";
            this.bt_limpiar.UseVisualStyleBackColor = false;
            this.bt_limpiar.Click += new System.EventHandler(this.bt_limpiar_Click);
            // 
            // tb_desc
            // 
            this.tb_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_desc.Enabled = false;
            this.tb_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_desc.Location = new System.Drawing.Point(12, 369);
            this.tb_desc.Multiline = true;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(454, 69);
            this.tb_desc.TabIndex = 11;
            this.tb_desc.Text = "Crear un  programa que calcule el perímero, area y diagonal\r\nde un rectangulo a p" +
    "artir de su ancho y su alto, muestra todos con cifra decimal.";
            // 
            // F_3_2_5_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.bt_limpiar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_alto);
            this.Controls.Add(this.lb_ancho);
            this.Controls.Add(this.tb_alto);
            this.Controls.Add(this.tb_ancho);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_3_2_5_3";
            this.Text = "F_3_2_5_3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ancho;
        private System.Windows.Forms.TextBox tb_alto;
        private System.Windows.Forms.Label lb_ancho;
        private System.Windows.Forms.Label lb_alto;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.Label lb_perimetro;
        private System.Windows.Forms.Label lb_area;
        private System.Windows.Forms.Label lb_diagonal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_limpiar;
        private System.Windows.Forms.TextBox tb_desc;
    }
}