namespace TaskSystem.ApplicationTask
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginBtn = new TaskSystem.RoundedButtom();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SignLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PassWordTxt = new System.Windows.Forms.TextBox();
            this.panelround1 = new TaskSystem.Panelrounder();
            this.mask = new System.Windows.Forms.PictureBox();
            this.passblue = new System.Windows.Forms.PictureBox();
            this.userblue = new System.Windows.Forms.PictureBox();
            this.passwordpic = new System.Windows.Forms.PictureBox();
            this.userpic = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelround1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passblue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userblue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.BackColor = System.Drawing.Color.Azure;
            this.UserNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserNameTxt.HideSelection = false;
            this.UserNameTxt.Location = new System.Drawing.Point(134, 249);
            this.UserNameTxt.Multiline = true;
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(177, 25);
            this.UserNameTxt.TabIndex = 1;
            this.UserNameTxt.TabStop = false;
            this.UserNameTxt.Text = "User name";
            this.UserNameTxt.Click += new System.EventHandler(this.UserNameTxt_Click);
            this.UserNameTxt.TextChanged += new System.EventHandler(this.UserNameTxt_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox1.Location = new System.Drawing.Point(100, 347);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 20);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Remember Me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(96, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 1);
            this.panel1.TabIndex = 11;
            this.panel1.Click += new System.EventHandler(this.UserNameTxt_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(158)))), ((int)(((byte)(187)))));
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(96, 436);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(260, 50);
            this.LoginBtn.TabIndex = 22;
            this.LoginBtn.Text = "Sign in";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.roundedButtom2_Click);
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.passwordlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordlbl.Location = new System.Drawing.Point(134, 306);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(80, 19);
            this.passwordlbl.TabIndex = 21;
            this.passwordlbl.Text = "Password";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(88, -14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(273, 200);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // SignLabel
            // 
            this.SignLabel.AutoSize = true;
            this.SignLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignLabel.Location = new System.Drawing.Point(179, 158);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(88, 28);
            this.SignLabel.TabIndex = 16;
            this.SignLabel.Text = "Sign In";
            this.SignLabel.Click += new System.EventHandler(this.SignLabel_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(96, 328);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(260, 1);
            this.panel5.TabIndex = 12;
            this.panel5.Click += new System.EventHandler(this.PassWordTxt_Click);
            // 
            // PassWordTxt
            // 
            this.PassWordTxt.BackColor = System.Drawing.Color.Azure;
            this.PassWordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassWordTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassWordTxt.HideSelection = false;
            this.PassWordTxt.Location = new System.Drawing.Point(153, 305);
            this.PassWordTxt.Name = "PassWordTxt";
            this.PassWordTxt.Size = new System.Drawing.Size(177, 20);
            this.PassWordTxt.TabIndex = 3;
            this.PassWordTxt.TabStop = false;
            this.PassWordTxt.Click += new System.EventHandler(this.PassWordTxt_Click);
            // 
            // panelround1
            // 
            this.panelround1.BackColor = System.Drawing.Color.Azure;
            this.panelround1.Controls.Add(this.mask);
            this.panelround1.Controls.Add(this.panel1);
            this.panelround1.Controls.Add(this.LoginBtn);
            this.panelround1.Controls.Add(this.passwordlbl);
            this.panelround1.Controls.Add(this.PassWordTxt);
            this.panelround1.Controls.Add(this.passblue);
            this.panelround1.Controls.Add(this.UserNameTxt);
            this.panelround1.Controls.Add(this.userblue);
            this.panelround1.Controls.Add(this.panel5);
            this.panelround1.Controls.Add(this.checkBox1);
            this.panelround1.Controls.Add(this.SignLabel);
            this.panelround1.Controls.Add(this.passwordpic);
            this.panelround1.Controls.Add(this.userpic);
            this.panelround1.Controls.Add(this.pictureBox4);
            this.panelround1.Location = new System.Drawing.Point(496, 63);
            this.panelround1.Name = "panelround1";
            this.panelround1.Size = new System.Drawing.Size(440, 579);
            this.panelround1.TabIndex = 15;
            // 
            // mask
            // 
            this.mask.Image = ((System.Drawing.Image)(resources.GetObject("mask.Image")));
            this.mask.Location = new System.Drawing.Point(336, 306);
            this.mask.Name = "mask";
            this.mask.Size = new System.Drawing.Size(20, 20);
            this.mask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mask.TabIndex = 18;
            this.mask.TabStop = false;
            this.mask.MouseLeave += new System.EventHandler(this.mask_MouseLeave);
            this.mask.MouseHover += new System.EventHandler(this.mask_MouseHover);
            // 
            // passblue
            // 
            this.passblue.Image = ((System.Drawing.Image)(resources.GetObject("passblue.Image")));
            this.passblue.Location = new System.Drawing.Point(96, 294);
            this.passblue.Name = "passblue";
            this.passblue.Size = new System.Drawing.Size(32, 32);
            this.passblue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.passblue.TabIndex = 20;
            this.passblue.TabStop = false;
            this.passblue.Visible = false;
            // 
            // userblue
            // 
            this.userblue.Image = ((System.Drawing.Image)(resources.GetObject("userblue.Image")));
            this.userblue.Location = new System.Drawing.Point(96, 242);
            this.userblue.Name = "userblue";
            this.userblue.Size = new System.Drawing.Size(32, 32);
            this.userblue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userblue.TabIndex = 19;
            this.userblue.TabStop = false;
            this.userblue.Visible = false;
            // 
            // passwordpic
            // 
            this.passwordpic.Image = ((System.Drawing.Image)(resources.GetObject("passwordpic.Image")));
            this.passwordpic.Location = new System.Drawing.Point(96, 294);
            this.passwordpic.Name = "passwordpic";
            this.passwordpic.Size = new System.Drawing.Size(32, 32);
            this.passwordpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.passwordpic.TabIndex = 9;
            this.passwordpic.TabStop = false;
            // 
            // userpic
            // 
            this.userpic.Image = ((System.Drawing.Image)(resources.GetObject("userpic.Image")));
            this.userpic.Location = new System.Drawing.Point(96, 242);
            this.userpic.Name = "userpic";
            this.userpic.Size = new System.Drawing.Size(32, 32);
            this.userpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userpic.TabIndex = 10;
            this.userpic.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1310, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Login_Form
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelround1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelround1.ResumeLayout(false);
            this.panelround1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passblue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userblue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox PassWordTxt;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label SignLabel;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Panel panel5;
        private RoundedButtom LoginBtn;
        private System.Windows.Forms.Panel panel1;
        private Panelrounder panelround1;
        private System.Windows.Forms.PictureBox mask;
        private System.Windows.Forms.PictureBox passblue;
        private System.Windows.Forms.PictureBox userblue;
        private System.Windows.Forms.PictureBox passwordpic;
        private System.Windows.Forms.PictureBox userpic;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}