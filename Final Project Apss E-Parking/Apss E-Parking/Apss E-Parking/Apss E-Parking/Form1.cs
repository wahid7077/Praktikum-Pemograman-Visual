using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apss E-Parking
{
    public partial class Form1 : Form
    {
        string a;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBut_Click(object sender, EventArgs e) // Login Button
        {
            string user = usernameTB.Text;
            string pass = passwordTB.Text;

            /// Set the Accounts username and password
            string username = "admin";
            string password = "admin";

          
                    
              if (user == username && pass == password)
                    {
                        this.Hide();

                /// Data from the combo box is passed to Form
                Form2 frm = new Form2();
                        frm.Show(); 

                    }
                    else
                    {
                        MessageBox.Show("Login Failed.", "Error");
                    }
            
        }

        private void usernameTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void attendantCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
