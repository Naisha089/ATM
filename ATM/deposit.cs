using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class deposit : Form
    {
        public deposit()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30");
        String Acc = Login.AccNumber;
        private void addtransaction()
        {
            string TrType = "Deposit";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values ('" + Acc + "','" + TrType + "','" + DepoAmtTb.Text + "','" + DateTime.Today.Date.ToString() + "')";
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
            if (DepoAmtTb.Text == " " || Convert.ToInt32(DepoAmtTb.Text) <= 0) 
            {
                MessageBox.Show("Enter to amount to deposit");
            }
            else
            {
                
                newbalance = oldbalance + Convert.ToInt32(DepoAmtTb.Text);
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


                }catch(Exception Ex)
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
        int oldbalance,newbalance;
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();

        }
        private void deposit_Load(object sender, EventArgs e)
        {
            getBalance();
        }
    }
}
