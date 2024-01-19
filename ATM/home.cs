using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        

        private void label5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            balance bal = new balance();
            this.Hide();
            bal.Show();
        }
        public static String AccNumber;
        private void home_Load(object sender, EventArgs e)
        {
            AccNum1bl.Text = "Account Number:" + Login.AccNumber;
            AccNumber = Login.AccNumber;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            deposit depo = new deposit();
            depo.Show();
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            withdraw wd = new withdraw();
            wd.Show();
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            fixcash fcash = new fixcash();
            fcash.Show();
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            statement mini = new statement();
            mini.Show();
            this.Hide();
        }
    }
}
