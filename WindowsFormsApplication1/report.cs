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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;



namespace WindowsFormsApplication1
{
    public partial class report : Form

    {
        SqlConnection con = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=odmusDB;Trusted_Connection=True");
        SqlCommand cmd;
        DataTable table;
        SqlDataAdapter da;
    
        public report()
        {
            InitializeComponent();
        }
       

        private void report_Load(object sender, EventArgs e)
        {

            try
            {

                Odmus.crystalReport.estimate1 crpt = new Odmus.crystalReport.estimate1();

                TextObject custName = (TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txtClientname"];
                TextObject custContact = (TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txtContact"];
                TextObject custAddress = (TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txtAddress"];
                TextObject custTotal = (TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txtcrTotal"];
                TextObject custwrk = (TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txtcrWorkmanship"];
                TextObject custGtotal = (TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["txtcrGrandtotal"];
                string customerName = frmestimate.sendtext;
               
                custName.Text = customerName;
                custContact.Text = frmestimate.contact;
                custAddress.Text = frmestimate.address;
                custTotal.Text = frmestimate.total;
                custwrk.Text = frmestimate.workmanship.ToString();
                custGtotal.Text = frmestimate.grandtotal;


              
                con.Open();
                string query = "select Quantity,Description,Unit_Price,Total_Price from estimates where Customer = '" + customerName + "'";
                cmd = new SqlCommand(query, con);

                DataSet ds = new DataSet();
                da = new SqlDataAdapter(cmd);


                table = new DataTable();
                da.Fill(ds, "estimates");
                crpt.SetDataSource(ds.Tables["estimates"]);
                con.Close();





                crpV.ReportSource = null;
                crpV.ReportSource = crpt;
                crpV.Refresh();

            }
            catch
            {
                MessageBox.Show("check if you have entered a valid name in the customer name field");
            }
           

        }
    }
}
