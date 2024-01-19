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

namespace ATM
{
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30");

       
       

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNumtb.Text == "" || AccNametb.Text == "" || FaNametb.Text == "" || phonetb.Text == ""  | addresstb.Text== "" || occupationtb.Text=="" || pintb.Text =="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into AccountTbl values ('" + AccNumtb.Text + "','" + AccNametb.Text + "','" + FaNametb.Text + "','" + dobdatetb.Value.Date + "','" + phonetb.Text + "','" + addresstb.Text + "','" + educationtb.SelectedItem.ToString() + "','" + occupationtb.Text+"' ,'" + pintb.Text + "'," + bal + ")";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Succesfully");
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }


                      


        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
