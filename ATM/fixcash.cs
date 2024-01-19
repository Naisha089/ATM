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
    public partial class fixcash : Form
    {
        public fixcash()
        {
            InitializeComponent();
        }

       

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (bal < 2000)
            {
                MessageBox.Show("Balanced can not be negative");
            }
            else
            {
                int newbalance = bal - 2000;
                try
                {

                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successful");
                    Con.Close();
                    addtransaction4();

                    home home = new home();
                    home.Show();
                    this.Hide();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        int bal;
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balance1tb.Text = "Rs " + dt.Rows[0][0].ToString();
           bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();

        }
        private void fixcash_Load(object sender, EventArgs e)
        {
            getBalance();
        }
       // int amt1 = 100, amt2 = 500, amt3 = 1000, amt4 = 2000, amt5 = 5000, amt6 = 10000;
        private void addtransaction1()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values ('" + Acc + "','" + TrType + "','" + 100 + "','" + DateTime.Today.Date.ToString() + "')";
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
        
        private void addtransaction2()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values ('" + Acc + "','" + TrType + "','" + 500 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction3()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values ('" + Acc + "','" + TrType + "','" + 1000 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction4()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values ('" + Acc + "','" + TrType + "','" + 2000 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction5()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values ('" + Acc + "','" + TrType + "','" + 5000 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction6()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values ('" + Acc + "','" + TrType + "','" + 10000 + "','" + DateTime.Today.Date.ToString() + "')";
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (bal < 100)
            {
                MessageBox.Show("Balanced can not be negative");
            }
            else
            {
                int newbalance = bal - 100;
                try
                {

                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successful");
                    Con.Close();
                    addtransaction1();
                    home home = new home();
                    home.Show();
                    this.Hide();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show("Balanced can not be negative");
            }
            else
            {
                int newbalance = bal - 500;
                try
                {

                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successful");
                    Con.Close();
                    addtransaction2();

                    home home = new home();
                    home.Show();
                    this.Hide();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("Balanced can not be negative");
            }
            else
            {
                int newbalance = bal - 1000;
                try
                {

                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successful");
                    Con.Close();
                    addtransaction3();
                    home home = new home();
                    home.Show();
                    this.Hide();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show("Balanced can not be negative");
            }
            else
            {
                int newbalance = bal - 5000;
                try
                {

                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successful");
                    Con.Close();
                    addtransaction5();

                    home home = new home();
                    home.Show();
                    this.Hide();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            if (bal < 10000)
            {
                MessageBox.Show("Balanced can not be negative");
            }
            else
            {
                int newbalance = bal - 10000;
                try
                {

                    Con.Open();
                    string query = "update AccountTbl set Balance=" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successful");
                    Con.Close();
                    addtransaction6();

                    home home = new home();
                    home.Show();
                    this.Hide();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
