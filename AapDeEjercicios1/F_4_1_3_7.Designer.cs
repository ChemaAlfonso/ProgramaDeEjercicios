namespace AapDeEjercicios1
{
    partial class F_4_1_3_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_4_1_3_7));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listb_nombres = new System.Windows.Forms.ListBox();
            this.lb_nombres = new System.Windows.Forms.Label();
            this.bt_limpiar = new System.Windows.Forms.Button();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
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
            this.label1.TabIndex = 4;
            this.label1.Text = "Ejercicio 4.1.3.7";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.listb_nombres);
            this.panel1.Controls.Add(this.lb_nombres);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(517, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 450);
            this.panel1.TabIndex = 10;
            // 
            // listb_nombres
            // 
            this.listb_nombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.listb_nombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listb_nombres.Dock = System.Windows.Forms.DockStyle.Right;
            this.listb_nombres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listb_nombres.FormattingEnabled = true;
            this.listb_nombres.Location = new System.Drawing.Point(127, 0);
            this.listb_nombres.Name = "listb_nombres";
            this.listb_nombres.Size = new System.Drawing.Size(156, 450);
            this.listb_nombres.TabIndex = 8;
            // 
            // lb_nombres
            // 
            this.lb_nombres.AutoSize = true;
            this.lb_nombres.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_nombres.Location = new System.Drawing.Point(0, 0);
            this.lb_nombres.Name = "lb_nombres";
            this.lb_nombres.Size = new System.Drawing.Size(108, 26);
            this.lb_nombres.TabIndex = 7;
            this.lb_nombres.Text = "Nombres";
            // 
            // bt_limpiar
            // 
            this.bt_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.bt_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_limpiar.Location = new System.Drawing.Point(143, 118);
            this.bt_limpiar.Name = "bt_limpiar";
            this.bt_limpiar.Size = new System.Drawing.Size(164, 38);
            this.bt_limpiar.TabIndex = 37;
            this.bt_limpiar.Text = "Limpiar";
            this.bt_limpiar.UseVisualStyleBackColor = false;
            this.bt_limpiar.Click += new System.EventHandler(this.bt_limpiar_Click);
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre.Location = new System.Drawing.Point(29, 72);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(90, 26);
            this.lb_nombre.TabIndex = 36;
            this.lb_nombre.Text = "Nombre";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombre.Location = new System.Drawing.Point(143, 69);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(164, 32);
            this.tb_nombre.TabIndex = 35;
            this.tb_nombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_nombre_KeyDown);
            // 
            // tb_desc
            // 
            this.tb_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_desc.Enabled = false;
            this.tb_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_desc.Location = new System.Drawing.Point(12, 329);
            this.tb_desc.Multiline = true;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(445, 109);
            this.tb_desc.TabIndex = 0;
            this.tb_desc.Text = resources.GetString("tb_desc.Text");
            // 
            // F_4_1_3_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.bt_limpiar);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_4_1_3_7";
            this.Text = "F_4_1_3_7";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_nombres;
        private System.Windows.Forms.Button bt_limpiar;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.ListBox listb_nombres;
        private System.Windows.Forms.TextBox tb_desc;
    }
}