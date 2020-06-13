using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class staffs : Form
    {
        public staffs()
        {
            InitializeComponent();
        }

        private void GroupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.ShowDialog();
            Pbregis.Image = Image.FromFile(opf.FileName);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtmtown.Text == "" | txtAge.Text == "" | txtcontact.Text == "" | txtfcontact.Text == "" | txtfname.Text == "" | txtmcontact.Text == "" | txtmnane.Text == "" | txtName.Text == "")
            {
                MessageBox.Show("please fill all fields");
                return;
            }
            string gender;
            helper obj = new helper();
            if (rbfemale.Checked == true)
            {
                gender = rbfemale.Text;
            }
            else
            {
                gender = rbmale.Text;
            }
            obj.addStaffs(Pbregis, txtName.Text, txtcontact.Text, txtAge.Text, gender, txtfname.Text, txtfcontact.Text, txttown.Text, txtmnane.Text, txtmcontact.Text, txtmtown.Text);
            obj.getStaffs(DataGridView1);
        }

        private void staffs_Load(object sender, EventArgs e)
        {
            helper obj = new helper();
            rbmale.Checked = true;
            obj.getStaffs(DataGridView1);
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            DataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            DataGridView1.BackgroundColor = Color.White;

            DataGridView1.EnableHeadersVisualStyles = false;
            DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

          
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtmtown.Text = "";
            txtAge.Text ="";
            txtcontact.Text = "";
            txtfcontact.Text = ""; 
            txtfname.Text = "";
            txtmcontact.Text = ""; 
            txtmnane.Text = "";
            txtName.Text = "";
            Pbregis.Image = null;
            txttown.Text = "";

        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
              
              byte[] img = (byte[])DataGridView1.CurrentRow.Cells[0].Value;
            
         
         MemoryStream ms = new MemoryStream(img);

             Pbregis.Image = Image.FromStream(ms);
            txtName.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtcontact.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAge.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtfname.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtfcontact.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
            txttown.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtmnane.Text = DataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtmcontact.Text = DataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtmtown.Text = DataGridView1.CurrentRow.Cells[10].Value.ToString();
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("please double click on the staff before trying to delete");
                return;
            }
            string query = "delete from staff where Name = '" + txtName.Text + "' AND contact = '" + txtcontact.Text + "'";
            helper obj = new helper();
            obj.queryTaker(query);
            MessageBox.Show("staff deleted successfully");
            obj.getStaffs(DataGridView1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)

        {
            //convertiing image


            string Nname = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            helper obj = new helper();
            string query = "UPDATE staff SET Name='" + txtName.Text + " ',Contact='" + txtcontact.Text + " ',Age='" + txtAge.Text + " ',Fname='" + txtfname.Text + " ',Fcontact='" + txtfcontact.Text + " ',Ftown='" + txttown.Text + " ',Mname='" + txtmnane.Text + " ',Mcontact='" + txtmcontact.Text + " ',Mtown='" + txtmtown.Text + "',Image =@img  WHERE Name ='" + Nname + " '";
            obj.queryTaker2(query,Pbregis);
            MessageBox.Show("staff info has been updated successfully");
            obj.getStaffs(DataGridView1);

        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (char.IsDigit(e.KeyChar) == false &&  e.KeyChar != '/' && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
            }
        

        private void txtfcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '/' && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false &&  e.KeyChar != '/' && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

       
    }
}
