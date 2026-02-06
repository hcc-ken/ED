namespace _2025_2025_DAM_1A_ED_SALAS
{
    partial class Form1
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
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnTerminado = new System.Windows.Forms.Button();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblAforo = new System.Windows.Forms.Label();
            this.lblOcupadas = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.nudAforo = new System.Windows.Forms.NumericUpDown();
            this.nudOcupadas = new System.Windows.Forms.NumericUpDown();
            this.gbOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAforo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcupadas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.nudAforo);
            this.gbOpciones.Controls.Add(this.nudOcupadas);
            this.gbOpciones.Controls.Add(this.rb8);
            this.gbOpciones.Controls.Add(this.rb6);
            this.gbOpciones.Controls.Add(this.rb5);
            this.gbOpciones.Controls.Add(this.txtPelicula);
            this.gbOpciones.Controls.Add(this.lblEntrada);
            this.gbOpciones.Controls.Add(this.lblPelicula);
            this.gbOpciones.Controls.Add(this.lblOcupadas);
            this.gbOpciones.Controls.Add(this.lblAforo);
            this.gbOpciones.Location = new System.Drawing.Point(121, 140);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(510, 215);
            this.gbOpciones.TabIndex = 0;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "OPCIONES";
            // 
            // btnTerminado
            // 
            this.btnTerminado.Location = new System.Drawing.Point(210, 379);
            this.btnTerminado.Name = "btnTerminado";
            this.btnTerminado.Size = new System.Drawing.Size(302, 23);
            this.btnTerminado.TabIndex = 1;
            this.btnTerminado.Text = "TERMINADO";
            this.btnTerminado.UseVisualStyleBackColor = true;
            this.btnTerminado.Click += new System.EventHandler(this.btnTerminado_Click);
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(99, 46);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(31, 13);
            this.lblSala.TabIndex = 2;
            this.lblSala.Text = "Sala:";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(25, 45);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(47, 13);
            this.lblPelicula.TabIndex = 3;
            this.lblPelicula.Text = "Pelicula:";
            // 
            // lblAforo
            // 
            this.lblAforo.AutoSize = true;
            this.lblAforo.Location = new System.Drawing.Point(25, 95);
            this.lblAforo.Name = "lblAforo";
            this.lblAforo.Size = new System.Drawing.Size(35, 13);
            this.lblAforo.TabIndex = 4;
            this.lblAforo.Text = "Aforo:";
            // 
            // lblOcupadas
            // 
            this.lblOcupadas.AutoSize = true;
            this.lblOcupadas.Location = new System.Drawing.Point(25, 145);
            this.lblOcupadas.Name = "lblOcupadas";
            this.lblOcupadas.Size = new System.Drawing.Size(59, 13);
            this.lblOcupadas.TabIndex = 5;
            this.lblOcupadas.Text = "Ocupadas:";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(318, 95);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(47, 13);
            this.lblEntrada.TabIndex = 6;
            this.lblEntrada.Text = "Entrada:";
            // 
            // cbSala
            // 
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(210, 43);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(440, 21);
            this.cbSala.TabIndex = 3;
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(106, 42);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(327, 20);
            this.txtPelicula.TabIndex = 7;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(386, 95);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(40, 17);
            this.rb5.TabIndex = 10;
            this.rb5.TabStop = true;
            this.rb5.Text = "5 €";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Location = new System.Drawing.Point(386, 129);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(49, 17);
            this.rb6.TabIndex = 11;
            this.rb6.TabStop = true;
            this.rb6.Text = "6.5 €";
            this.rb6.UseVisualStyleBackColor = true;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Location = new System.Drawing.Point(386, 163);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(40, 17);
            this.rb8.TabIndex = 12;
            this.rb8.TabStop = true;
            this.rb8.Text = "8 €";
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // nudAforo
            // 
            this.nudAforo.Location = new System.Drawing.Point(122, 92);
            this.nudAforo.Name = "nudAforo";
            this.nudAforo.Size = new System.Drawing.Size(120, 20);
            this.nudAforo.TabIndex = 4;
            this.nudAforo.Tag = "";
            // 
            // nudOcupadas
            // 
            this.nudOcupadas.Location = new System.Drawing.Point(122, 145);
            this.nudOcupadas.Name = "nudOcupadas";
            this.nudOcupadas.Size = new System.Drawing.Size(120, 20);
            this.nudOcupadas.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.btnTerminado);
            this.Controls.Add(this.gbOpciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAforo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcupadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.Label lblOcupadas;
        private System.Windows.Forms.Label lblAforo;
        private System.Windows.Forms.Button btnTerminado;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.NumericUpDown nudAforo;
        private System.Windows.Forms.NumericUpDown nudOcupadas;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.TextBox txtPelicula;
    }
}

