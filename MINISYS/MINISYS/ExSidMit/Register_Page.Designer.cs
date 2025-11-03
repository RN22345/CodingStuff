namespace ExSidMit
{
    partial class Register_Page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            title = new Label();
            Register_Button = new Button();
            signup_username = new TextBox();
            signup_password = new TextBox();
            GoToLogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.ImageAlign = ContentAlignment.MiddleRight;
            title.Location = new Point(353, 75);
            title.Name = "title";
            title.Size = new Size(117, 15);
            title.TabIndex = 0;
            title.Text = "REGISTRATION PAGE";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Register_Button
            // 
            Register_Button.Location = new Point(367, 275);
            Register_Button.Name = "Register_Button";
            Register_Button.Size = new Size(75, 23);
            Register_Button.TabIndex = 1;
            Register_Button.Text = "REGISTER";
            Register_Button.UseVisualStyleBackColor = true;
            Register_Button.Click += Register_Button_Click;
            // 
            // signup_username
            // 
            signup_username.Location = new Point(331, 109);
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(164, 23);
            signup_username.TabIndex = 2;
            // 
            // signup_password
            // 
            signup_password.Location = new Point(331, 163);
            signup_password.Name = "signup_password";
            signup_password.Size = new Size(164, 23);
            signup_password.TabIndex = 3;
            // 
            // GoToLogin
            // 
            GoToLogin.Location = new Point(367, 394);
            GoToLogin.Name = "GoToLogin";
            GoToLogin.Size = new Size(75, 23);
            GoToLogin.TabIndex = 5;
            GoToLogin.Text = "GoToLogin";
            GoToLogin.UseVisualStyleBackColor = true;
            GoToLogin.Click += GoToLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(353, 363);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 6;
            label1.Text = "GO TO LOGIN PAGE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Register_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 474);
            Controls.Add(label1);
            Controls.Add(GoToLogin);
            Controls.Add(signup_password);
            Controls.Add(signup_username);
            Controls.Add(Register_Button);
            Controls.Add(title);
            Name = "Register_Page";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Button Register_Button;
        private TextBox signup_username;
        private TextBox signup_password;
        private Button GoToLogin;
        private Label label1;
    }
}
