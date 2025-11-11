using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXSIDMIT
{
    public partial class form_login : Form 
    {
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-ESA53A6\\SQLEXPRESS;Initial Catalog=ExSidMit_DB;Integrated Security=True;Encrypt=False");
        public form_login()
        {
            InitializeComponent();
        }

        private void BT_login_Click(object sender, EventArgs e)
        {
            if (TB_Username.Text == "" || TB_Password.Text == "")
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

                        String selectData = "SELECT * FROM login_credentials WHERE username = @username AND userpassword = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", TB_Username.Text);
                            cmd.Parameters.AddWithValue("@pass", TB_Password.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                mainform mForm = new mainform();
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

        private void BT_register_Click(object sender, EventArgs e)
        {
            registerpage mForm = new registerpage();
            mForm.Show();
            this.Hide();
        }
    }
}
