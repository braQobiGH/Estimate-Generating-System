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
    public partial class stocks : Form
    {
        public stocks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text == "choose category")
            {
                MessageBox.Show("please select item category");
                return;
            }else if(txtCategory.Text == "" | txtUnitPriceBox.Text == "" | txtUnitPricePiece.Text == ""){
                MessageBox.Show("please fill all fields");
                return;
            }
            helper obj = new helper();
         double amt1=   Convert.ToDouble(txtUnitPriceBox.Text);
         double amt2 = Convert.ToDouble(txtUnitPricePiece.Text);
            obj.insertStock(txtName.Text,txtCategory.Text,amt1, amt2);
            txtName.Clear();
           
            txtUnitPriceBox.ResetText();
            txtUnitPricePiece.ResetText();

            //getting stocks from the database
            obj.getStocks(dataGridView1);
        }

       

      
       

        private void stocks_Load_1(object sender, EventArgs e)
        {
            helper obj = new helper();
            obj.getStocks(dataGridView1);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
           // updating stocks in the database
            helper obj = new helper();
            string query = "UPDATE stocks SET Item_Name='" + txtName.Text + " ',unit_price_box='" + txtUnitPriceBox.Text + " ',unit_price_pieces='" + txtUnitPricePiece.Text + "' WHERE Item_Name ='" + txtName.Text + " ' ";
            obj.queryTaker(query);

          
            obj.getStocks(dataGridView1);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUnitPriceBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtUnitPricePiece.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUnitPriceBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtUnitPricePiece.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("please double click on the product to display in the fields before trying to delete");
                return;
            }
            string query = "DELETE FROM stocks where Item_Name = '" + txtName.Text+ "'";
            helper obj = new helper();
            obj.queryTaker(query);
            obj.getStocks(dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            helper obj = new helper();
            obj.search(textBox1.Text, dataGridView1);
        }

        private void txtUnitPricePiece_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
