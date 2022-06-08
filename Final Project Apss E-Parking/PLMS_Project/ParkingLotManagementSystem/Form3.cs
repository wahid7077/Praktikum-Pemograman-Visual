using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLotManagementSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        /// This function references the data that was passed from the dashboard (Form2)
        public void values(string rn, string lp, string ti, string to, string d, string c) 
        {
            /// Obtains the following data from the dashboard:
            /// 1. Current Date
            /// 2. Receipt Number (based on total number of vehicles parked)
            /// 3. Vehicle License
            /// 4. Time in
            /// 5. Time out
            /// 6. Parking duration
            /// 7. Cost
            dateLabel.Text = DateTime.Now.ToString("MM/dd/yyy");
            receiptnoTB.Text = rn.ToString();
            licenseLabel.Text = lp.ToString();
            timeinLabel.Text = ti.ToString();
            timeoutLabel.Text = to.ToString();
            durationLabel.Text = d.ToString();
            amountLabel.Text = c.ToString();

            /// Display cost as ₱0 instead of N/A
            if (amountLabel.Text == "N/A")
            {
                amountLabel.Text = "₱0";
            }
        }

        private void paidBut_Click(object sender, EventArgs e) /// Paid Button
        {
            /// Closes the receipt window
            /// Alternatively, the user can press "Enter" or "Esc" to close
            this.Hide();
        }
    }
}
