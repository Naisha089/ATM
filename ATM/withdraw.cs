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

namespace ATM
{
    public partial class withdraw : Form
    {
        public withdraw()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30");
        int newbalance;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (wdamtTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (Convert.ToInt32(wdamtTb.Text) <= 0)
            {
                MessageBox.Show("Enter valid Amount");
            }  else if (Convert.ToInt32(wdamtTb.Text) > bal)
            {
                MessageBox.Show("Balance Can not be Negative");
            }
            else
            {
                try
                {
                    newbalance = bal - Convert.ToInt32(wdamtTb.Text);
                    try
                    {

                        Con.Open();
                        string query = "update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("successful");
                        Con.Close();
                        addtransaction();
                        home home = new home();
                        home.Show();
                        this.Hide();


                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }


        }
        string Acc= Login.AccNumber;
        int bal;
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balance1lb.Text = " Balance Rs " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();

        }
        private void addtransaction()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values ('" + Acc + "','" + TrType + "','" + wdamtTb.Text + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Account Created Succesfully");
                Con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }

        }
        private void withdraw_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }
    }
}
