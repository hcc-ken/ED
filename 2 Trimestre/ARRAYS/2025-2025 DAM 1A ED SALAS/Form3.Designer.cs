namespace _2025_2025_DAM_1A_ED_SALAS
{
    partial class Form3
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
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblButacas = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblTotales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSala
            // 
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(335, 56);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(259, 21);
            this.cbSala.TabIndex = 0;
            this.cbSala.SelectedIndexChanged += new System.EventHandler(this.cbSala_SelectedIndexChanged);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(97, 117);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(118, 45);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = "VENDER ENTRADA";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(474, 117);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(131, 45);
            this.btnVaciar.TabIndex = 2;
            this.btnVaciar.Text = "VACIAR SALA";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(111, 59);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(57, 13);
            this.lblSala.TabIndex = 3;
            this.lblSala.Text = "Elige Sala:";
            // 
            // lblButacas
            // 
            this.lblButacas.AutoSize = true;
            this.lblButacas.Location = new System.Drawing.Point(111, 178);
            this.lblButacas.Name = "lblButacas";
            this.lblButacas.Size = new System.Drawing.Size(80, 13);
            this.lblButacas.TabIndex = 4;
            this.lblButacas.Text = "Butacas Libres:";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(491, 178);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(74, 13);
            this.lblIngresos.TabIndex = 5;
            this.lblIngresos.Text = "Ingresos Sala:";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(111, 231);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(116, 13);
            this.lblPorcentaje.TabIndex = 6;
            this.lblPorcentaje.Text = "Porcentaje Ocupacion:";
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.Location = new System.Drawing.Point(491, 231);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(88, 13);
            this.lblTotales.TabIndex = 7;
            this.lblTotales.Text = "Ingresos Totales:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 279);
            this.Controls.Add(this.lblTotales);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.lblButacas);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.cbSala);
            this.Name = "Form3";
            this.Text = "x`";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblButacas;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblTotales;
    }
}