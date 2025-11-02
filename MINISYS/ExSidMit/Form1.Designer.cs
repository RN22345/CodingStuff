namespace ExSidMit
{
    partial class Form1
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
            button1 = new Button();
            signup_username = new TextBox();
            signup_password = new TextBox();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.ImageAlign = ContentAlignment.MiddleRight;
            title.Location = new Point(462, 9);
            title.Name = "title";
            title.Size = new Size(73, 15);
            title.TabIndex = 0;
            title.Text = "LOGIN PAGE";
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.Click += loginLabel;
            // 
            // button1
            // 
            button1.Location = new Point(451, 264);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // signup_username
            // 
            signup_username.Location = new Point(469, 100);
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(100, 23);
            signup_username.TabIndex = 2;
            // 
            // signup_password
            // 
            signup_password.Location = new Point(469, 139);
            signup_password.Name = "signup_password";
            signup_password.Size = new Size(100, 23);
            signup_password.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 474);
            Controls.Add(signup_password);
            Controls.Add(signup_username);
            Controls.Add(button1);
            Controls.Add(title);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Button button1;
        private TextBox signup_username;
        private TextBox signup_password;
    }
}
