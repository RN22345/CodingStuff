namespace ExSidMit
{
    partial class Login_Page
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
            label1 = new Label();
            GoToLogin = new Button();
            login_password = new TextBox();
            login_username = new TextBox();
            Login_Button = new Button();
            title = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(307, 338);
            label1.Name = "label1";
            label1.Size = new Size(175, 15);
            label1.TabIndex = 12;
            label1.Text = "NO ACCOUNT? REGISTER NOW";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GoToLogin
            // 
            GoToLogin.Location = new Point(344, 371);
            GoToLogin.Name = "GoToLogin";
            GoToLogin.Size = new Size(95, 23);
            GoToLogin.TabIndex = 11;
            GoToLogin.Text = "Register Page";
            GoToLogin.UseVisualStyleBackColor = true;
            GoToLogin.Click += GoToRegister_Click;
            // 
            // login_password
            // 
            login_password.Location = new Point(318, 142);
            login_password.Name = "login_password";
            login_password.Size = new Size(164, 23);
            login_password.TabIndex = 10;
            // 
            // login_username
            // 
            login_username.Location = new Point(318, 88);
            login_username.Name = "login_username";
            login_username.Size = new Size(164, 23);
            login_username.TabIndex = 9;
            // 
            // Login_Button
            // 
            Login_Button.Location = new Point(354, 254);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(75, 23);
            Login_Button.TabIndex = 8;
            Login_Button.Text = "LOGIN";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += Login_Button_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.ImageAlign = ContentAlignment.MiddleRight;
            title.Location = new Point(356, 57);
            title.Name = "title";
            title.Size = new Size(73, 15);
            title.TabIndex = 7;
            title.Text = "LOGIN PAGE";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(GoToLogin);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(Login_Button);
            Controls.Add(title);
            Name = "Login_Page";
            Text = "LOGIN PAGE";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button GoToLogin;
        private TextBox login_password;
        private TextBox login_username;
        private Button Login_Button;
        private Label title;
    }
}