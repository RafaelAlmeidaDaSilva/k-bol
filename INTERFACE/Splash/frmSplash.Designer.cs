namespace INTERFACE
{
    partial class frmSplash
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
            this.timerAbrirFormulario = new System.Windows.Forms.Timer(this.components);
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.pbSplash = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAbrirFormulario
            // 
            this.timerAbrirFormulario.Enabled = true;
            this.timerAbrirFormulario.Interval = 5000;
            this.timerAbrirFormulario.Tick += new System.EventHandler(this.timerAbrirFormulario_Tick);
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.Color.White;
            this.pbLoading.Image = global::INTERFACE.Properties.Resources.Loading2;
            this.pbLoading.Location = new System.Drawing.Point(369, 252);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(55, 65);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoading.TabIndex = 5;
            this.pbLoading.TabStop = false;
            this.pbLoading.Click += new System.EventHandler(this.pbLoading_Click);
            // 
            // pbSplash
            // 
            this.pbSplash.BackColor = System.Drawing.Color.Transparent;
            this.pbSplash.Image = global::INTERFACE.Properties.Resources.KBOL_SPLASH;
            this.pbSplash.Location = new System.Drawing.Point(196, 141);
            this.pbSplash.Name = "pbSplash";
            this.pbSplash.Size = new System.Drawing.Size(294, 279);
            this.pbSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSplash.TabIndex = 3;
            this.pbSplash.TabStop = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(716, 536);
            this.ControlBox = false;
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.pbSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.TransparencyKey = System.Drawing.Color.LightSteelBlue;
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSplash;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Timer timerAbrirFormulario;
    }
}