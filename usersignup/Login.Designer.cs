namespace usersignup
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkshow = new System.Windows.Forms.CheckBox();
            this.btnfpass = new System.Windows.Forms.Button();
            this.txtreveal = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.btnsignup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.loginuser = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkshow);
            this.groupBox1.Controls.Add(this.btnfpass);
            this.groupBox1.Controls.Add(this.txtreveal);
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Controls.Add(this.btnsignup);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.loginuser);
            this.groupBox1.Controls.Add(this.textpassword);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(22, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // chkshow
            // 
            this.chkshow.AutoSize = true;
            this.chkshow.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkshow.Location = new System.Drawing.Point(104, 107);
            this.chkshow.Name = "chkshow";
            this.chkshow.Size = new System.Drawing.Size(56, 20);
            this.chkshow.TabIndex = 5;
            this.chkshow.Text = "Show";
            this.chkshow.UseVisualStyleBackColor = true;
            this.chkshow.CheckedChanged += new System.EventHandler(this.chkshow_CheckedChanged);
            // 
            // btnfpass
            // 
            this.btnfpass.Location = new System.Drawing.Point(24, 186);
            this.btnfpass.Name = "btnfpass";
            this.btnfpass.Size = new System.Drawing.Size(132, 23);
            this.btnfpass.TabIndex = 4;
            this.btnfpass.Text = "Forgot Password";
            this.btnfpass.UseVisualStyleBackColor = true;
            this.btnfpass.Click += new System.EventHandler(this.btnfpass_Click);
            // 
            // txtreveal
            // 
            this.txtreveal.Location = new System.Drawing.Point(162, 186);
            this.txtreveal.Name = "txtreveal";
            this.txtreveal.Size = new System.Drawing.Size(170, 24);
            this.txtreveal.TabIndex = 3;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(196, 131);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnsignup
            // 
            this.btnsignup.Location = new System.Drawing.Point(24, 131);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(75, 23);
            this.btnsignup.TabIndex = 2;
            this.btnsignup.Text = "Sign Up";
            this.btnsignup.UseVisualStyleBackColor = true;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // loginuser
            // 
            this.loginuser.AutoSize = true;
            this.loginuser.Location = new System.Drawing.Point(24, 47);
            this.loginuser.Name = "loginuser";
            this.loginuser.Size = new System.Drawing.Size(74, 17);
            this.loginuser.TabIndex = 1;
            this.loginuser.Text = "User Name";
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(104, 77);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(167, 24);
            this.textpassword.TabIndex = 0;
            this.textpassword.UseSystemPasswordChar = true;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(104, 44);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(167, 24);
            this.txtusername.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(414, 328);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnLogin;
        private Button btnsignup;
        private Label label2;
        private Label loginuser;
        private TextBox textpassword;
        private TextBox txtusername;
        private Button btnfpass;
        private TextBox txtreveal;
        private CheckBox chkshow;
    }
}