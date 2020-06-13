using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnDatabaseConfig_Click(object sender, EventArgs e)
        {
            Odmus.account obj = new Odmus.account();
            obj.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnStocksReport_Click(object sender, EventArgs e)
        {
            stocks obj = new stocks();
            obj.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            frmestimate obj = new frmestimate();
            obj.ShowDialog();

        }

      

        private void btnPOS_Click(object sender, EventArgs e)
        {
            staffs obj = new staffs();
            obj.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Odmus.flashscreen obj = new Odmus.flashscreen();
            obj.Show();
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
