using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string street = streetTB.Text;
            string city = cityTB.Text;
            string state = stateTB.Text;
            string zipCode = zipTB.Text;

            try
            {
                StringBuilder querydata = new StringBuilder();
                querydata.Append("http://maps.google.com/maps?q=");

                if (street != string.Empty)
                    querydata.Append(street + "," + "+");

                if (city != string.Empty)
                    querydata.Append(city + "," + "+");

                if (state != string.Empty)
                    querydata.Append(state + "," + "+");

                if (zipCode != string.Empty)
                    querydata.Append(zipCode + "," + "+");

                webBrowser1.Navigate(querydata.ToString());

            }

            catch (Exception exc)

            {
                MessageBox.Show(exc.Message.ToString(), "ERROR");

            }





        }
    }
}
