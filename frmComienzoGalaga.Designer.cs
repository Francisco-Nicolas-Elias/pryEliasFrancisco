namespace pryEliasFrancisco
{
    partial class frmComienzoGalaga
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
            this.lblNombreJugador = new System.Windows.Forms.Label();
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.lblGalaga = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreJugador
            // 
            this.lblNombreJugador.AutoSize = true;
            this.lblNombreJugador.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreJugador.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNombreJugador.Location = new System.Drawing.Point(141, 199);
            this.lblNombreJugador.Name = "lblNombreJugador";
            this.lblNombreJugador.Size = new System.Drawing.Size(215, 31);
            this.lblNombreJugador.TabIndex = 0;
            this.lblNombreJugador.Text = "Nombre jugador:";
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtNombreJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreJugador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombreJugador.Location = new System.Drawing.Point(350, 199);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.Size = new System.Drawing.Size(152, 31);
            this.txtNombreJugador.TabIndex = 1;
            this.txtNombreJugador.TextChanged += new System.EventHandler(this.txtNombreJugador_TextChanged);
            // 
            // lblGalaga
            // 
            this.lblGalaga.AutoSize = true;
            this.lblGalaga.BackColor = System.Drawing.Color.Transparent;
            this.lblGalaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalaga.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblGalaga.Location = new System.Drawing.Point(206, 73);
            this.lblGalaga.Name = "lblGalaga";
            this.lblGalaga.Size = new System.Drawing.Size(240, 73);
            this.lblGalaga.TabIndex = 2;
            this.lblGalaga.Text = "Galaga";
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnComenzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComenzar.Enabled = false;
            this.btnComenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnComenzar.Location = new System.Drawing.Point(147, 258);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(355, 62);
            this.btnComenzar.TabIndex = 3;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnVolver.Location = new System.Drawing.Point(147, 326);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(355, 62);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmComienzoGalaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryEliasFrancisco.Properties.Resources.espacio_exterior;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 622);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.lblGalaga);
            this.Controls.Add(this.txtNombreJugador);
            this.Controls.Add(this.lblNombreJugador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmComienzoGalaga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galaga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreJugador;
        private System.Windows.Forms.TextBox txtNombreJugador;
        private System.Windows.Forms.Label lblGalaga;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Button btnVolver;
    }
}