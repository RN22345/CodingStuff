namespace ExSidMit
{
    partial class MainForm
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
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 145);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 0;
            label1.Text = "Place Holder Form Tee Hee";
            label1.Click += GoToLogin_Click;
            // 
            // GoToLogin
            // 
            GoToLogin.Location = new Point(245, 253);
            GoToLogin.Name = "GoToLogin";
            GoToLogin.Size = new Size(75, 23);
            GoToLogin.TabIndex = 12;
            GoToLogin.Text = "Login Page";
            GoToLogin.UseVisualStyleBackColor = true;
            GoToLogin.Click += GoToLogin_Click;
            // 
            // button1
            // 
            button1.Location = new Point(452, 253);
            button1.Name = "button1";
            button1.Size = new Size(95, 23);
            button1.TabIndex = 13;
            button1.Text = "Register Page";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GoToRegister_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(GoToLogin);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button GoToLogin;
        private Button button1;
    }
}