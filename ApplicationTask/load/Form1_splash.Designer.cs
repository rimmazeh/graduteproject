namespace TaskSystem.ApplicationTask.load
{
    partial class Form1_splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_splash));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MyTaskLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyTaskLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MyTaskLogo
            // 
            this.MyTaskLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MyTaskLogo.Image = ((System.Drawing.Image)(resources.GetObject("MyTaskLogo.Image")));
            this.MyTaskLogo.Location = new System.Drawing.Point(359, 227);
            this.MyTaskLogo.Name = "MyTaskLogo";
            this.MyTaskLogo.Size = new System.Drawing.Size(402, 302);
            this.MyTaskLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyTaskLogo.TabIndex = 18;
            this.MyTaskLogo.TabStop = false;
            // 
            // Form1_splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1164, 661);
            this.ControlBox = false;
            this.Controls.Add(this.MyTaskLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1_splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyTaskLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MyTaskLogo;
        private System.Windows.Forms.Timer timer1;
    }
}