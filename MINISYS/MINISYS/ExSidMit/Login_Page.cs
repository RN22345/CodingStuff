using Microsoft.Data.SqlClient;
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
    public partial class Login_Page : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-ESA53A6\\SQLEXPRESS;Initial Catalog=ExSidMit_Database;Integrated Security=True;Encrypt=False;Trust Server Certificate=True;Encrypt=False");

        public Login_Page()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fil all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        String selectData = "SELECT * FROM exsidmit_logininfo WHERE Username = @username AND UserPassword = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text);
                            cmd.Parameters.AddWithValue("@pass", login_password.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainForm mForm = new MainForm();
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
        private void GoToRegister_Click(object sender, EventArgs e)
        {
            Register_Page sForm = new Register_Page();
            sForm.Show();
            this.Hide();
        }
    }
}
