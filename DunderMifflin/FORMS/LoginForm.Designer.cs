namespace $safeprojectname$.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.loginUsername_txt = new System.Windows.Forms.TextBox();
            this.loginPassword_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login_login_btn = new System.Windows.Forms.Button();
            this.cBox_login_showHide = new System.Windows.Forms.CheckBox();
            this.login_forgotPassword_btn = new System.Windows.Forms.Button();
            this.login_exit_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(41, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // loginUsername_txt
            // 
            this.loginUsername_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginUsername_txt.Location = new System.Drawing.Point(145, 140);
            this.loginUsername_txt.Name = "loginUsername_txt";
            this.loginUsername_txt.Size = new System.Drawing.Size(194, 26);
            this.loginUsername_txt.TabIndex = 1;
            // 
            // loginPassword_txt
            // 
            this.loginPassword_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginPassword_txt.Location = new System.Drawing.Point(145, 188);
            this.loginPassword_txt.Name = "loginPassword_txt";
            this.loginPassword_txt.PasswordChar = '*';
            this.loginPassword_txt.Size = new System.Drawing.Size(194, 26);
            this.loginPassword_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(41, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // login_login_btn
            // 
            this.login_login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login_login_btn.Location = new System.Drawing.Point(145, 265);
            this.login_login_btn.Name = "login_login_btn";
            this.login_login_btn.Size = new System.Drawing.Size(94, 37);
            this.login_login_btn.TabIndex = 4;
            this.login_login_btn.Text = "Log In";
            this.login_login_btn.UseVisualStyleBackColor = true;
            this.login_login_btn.Click += new System.EventHandler(this.login_login_btn_Click);
            // 
            // cBox_login_showHide
            // 
            this.cBox_login_showHide.AutoSize = true;
            this.cBox_login_showHide.Location = new System.Drawing.Point(145, 227);
            this.cBox_login_showHide.Name = "cBox_login_showHide";
            this.cBox_login_showHide.Size = new System.Drawing.Size(86, 17);
            this.cBox_login_showHide.TabIndex = 5;
            this.cBox_login_showHide.Text = "Show / Hide";
            this.cBox_login_showHide.UseVisualStyleBackColor = true;
            this.cBox_login_showHide.CheckedChanged += new System.EventHandler(this.cBox_login_showHide_CheckedChanged);
            // 
            // login_forgotPassword_btn
            // 
            this.login_forgotPassword_btn.Location = new System.Drawing.Point(237, 222);
            this.login_forgotPassword_btn.Name = "login_forgotPassword_btn";
            this.login_forgotPassword_btn.Size = new System.Drawing.Size(102, 24);
            this.login_forgotPassword_btn.TabIndex = 6;
            this.login_forgotPassword_btn.Text = "Forgot Password?";
            this.login_forgotPassword_btn.UseVisualStyleBackColor = true;
            this.login_forgotPassword_btn.Click += new System.EventHandler(this.login_forgotPassword_btn_Click);
            // 
            // login_exit_btn
            // 
            this.login_exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login_exit_btn.Location = new System.Drawing.Point(12, 329);
            this.login_exit_btn.Name = "login_exit_btn";
            this.login_exit_btn.Size = new System.Drawing.Size(94, 37);
            this.login_exit_btn.TabIndex = 7;
            this.login_exit_btn.Text = "Exit";
            this.login_exit_btn.UseVisualStyleBackColor = true;
            this.login_exit_btn.Click += new System.EventHandler(this.login_exit_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-22, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 91);
            this.panel1.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.login_login_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 382);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.login_exit_btn);
            this.Controls.Add(this.login_forgotPassword_btn);
            this.Controls.Add(this.cBox_login_showHide);
            this.Controls.Add(this.login_login_btn);
            this.Controls.Add(this.loginPassword_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginUsername_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginUsername_txt;
        private System.Windows.Forms.TextBox loginPassword_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_login_btn;
        private System.Windows.Forms.CheckBox cBox_login_showHide;
        private System.Windows.Forms.Button login_forgotPassword_btn;
        private System.Windows.Forms.Button login_exit_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}