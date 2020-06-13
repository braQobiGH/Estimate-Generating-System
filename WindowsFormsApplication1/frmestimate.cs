using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using exportWord = Microsoft.Office.Interop.Word;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;



namespace WindowsFormsApplication1
{
    public partial class frmestimate : Form
    {
        public frmestimate()
        {
            InitializeComponent();
            var custName = txtcustomer.Text;
        }
       
        private void estimate_Load(object sender, EventArgs e)
        {
            helper obj = new helper();
            obj.getStocks(stocksDGV);
            obj.getEstimates(dataGridView3);
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
       

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtName.Text = stocksDGV.CurrentRow.Cells[0].Value.ToString();
            txtUnitPrice.Text = stocksDGV.CurrentRow.Cells[2].Value.ToString();

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                txtUnitPrice.Text = stocksDGV.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                txtUnitPrice.Text = stocksDGV.CurrentRow.Cells[2].Value.ToString();
            }

        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            decimal unitPrice = Convert.ToDecimal(txtUnitPrice.Text);


            txtTotal.Text = (unitPrice * txtQuantity.Value).ToString();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                helper obj = new helper();
                double unitP = Convert.ToDouble(txtUnitPrice.Text);
                double totalP = Convert.ToDouble(txtTotal.Text);


                obj.insertEstimate(txtQuantity, txtName.Text, unitP, totalP, txtcustomer.Text);
                obj.getEstimates(dataGridView1, txtcustomer);
                obj.insertCustomers(txtcustomer.Text, txtcontact.Text, txtAddress.Text);
                obj.getEstimates(dataGridView3);

                checkBox3.Checked =false;



                cal(dataGridView1, txtEtotal, txtWrkmanship, txtNtotal);


                txtName.ResetText();
                txtQuantity.ResetText();
                txtTotal.ResetText();
                txtUnitPrice.ResetText();
            }

