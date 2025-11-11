namespace EXSIDMIT
{
    partial class registerpage
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
            this.username = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_VerifyPW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_login = new System.Windows.Forms.Button();
            this.BT_register = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_StudentID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Age = new System.Windows.Forms.TextBox();
            this.TB_Yearlevel = new System.Windows.Forms.TextBox();
            this.TB_Course = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RB_Male = new System.Windows.Forms.RadioButton();
            this.GB_Sex = new System.Windows.Forms.GroupBox();
            this.RB_Female = new System.Windows.Forms.RadioButton();
            this.GB_Sex.SuspendLayout();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(109, 175);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(129, 28);
            this.username.TabIndex = 0;
            this.username.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Re-enter PW:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password:";
            // 
            // TB_Username
            // 
            this.TB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Username.Location = new System.Drawing.Point(269, 171);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(315, 35);
            this.TB_Username.TabIndex = 8;
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(269, 233);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(315, 35);
            this.TB_Password.TabIndex = 9;
            // 
            // TB_VerifyPW
            // 
            this.TB_VerifyPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_VerifyPW.Location = new System.Drawing.Point(269, 298);
            this.TB_VerifyPW.Name = "TB_VerifyPW";
            this.TB_VerifyPW.Size = new System.Drawing.Size(315, 35);
            this.TB_VerifyPW.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(547, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 47);
            this.label1.TabIndex = 11;
            this.label1.Text = "ExSidMiT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Register Page";
            // 
            // BT_login
            // 
            this.BT_login.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_login.Location = new System.Drawing.Point(579, 601);
            this.BT_login.Name = "BT_login";
            this.BT_login.Size = new System.Drawing.Size(131, 48);
            this.BT_login.TabIndex = 13;
            this.BT_login.Text = "LOGIN";
            this.BT_login.UseVisualStyleBackColor = true;
            this.BT_login.Click += new System.EventHandler(this.BT_login_Click);
            // 
            // BT_register
            // 
            this.BT_register.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_register.Location = new System.Drawing.Point(579, 469);
            this.BT_register.Name = "BT_register";
            this.BT_register.Size = new System.Drawing.Size(131, 48);
            this.BT_register.TabIndex = 14;
            this.BT_register.Text = "REGISTER";
            this.BT_register.UseVisualStyleBackColor = true;
            this.BT_register.Click += new System.EventHandler(this.BT_register_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 556);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Already Registered?";
            // 
            // TB_StudentID
            // 
            this.TB_StudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_StudentID.Location = new System.Drawing.Point(269, 362);
            this.TB_StudentID.Name = "TB_StudentID";
            this.TB_StudentID.Size = new System.Drawing.Size(315, 35);
            this.TB_StudentID.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Student ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(737, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 28);
            this.label7.TabIndex = 24;
            this.label7.Text = "Age:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TB_Age
            // 
            this.TB_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Age.Location = new System.Drawing.Point(832, 295);
            this.TB_Age.Name = "TB_Age";
            this.TB_Age.Size = new System.Drawing.Size(315, 35);
            this.TB_Age.TabIndex = 23;
            // 
            // TB_Yearlevel
            // 
            this.TB_Yearlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Yearlevel.Location = new System.Drawing.Point(832, 230);
            this.TB_Yearlevel.Name = "TB_Yearlevel";
            this.TB_Yearlevel.Size = new System.Drawing.Size(315, 35);
            this.TB_Yearlevel.TabIndex = 22;
            // 
            // TB_Course
            // 
            this.TB_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Course.Location = new System.Drawing.Point(832, 168);
            this.TB_Course.Name = "TB_Course";
            this.TB_Course.Size = new System.Drawing.Size(315, 35);
            this.TB_Course.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(646, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Year Level:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(620, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "Sex at Birth:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(698, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 28);
            this.label10.TabIndex = 18;
            this.label10.Text = "Course:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RB_Male
            // 
            this.RB_Male.AutoSize = true;
            this.RB_Male.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Male.Location = new System.Drawing.Point(50, 29);
            this.RB_Male.Name = "RB_Male";
            this.RB_Male.Size = new System.Drawing.Size(68, 26);
            this.RB_Male.TabIndex = 25;
            this.RB_Male.TabStop = true;
            this.RB_Male.Text = "Male";
            this.RB_Male.UseVisualStyleBackColor = true;
            this.RB_Male.CheckedChanged += new System.EventHandler(this.RB_Male_CheckedChanged);
            // 
            // GB_Sex
            // 
            this.GB_Sex.Controls.Add(this.RB_Female);
            this.GB_Sex.Controls.Add(this.RB_Male);
            this.GB_Sex.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Sex.Location = new System.Drawing.Point(832, 362);
            this.GB_Sex.Name = "GB_Sex";
            this.GB_Sex.Size = new System.Drawing.Size(315, 74);
            this.GB_Sex.TabIndex = 26;
            this.GB_Sex.TabStop = false;
            // 
            // RB_Female
            // 
            this.RB_Female.AutoSize = true;
            this.RB_Female.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Female.Location = new System.Drawing.Point(183, 29);
            this.RB_Female.Name = "RB_Female";
            this.RB_Female.Size = new System.Drawing.Size(88, 26);
            this.RB_Female.TabIndex = 26;
            this.RB_Female.TabStop = true;
            this.RB_Female.Text = "Female";
            this.RB_Female.UseVisualStyleBackColor = true;
            this.RB_Female.CheckedChanged += new System.EventHandler(this.RB_Female_CheckedChanged);
            // 
            // registerpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.GB_Sex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_Age);
            this.Controls.Add(this.TB_Yearlevel);
            this.Controls.Add(this.TB_Course);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TB_StudentID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BT_register);
            this.Controls.Add(this.BT_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_VerifyPW);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.username);
            this.MaximizeBox = false;
            this.Name = "registerpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExSidMiT (Register)";
            this.GB_Sex.ResumeLayout(false);
            this.GB_Sex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label username;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox TB_Username;
    private System.Windows.Forms.TextBox TB_Password;
    private System.Windows.Forms.TextBox TB_VerifyPW;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button BT_login;
    private System.Windows.Forms.Button BT_register;
    private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_StudentID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Age;
        private System.Windows.Forms.TextBox TB_Yearlevel;
        private System.Windows.Forms.TextBox TB_Course;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton RB_Male;
        private System.Windows.Forms.GroupBox GB_Sex;
        private System.Windows.Forms.RadioButton RB_Female;
    }
}