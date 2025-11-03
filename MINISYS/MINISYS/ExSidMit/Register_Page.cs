using Microsoft.Data.SqlClient;
using System.Data;

namespace ExSidMit
{
    public partial class Register_Page : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-ESA53A6\\SQLEXPRESS;Initial Catalog=ExSidMit_Database;Integrated Security=True;Encrypt=False;Trust Server Certificate=True;Encrypt=False");
        public Register_Page()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            if (signup_username.Text == "" || signup_username.Text == ""
               || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM exsidmit_logininfo WHERE Username = '"
                            + signup_username.Text.Trim() + "'"; // admin is our table name

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_username.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO exsidmit_logininfo (UserName, UserPassword) " +
                                    "VALUES(@username, @pass)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // TO SWITCH THE FORM 
                                    Register_Page lForm = new Register_Page();
                                    lForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void GoToLogin_Click(object sender, EventArgs e)
        {
            Login_Page sForm = new Login_Page();
            sForm.Show();
            this.Hide();
        }
    }
}

    

