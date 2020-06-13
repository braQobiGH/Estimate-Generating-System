using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Windows.Forms;
using System.IO;




namespace WindowsFormsApplication1
{
    class helper
    {
        SqlConnection con = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=odmusDB;Trusted_Connection=True");
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\braQobi\Desktop\Odmus\WindowsFormsApplication1\OdmusDb.mdf;Integrated Security=True");

        SqlCommand cmd;
        DataTable table;
        SqlDataAdapter da;
        SqlDataReader dr;
        

        public void insertStock(string name, string category, double box, double pieces)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO stocks(Item_Name,category,unit_price_box,unit_price_pieces) VALUES(@item,@category,@box,@pieces)";
                cmd = new SqlCommand(query,con);
                cmd.Parameters.AddWithValue("@item", name);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@box", box);
                cmd.Parameters.AddWithValue("@pieces", pieces);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {

                    MessageBox.Show("stock has been added successfully");
                    con.Close();
                }


            }
            catch
            {
                MessageBox.Show("An error has occured");
                con.Close();
            }
            finally
            {
                con.Close();
            }
        }

        public void getStocks(DataGridView dgv)
        {
            try
            {
                con.Open();
                string query = "select * from stocks";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                table = new DataTable();
                da.Fill(table);
                dgv.DataSource = table;

                con.Close();

            }

            catch
            {
                MessageBox.Show("An error occurred");

            }
        }  
        

        //inserting estimate into the database

        public void insertEstimate(NumericUpDown quantity, string name, double unitP, double totalP,string customer)
        {
            try
            {
                if (customer == "")
                {
                    MessageBox.Show("Please fill client Information before generating estimate");
                    return;
                }
                con.Open();
               
                string query1 = "select Description from estimates where Customer = '" + customer + "' AND Description='"+ name +"'";
                cmd = new SqlCommand(query1, con);
            
                dr = cmd.ExecuteReader();
              
                if (dr.Read())
                {
                    MessageBox.Show("this item have been added already click on it to edit");
                    dr.Close();
                    return;
                }
                else
                {
                    dr.Close();
                    string query = "INSERT INTO estimates(Quantity,Description,Unit_Price,Total_Price,Customer) VALUES(@Qty,@Desc,@unitP,@totalP,@customer)";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Qty", quantity.Value);
                    cmd.Parameters.AddWithValue("@Desc", name);
                    cmd.Parameters.AddWithValue("@unitP", unitP);
                    cmd.Parameters.AddWithValue("@totalP", totalP);
                    cmd.Parameters.AddWithValue("@customer", customer);
                    int row2 = cmd.ExecuteNonQuery();
                    if (row2 > 0)
                    {


                        con.Close();
                    }
                }

            }
            catch 
            {
                MessageBox.Show("An error has occured");
                con.Close();
            }
            finally
            {
                con.Close();
            }
        }

        //getting estimate from database
        public void getEstimates(DataGridView dgv, TextBox customer)
        {
            try
            {
                con.Open();
                string query = "select Quantity,Description,Unit_Price,Total_Price from estimates where Customer = '" + customer.Text + "'";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                table = new DataTable();
                da.Fill(table);
                dgv.DataSource = table;

                con.Close();


            }
            catch
            {
                MessageBox.Show("An error occurred ");
                return;
            }
        }

        //inserting customers into the database
        public void insertCustomers(string name,string contact, string address)
        {
            if (name == "")
            {
                return;
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO clients(Name,contact,Address) VALUES(@name,@contact,@address)";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@address", address);

                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {

                      
                        con.Close();
                    }
                }

                catch
                {
                 
                }
            } 

            }
           
         
     

        //getting customer name to old estimates
        public void getEstimates(DataGridView dgv)
        {
            try
            {
                con.Open();
                string query = "select Name from clients";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                table = new DataTable();
                da.Fill(table);
                dgv.DataSource = table;

                con.Close();

            }
            catch
            {
              
                con.Close();
            }
        }


        //getting client estimates
        public void getclientEstimate(DataGridView dgv1, string cName){
            try
            {
                con.Open();
                string query = "select Quantity,Description,Unit_Price,Total_Price from estimates where Customer = '" + cName + "'";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                table = new DataTable();
                da.Fill(table);
                dgv1.DataSource = table;

                con.Close();

            }
            catch
            {
                MessageBox.Show("An error occurred please contact the developer 0246819493");
                con.Close();
            }

          
        }
        public void getClientInfo(TextBox name, TextBox contact, TextBox address,string cName)
        {
            try
            {
                con.Open();
                string query = "select * from clients where Name= '" + cName + "' ";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
               
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    name.Text = dr[0].ToString();
                    contact.Text = dr[1].ToString();
                    address.Text = dr[2].ToString();
                }
              

                con.Close();

            }
            catch
            {

                con.Close();
            }

        }
        public void saveEstimate(string name,double workmanship,double netProfit)
        {
             try
                {
                    con.Open();
                    string query = "INSERT INTO estimatecost(Name,Workmanship,netPofit) VALUES(@name,@workmanship,@netprofit)";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@workmanship", workmanship);
                    cmd.Parameters.AddWithValue("@netprofit", netProfit);

                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("estimate has been saved successfully");
                      
                        con.Close();
                    }
                }

                catch
                {
                    MessageBox.Show("An error has occurred please call the developer on 0246819493");
                }
            } 


        //getting saved estimate
        public void getsavedEstimate(NumericUpDown wk , TextBox net,string cName )
        {
            try
            {
                con.Open();
                string query = "select * from estimatecost where Name= '" + cName + "' ";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string hold = dr[1].ToString();
                    wk.Value = Convert.ToDecimal(hold);
                    net.Text = dr[2].ToString();
                   
                }


                con.Close();

            }
            catch
            {

                con.Close();
            }


        }



        //inserting staffs into database
        public void addStaffs(PictureBox pb, string name,string contact,string age,string gender,string Fname,string Fcontact,string Ftown,string Mname,string Mcontact,string Mtown)
        {
            try
            {
                  MemoryStream ms = new MemoryStream();
                pb.Image.Save(ms,pb.Image.RawFormat);
                Byte[] img;
                img = ms.GetBuffer();

      
                con.Open();
                string query = "INSERT INTO staff(Image,Name,Contact,Age,Gender,Fname,Fcontact,Ftown,Mname,Mcontact,Mtown) VALUES(@img,@name,@contact,@age,@gender,@fname,@fcontact,@ftwn,@mname,@mcontact,@mtwn)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@img", SqlDbType.Image).Value =img;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@fname", Fname);
                cmd.Parameters.AddWithValue("@fcontact", Fcontact);
                cmd.Parameters.AddWithValue("@ftwn", Ftown);
                cmd.Parameters.AddWithValue("@mname", Mname);
                cmd.Parameters.AddWithValue("@mcontact", Mcontact);
                cmd.Parameters.AddWithValue("@mtwn", Mtown);

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("staff has been saved successfully");

                    con.Close();
                }
                con.Close();
            }

            catch
            {
                MessageBox.Show("An error has occurred please call the developer on 0246819493");
                con.Close();
            }
        } 

        //getting all staffs
        public void getStaffs(DataGridView dgv)
        {
            try
            {
                con.Open();
                string query = "select * from staff";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                table = new DataTable();

              


                    da.Fill(table);
                    dgv.RowTemplate.Height = 50;
                   
                dgv.DataSource = table;
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (dgv.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dgv.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }
                }

                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return;
              
            }
        }

        public void queryTaker(string query)
        {
            con.Open();
            cmd = new SqlCommand(query, con);
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
             

                con.Close();
            }
            con.Close();
            
        }
        public void queryTaker2(string query,PictureBox Pbregis)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                Pbregis.Image.Save(ms, Pbregis.Image.RawFormat);
                Byte[] img;
                img = ms.GetBuffer();

                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@img", SqlDbType.Image).Value = img;
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {


                    con.Close();
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("An error occurred please check your inputs well");
            }
        }

        public void search(string val , DataGridView dgv)
        {
            try{
                string query = "select * from stocks where concat(Item_Name,category) LIKE '%" + val + "%'";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                table = new DataTable();

                da.Fill(table);

                dgv.DataSource = table;

            }
            catch{
                MessageBox.Show("check your input well and try again");
            }
           
        }

       
        }

    }

