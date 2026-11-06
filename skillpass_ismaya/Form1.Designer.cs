namespace skillpass_ismaya
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnKeluar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUser = new Label();
            lblPass = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnKeluar = new Button();
            SuspendLayout();

            // lblTitle
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(50, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 49);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "LOGIN APLIKASI DONASI";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblUser
            lblUser.Location = new Point(30, 236);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(100, 25);
            lblUser.TabIndex = 1;
            lblUser.Text = "Username";

            // lblPass
            lblPass.Location = new Point(30, 294);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(100, 25);
            lblPass.TabIndex = 3;
            lblPass.Text = "Password";

            // txtUsername
            txtUsername.Location = new Point(150, 230);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 31);
            txtUsername.TabIndex = 2;

            // txtPassword
            txtPassword.Location = new Point(150, 288);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 31);
            txtPassword.TabIndex = 4;

            // btnLogin
            btnLogin.BackColor = Color.LightGreen;
            btnLogin.Location = new Point(150, 340);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 35);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += new EventHandler(this.btnLogin_Click);   // ← WAJIB ADA

            // btnKeluar
            btnKeluar.BackColor = Color.LightCoral;
            btnKeluar.Location = new Point(246, 340);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(90, 35);
            btnKeluar.TabIndex = 6;
            btnKeluar.Text = "KELUAR";
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += new EventHandler(this.btnKeluar_Click);  // ← WAJIB ADA

            // Login
            ClientSize = new Size(420, 499);
            Controls.Add(lblTitle);
            Controls.Add(lblUser);
            Controls.Add(txtUsername);
            Controls.Add(lblPass);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnKeluar);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}