            catch
            {
                MessageBox.Show("please check the input well");
            }
        }
        public void genReport(object crpt)
        {

        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtWrkmanship.Value = 0;
            txtNtotal.Text = "";
            helper obj = new helper();
            string cName = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            obj.getclientEstimate(dataGridView1, cName);
            obj.getClientInfo(txtcustomer, txtcontact, txtAddress, cName);
            cal(dataGridView1, txtEtotal, txtWrkmanship, txtNtotal);
            obj.getsavedEstimate(txtWrkmanship, txtNtotal, cName);


        }
        private void cal(DataGridView dgv, TextBox grossTotal, NumericUpDown workmanship, TextBox netTotal)
        {
            double sum = 0;
            for (int i = 0; i < dgv.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dgv.Rows[i].Cells[3].Value);
            }

            grossTotal.Text = sum.ToString();
        }

        private void txtWrkmanship_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double workmanship = Convert.ToDouble(txtWrkmanship.Text);
                double gross = Convert.ToDouble(txtEtotal.Text);
                double netTotal = workmanship + gross;

                txtNtotal.Text = netTotal.ToString();
            }
            catch
            {

            }

        }

        private void txtWrkmanship_ValueChanged(object sender, EventArgs e)
        {
            double workmanship = Convert.ToDouble(txtWrkmanship.Value);
            double gross = Convert.ToDouble(txtEtotal.Text);
            double netTotal = workmanship + gross;

            txtNtotal.Text = netTotal.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            helper obj = new helper();
            if (txtWrkmanship.Value == 0)
            {
                return;
            }
            else
            {
                double wk = Convert.ToDouble(txtWrkmanship.Value);
                double np = Convert.ToDouble(txtNtotal.Text);
                obj.saveEstimate(txtcustomer.Text, wk, np);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //exportWord.Application wordapp = new exportWord.Application();
            //wordapp.Visible = true;
            //exportWord.Document worddoc;
            //object wordobj = System.Reflection.Missing.Value;
            //worddoc = wordapp.Documents.Add(ref wordobj);
            //wordapp.Selection.TypeText(txtNtotal.Text);
            //wordapp.Selection.TypeText(txtcustomer.Text);
            //wordapp = null;

            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }




        //exporting to word
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.doc)|*.doc";

            sfd.FileName = "export.doc";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                //ToCsV(dataGridView1, @"c:\export.xls");

                ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name 

            }
        }
        public static string sendtext = "";
        public static string contact = "";
        public static string address = "";
        public static string total = "";
        public static decimal workmanship = 0;
        public static string  grandtotal = "";
        private void button2_Click(object sender, EventArgs e)
        {
            Odmus.crystalReport.estimate1 crp = new Odmus.crystalReport.estimate1();
            TextObject custName = (TextObject)crp.ReportDefinition.Sections["Section2"].ReportObjects["txtClientname"];
           
            report obj = new report();
            custName.Text = txtcustomer.Text;
          
            sendtext = txtcustomer.Text;
            contact = txtcontact.Text;
            address = txtAddress.Text;
            total = txtEtotal.Text;
            workmanship = txtWrkmanship.Value;
            grandtotal = txtNtotal.Text;


           
           
            obj.ShowDialog();
            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
          // txtQuantity.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[0].Value);
            txtUnitPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTotal.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            helper obj = new helper();
            if (txtQuantity.Value == 0)
            {
                MessageBox.Show("The Quantity is 0 please enter a valid Quantity");
                return;
            }
            else
            {
                string val = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string query = "UPDATE estimates SET Quantity='" + txtQuantity.Value + " ',Description='" + txtName.Text + " ',Unit_Price='" + txtUnitPrice.Text + " ',Total_Price='" + txtTotal.Text + " ' WHERE Description ='" + val + " ' AND Customer= '" + txtcustomer.Text + " ' ";
                obj.queryTaker(query);
                obj.getEstimates(dataGridView1, txtcustomer);
                cal(dataGridView1, txtEtotal, txtWrkmanship, txtNtotal);
            }
        }

        private void txtEtotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double workmanship = Convert.ToDouble(txtWrkmanship.Value);
                double gross = Convert.ToDouble(txtEtotal.Text);
                double netTotal = workmanship + gross;

                txtNtotal.Text = netTotal.ToString();
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("please double click on the product to display in the fields before trying to delete");
                return;
            }
            string query = "DELETE from estimates where Description = '" + txtName.Text + "' AND Customer = '" + txtcustomer.Text + "'";
            helper obj = new helper();
            obj.queryTaker(query);
            obj.getEstimates(dataGridView1, txtcustomer);
            txtName.ResetText();
            txtQuantity.ResetText();
            txtUnitPrice.ResetText();
            txtTotal.ResetText();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try { 
            if (txtcontact.Text == "")
            {
                MessageBox.Show("double click on the old estimate before you delete");
            }
            helper obj = new helper();
            string oldval = dataGridView3.CurrentRow.Cells[0].Value.ToString();
           string query = "delete from clients where Name= '" + oldval + "' AND contact = '" + txtcontact.Text + "' ";

      
            string query2 = "delete from estimates where Customer= '" + oldval + "' ";
            string query3 = "delete from estimatecost where Name= '" + oldval + "' ";
            obj.queryTaker(query);
            obj.queryTaker(query2);
            obj.queryTaker(query3);

            obj.getEstimates(dataGridView3);

            obj.getEstimates(dataGridView1, txtcustomer);
            txtcustomer.ResetText();
            txtcontact.ResetText();
            txtAddress.ResetText();
            txtNtotal.ResetText();
            txtEtotal.ResetText();
            txtWrkmanship.ResetText();
           
            MessageBox.Show("Operation Successful");

            }
            catch { }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                helper obj = new helper();
                string query = "UPDATE estimatecost set Workmanship='" + txtWrkmanship.Value + "',netPofit='" + txtNtotal.Text + "' where Name = '" + txtcustomer.Text + "' ";
                obj.queryTaker(query);
                obj.getEstimates(dataGridView1, txtcustomer);
                MessageBox.Show("Estimate has been updated successfully");
            }
            catch { }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            helper obj = new helper();
            obj.search(textBox4.Text, stocksDGV);
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}

