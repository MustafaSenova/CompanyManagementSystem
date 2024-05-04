namespace $safeprojectname$.Forms
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.forgot_exit_btn = new System.Windows.Forms.Button();
            this.forgot_change_password_btn = new System.Windows.Forms.Button();
            this.forgotPassword_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.forgotUsername_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.forgotSecurity_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // forgot_exit_btn
            // 
            this.forgot_exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.forgot_exit_btn.Location = new System.Drawing.Point(12, 377);
            this.forgot_exit_btn.Name = "forgot_exit_btn";
            this.forgot_exit_btn.Size = new System.Drawing.Size(94, 37);
            this.forgot_exit_btn.TabIndex = 15;
            this.forgot_exit_btn.Text = "Exit";
            this.forgot_exit_btn.UseVisualStyleBackColor = true;
            this.forgot_exit_btn.Click += new System.EventHandler(this.forgot_exit_btn_Click);
            // 
            // forgot_change_password_btn
            // 
            this.forgot_change_password_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.forgot_change_password_btn.Location = new System.Drawing.Point(169, 287);
            this.forgot_change_password_btn.Name = "forgot_change_password_btn";
            this.forgot_change_password_btn.Size = new System.Drawing.Size(148, 37);
            this.forgot_change_password_btn.TabIndex = 12;
            this.forgot_change_password_btn.Text = "Reset Password";
            this.forgot_change_password_btn.UseVisualStyleBackColor = true;
            this.forgot_change_password_btn.Click += new System.EventHandler(this.forgot_change_password_btn_Click);
            // 
            // forgotPassword_txt
            // 
            this.forgotPassword_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.forgotPassword_txt.Location = new System.Drawing.Point(169, 196);
            this.forgotPassword_txt.Name = "forgotPassword_txt";
            this.forgotPassword_txt.PasswordChar = '*';
            this.forgotPassword_txt.Size = new System.Drawing.Size(194, 26);
            this.forgotPassword_txt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(27, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "New Password:";
            // 
            // forgotUsername_txt
            // 
            this.forgotUsername_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.forgotUsername_txt.Location = new System.Drawing.Point(169, 148);
            this.forgotUsername_txt.Name = "forgotUsername_txt";
            this.forgotUsername_txt.Size = new System.Drawing.Size(194, 26);
            this.forgotUsername_txt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(27, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username:";
            // 
            // forgotSecurity_txt
            // 
            this.forgotSecurity_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.forgotSecurity_txt.Location = new System.Drawing.Point(169, 240);
            this.forgotSecurity_txt.Name = "forgotSecurity_txt";
            this.forgotSecurity_txt.Size = new System.Drawing.Size(194, 26);
            this.forgotSecurity_txt.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(27, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Security Question:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 91);
            this.panel1.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ForgotPassword
            // 
            this.AcceptButton = this.forgot_change_password_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 426);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.forgotSecurity_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.forgot_exit_btn);
            this.Controls.Add(this.forgot_change_password_btn);
            this.Controls.Add(this.forgotPassword_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.forgotUsername_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forgot_exit_btn;
        private System.Windows.Forms.Button forgot_change_password_btn;
        private System.Windows.Forms.TextBox forgotPassword_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox forgotUsername_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox forgotSecurity_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}