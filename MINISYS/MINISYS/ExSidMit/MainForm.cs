using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExSidMit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void GoToLogin_Click(object sender, EventArgs e)
        {
            Login_Page sForm = new Login_Page();
            sForm.Show();
            this.Hide();
        }

        private void GoToRegister_Click(object sender, EventArgs e)
        {
            Register_Page sForm = new Register_Page();
            sForm.Show();
            this.Hide();
        }
    }
}
