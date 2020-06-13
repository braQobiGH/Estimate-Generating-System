using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odmus
{
    public partial class flashscreen : Form
    {
        public flashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
               progressBar.Value = progressBar.Value+5;
               flashscreen obj = new flashscreen();
       
        if(progressBar.Value ==  progressBar.Maximum) {

            flashscreen.ActiveForm.Hide();
            obj.Close();
            tm.Enabled = false;
           

            
             
             WindowsFormsApplication1.Form1 objj = new WindowsFormsApplication1.Form1();
             objj.ShowDialog();
            
              
        }
    
     
           
          
           
        }

        private void flashscreen_Load(object sender, EventArgs e)
        {
            tm.Start();
        }
    }
}
