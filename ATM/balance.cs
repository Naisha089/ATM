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
    public partial class balance : Form
    {
        public balance()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30");
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='"+AccNumbertbl.Text+"'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balance1bl.Text =  "Rs "+ dt.Rows[0][0].ToString();
            Con.Close();

        }
        private void balance_Load(object sender, EventArgs e)
        {
            AccNumbertbl.Text = home.AccNumber;
            getBalance();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            home home = new home();
            this.Hide();
            home.Show();
        }
    }
}
