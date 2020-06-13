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


namespace Odmus
{
    public partial class account : Form
    {
        SqlConnection con = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=odmusDB;Trusted_Connection=True");
        SqlCommand cmd;
        DataTable table;
        SqlDataAdapter da;
        
        
      
        public account()
        {
            InitializeComponent();
        }
        
        private void account_Load(object sender, EventArgs e)
        {
           
          
            getAccount(DataGridView5, DataGridView2);
            cal(DataGridView5, textBox1);
            cal(DataGridView2, textBox2);
            double val1 = Convert.ToDouble(textBox1.Text);
            double val2 = Convert.ToDouble(textBox2.Text);
            double sum = val1 - val2;
            textBox3.Text = sum.ToString();
            DataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            DataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            DataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            DataGridView2.BackgroundColor = Color.White;

            DataGridView2.EnableHeadersVisualStyles = false;
            DataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            DataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            DataGridView5.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            DataGridView5.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView5.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            DataGridView5.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            DataGridView5.BackgroundColor = Color.White;

            DataGridView5.EnableHeadersVisualStyles = false;
            DataGridView5.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView5.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            DataGridView5.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        

        }



        /////////////////////////////////////
        public void insertAccount(string detail, double amount, string type)
        {
            con.Open();
            string query = "INSERT INTO accounts(Detail,Type,Amount) VALUES(@detail,@type,@amount)";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@detail", detail);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@amount", amount);
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("Record was inserted successfully");

                con.Close();
            }
            con.Close();
        }

        //getting the amount fron the account detail

        public void getAccount(DataGridView dgv1, DataGridView dgv2)
        {
            try
            {
                con.Open();
                string Income = "Income";
                string Expenses = "Expenses";
                string query = "select * from accounts where Type = '" + Income + "'";
                string query2 = "select * from accounts where Type = '" + Expenses + "'";
                cmd = new SqlCommand(query, con);
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable table2 = new DataTable();
                da2.Fill(table2);
                da = new SqlDataAdapter(cmd);
                table = new DataTable();

                da.Fill(table);

                dgv1.DataSource = table;
                dgv2.DataSource = table2;
                con.Close();
            }
            catch
            {
                MessageBox.Show("the database is not ready click on it again");
                return;
               
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (ComboBox4.Text == "Transaction Type" | TextBox6.Text == "" | TextBox5.Text == "")
            {
                MessageBox.Show("please enter all fields");
                return;
            }
            double amt = Convert.ToDouble(TextBox5.Text);
            insertAccount(TextBox6.Text, amt, ComboBox4.Text);
            getAccount(DataGridView5, DataGridView2);
            cal(DataGridView5, textBox1);
            cal(DataGridView2, textBox2);
            double val1 = Convert.ToDouble(textBox1.Text);
            double val2 = Convert.ToDouble(textBox2.Text);
            double sum = val1 - val2;
            textBox3.Text = sum.ToString();
            TextBox5.ResetText();
            TextBox6.ResetText();
        }

        //calculations
        private void cal(DataGridView dgv, TextBox income)
        {
            double sum = 0;
            for (int i = 0; i < dgv.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dgv.Rows[i].Cells[2].Value);
            }

            income.Text = sum.ToString();
        }

        private void cal2(DataGridView dgv, TextBox expenses)
        {
            double sum = 0;
            for (int i = 0; i < dgv.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dgv.Rows[i].Cells[2].Value);
            }

            expenses.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string val2 = DataGridView2.CurrentRow.Cells[0].Value.ToString();
            string query = "DELETE from accounts where Detail = '" + val2 + "' AND Type = 'Expenses'";
              con.Open();
            cmd = new SqlCommand(query, con);
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
             
                MessageBox.Show("Entry has been deleted successfully");

                con.Close();
            }
            con.Close();
            getAccount(DataGridView5, DataGridView2);
            cal(DataGridView5, textBox1);
            cal(DataGridView2, textBox2);
            double val1 = Convert.ToDouble(textBox1.Text);
            double val3 = Convert.ToDouble(textBox2.Text);
            double sum = val1 - val3;
            textBox3.Text = sum.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string val1 = DataGridView5.CurrentRow.Cells[0].Value.ToString();
            string query = "DELETE from accounts where Detail = '" + val1 + "' AND Type = 'Income'";
            con.Open();
            cmd = new SqlCommand(query, con);
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {

                MessageBox.Show("Entry has been deleted successfully");

                con.Close();
            }
            con.Close();
            getAccount(DataGridView5, DataGridView2);
            cal(DataGridView5, textBox1);
            cal(DataGridView2, textBox2);
            double val3 = Convert.ToDouble(textBox1.Text);
            double val2 = Convert.ToDouble(textBox2.Text);
            double sum = val3 - val2;
            textBox3.Text = sum.ToString();
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
        }

    }

