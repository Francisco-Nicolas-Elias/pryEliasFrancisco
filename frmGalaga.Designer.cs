namespace pryEliasFrancisco
{
    partial class frmGalaga
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
            this.components = new System.ComponentModel.Container();
            this.pbNave = new System.Windows.Forms.PictureBox();
            this.pbEnemigo = new System.Windows.Forms.PictureBox();
            this.timerEnemigo = new System.Windows.Forms.Timer(this.components);
            this.timerMisil = new System.Windows.Forms.Timer(this.components);
            this.timerNave = new System.Windows.Forms.Timer(this.components);
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.pbEnemigoDos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemigoDos)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNave
            // 
            this.pbNave.BackColor = System.Drawing.Color.Transparent;
            this.pbNave.Image = global::pryEliasFrancisco.Properties.Resources.Nave2;
            this.pbNave.Location = new System.Drawing.Point(270, 544);
            this.pbNave.Name = "pbNave";
            this.pbNave.Size = new System.Drawing.Size(116, 105);
            this.pbNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNave.TabIndex = 0;
            this.pbNave.TabStop = false;
            // 
            // pbEnemigo
            // 
            this.pbEnemigo.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemigo.Image = global::pryEliasFrancisco.Properties.Resources.enemigo;
            this.pbEnemigo.Location = new System.Drawing.Point(270, 12);
            this.pbEnemigo.Name = "pbEnemigo";
            this.pbEnemigo.Size = new System.Drawing.Size(87, 75);
            this.pbEnemigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemigo.TabIndex = 1;
            this.pbEnemigo.TabStop = false;
            this.pbEnemigo.Tag = "Enemigo";
            // 
            // timerEnemigo
            // 
            this.timerEnemigo.Enabled = true;
            this.timerEnemigo.Tick += new System.EventHandler(this.timerEnemigo_Tick);
            // 
            // timerMisil
            // 
            this.timerMisil.Enabled = true;
            this.timerMisil.Tick += new System.EventHandler(this.timerMisil_Tick);
            // 
            // timerNave
            // 
            this.timerNave.Enabled = true;
            this.timerNave.Tick += new System.EventHandler(this.timerNave_Tick);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.ForeColor = System.Drawing.Color.Red;
            this.lblPuntaje.Location = new System.Drawing.Point(12, 22);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(103, 24);
            this.lblPuntaje.TabIndex = 2;
            this.lblPuntaje.Text = "Puntaje: 0";
            // 
            // pbEnemigoDos
            // 
            this.pbEnemigoDos.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemigoDos.Image = global::pryEliasFrancisco.Properties.Resources.enemigo;
            this.pbEnemigoDos.Location = new System.Drawing.Point(471, 107);
            this.pbEnemigoDos.Name = "pbEnemigoDos";
            this.pbEnemigoDos.Size = new System.Drawing.Size(87, 75);
            this.pbEnemigoDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemigoDos.TabIndex = 3;
            this.pbEnemigoDos.TabStop = false;
            this.pbEnemigoDos.Tag = "Enemigo";
            // 
            // frmGalaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryEliasFrancisco.Properties.Resources.espacio_exterior;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.pbEnemigoDos);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.pbEnemigo);
            this.Controls.Add(this.pbNave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGalaga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galaga";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGalaga_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGalaga_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemigoDos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNave;
        private System.Windows.Forms.PictureBox pbEnemigo;
        private System.Windows.Forms.Timer timerEnemigo;
        private System.Windows.Forms.Timer timerMisil;
        private System.Windows.Forms.Timer timerNave;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.PictureBox pbEnemigoDos;
    }
}