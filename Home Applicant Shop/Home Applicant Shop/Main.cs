using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Applicant_Shop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Add f1 = new Add();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            Show f2 = new Show();
            this.Hide();
            f2.ShowDialog();    
            this.Close();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            Report f3 = new Report();
            this.Hide();    
            f3.ShowDialog();
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
