using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EXSIDMIT
{
    public partial class registerpage : Form
    {
        string sex = "";
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-ESA53A6\\SQLEXPRESS;Initial Catalog=ExSidMit_DB;Integrated Security=True;Encrypt=False");
        public registerpage()
        {
            InitializeComponent();
        }
        private void BT_login_Click(object sender, EventArgs e)
        {
            form_login mForm = new form_login();
            mForm.Show();
            this.Hide();
        }
        private void BT_register_Click(object sender, EventArgs e)
        {
            if (TB_Username.Text == "" || TB_Password.Text == "" || sex == "" || TB_StudentID.Text == "" || TB_Course.Text == "" || TB_Yearlevel.Text == "" || TB_Age.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TB_Password.Text != TB_VerifyPW.Text)
            {
                MessageBox.Show("Password did not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM login_credentials WHERE username = '"
                            + TB_Username.Text.Trim() + "'"; // admin is our table name

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(TB_Username.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO login_credentials (student_id, username, userpassword, course, yearlevel, age, sex) " +
                                    "VALUES(@studentid, @username, @password, @course, @yearlevel, @age, @sex)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@studentid", TB_StudentID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", TB_Username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", TB_Password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@course", TB_Course.Text.Trim());
                                    cmd.Parameters.AddWithValue("@yearlevel", TB_Yearlevel.Text.Trim());
                                    cmd.Parameters.AddWithValue("@age", TB_Age.Text.Trim());
                                    cmd.Parameters.AddWithValue("@sex", sex.Trim());

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // TO SWITCH THE FORM 
                                    form_login lForm = new form_login();
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

        private void RB_Male_CheckedChanged(object sender, EventArgs e)
        {
            sex = "Male";
        }

        private void RB_Female_CheckedChanged(object sender, EventArgs e)
        {
            sex = "Female";
        }
    }
}
