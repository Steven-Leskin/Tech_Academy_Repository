using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class loginFRM : Form
    {
        public loginFRM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logInBTN_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-TNA7LG7\SQLEXPRESS;Initial Catalog=userLogin;Integrated Security=True");
            string query = "Select * from loginTBL where username = '" + userNameTB.Text.Trim() + "'and password='" + passWordTB.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                LogIn login = new LogIn();
                //this.Hide();
                login.Show();
            }

            else
            {
                MessageBox.Show("Please check your username and password.");
            }
        }

        private void longOutBTN_Click(object sender, EventArgs e)
        {
            LogOut logout = new LogOut();
            userNameTB.Text = (" ");
            passWordTB.Clear();
            logout.Show();
        }

        private void passWordTB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("U/N: AjaB P/W: LG2023 \n U/N: LuciG LG  P/W: 2021 \n U/N: JordanV P/W: LG2024 \n U/N: AaronR P/W: 2025");
        }
    }

    //private void logOutBTN_Click(object sender, EventArgs e)
  
  
}
