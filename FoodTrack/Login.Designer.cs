namespace FoodTrack
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbliRegister = new System.Windows.Forms.LinkLabel();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUname = new System.Windows.Forms.Label();
            this.lblLoginAcc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoodTrack.Properties.Resources.FoodTrack_Pic1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 117);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.btnExit.BackgroundImage = global::FoodTrack.Properties.Resources.Exit_2;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(924, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 54);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbliRegister
            // 
            this.lbliRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.lbliRegister.AutoSize = true;
            this.lbliRegister.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbliRegister.LinkColor = System.Drawing.Color.Black;
            this.lbliRegister.Location = new System.Drawing.Point(575, 499);
            this.lbliRegister.Name = "lbliRegister";
            this.lbliRegister.Size = new System.Drawing.Size(124, 24);
            this.lbliRegister.TabIndex = 33;
            this.lbliRegister.TabStop = true;
            this.lbliRegister.Text = "Register here";
            this.lbliRegister.VisitedLinkColor = System.Drawing.Color.Brown;
            this.lbliRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbliRegister_LinkClicked);
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoAccount.Location = new System.Drawing.Point(314, 499);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(255, 24);
            this.lblNoAccount.TabIndex = 32;
            this.lblNoAccount.Text = "Do not have an account yet?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(61)))), ((int)(((byte)(47)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Glacial Indifference", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(399, 430);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(179, 51);
            this.btnLogin.TabIndex = 31;
            this.btnLogin.Text = "LOG-IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Glacial Indifference", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(437, 360);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(240, 35);
            this.txtPassword.TabIndex = 30;
            // 
            // txtUname
            // 
            this.txtUname.Font = new System.Drawing.Font("Glacial Indifference", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUname.Location = new System.Drawing.Point(437, 310);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(240, 35);
            this.txtUname.TabIndex = 29;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Glacial Indifference", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(307, 367);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(123, 28);
            this.lblPassword.TabIndex = 28;
            this.lblPassword.Text = "Password:";
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Font = new System.Drawing.Font("Glacial Indifference", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUname.Location = new System.Drawing.Point(307, 317);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(127, 28);
            this.lblUname.TabIndex = 27;
            this.lblUname.Text = "Username:";
            // 
            // lblLoginAcc
            // 
            this.lblLoginAcc.AutoSize = true;
            this.lblLoginAcc.Font = new System.Drawing.Font("Glacial Indifference", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginAcc.Location = new System.Drawing.Point(314, 250);
            this.lblLoginAcc.Name = "lblLoginAcc";
            this.lblLoginAcc.Size = new System.Drawing.Size(356, 40);
            this.lblLoginAcc.TabIndex = 26;
            this.lblLoginAcc.Text = "Log-in to your account";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.lbliRegister);
            this.Controls.Add(this.lblNoAccount);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.lblLoginAcc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnExit;
        private LinkLabel lbliRegister;
        private Label lblNoAccount;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUname;
        private Label lblPassword;
        private Label lblUname;
        private Label lblLoginAcc;
    }
}