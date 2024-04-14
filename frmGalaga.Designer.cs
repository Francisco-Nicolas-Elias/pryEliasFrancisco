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
            this.pbNave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNave)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNave
            // 
            this.pbNave.Image = global::pryEliasFrancisco.Properties.Resources.nave;
            this.pbNave.Location = new System.Drawing.Point(299, 585);
            this.pbNave.Name = "pbNave";
            this.pbNave.Size = new System.Drawing.Size(73, 64);
            this.pbNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNave.TabIndex = 0;
            this.pbNave.TabStop = false;
            // 
            // frmGalaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryEliasFrancisco.Properties.Resources.espacio_exterior;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.pbNave);
            this.Name = "frmGalaga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galaga";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGalaga_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbNave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNave;
    }
}