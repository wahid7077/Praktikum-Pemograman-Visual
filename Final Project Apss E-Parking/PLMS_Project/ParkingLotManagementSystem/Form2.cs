using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ParkingLotManagementSystem
{
    public partial class Form2 : Form
    {
        /// Variable Declarations
        int occupied = 0;
        int available = 100;
        int numVehicles = 0;
        

        public Form2()
        {
            InitializeComponent();
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void vehicleinTB_Click(object sender, EventArgs e) /// Vehicle In Button
        {
            /// Check if the Text box is empty
            if (string.IsNullOrWhiteSpace(licenseTB.Text) ||
                string.IsNullOrWhiteSpace(brandTB.Text) ||
                string.IsNullOrWhiteSpace(colorTB.Text)
                )
            {
                MessageBox.Show("Please complete the fields.", "Error");
            }
            else
            {
                if (available > 0)
                {
                    /// Increment number of occupied slots while decrementing the numerber of available slots
                    available = available - 1;
                    occupied = occupied + 1;

                    /// Write data to the label with the format "000"
                    availableLabel.Text = available.ToString("D3");
                    occupiedLabel.Text = occupied.ToString("D3");

                    /// Add rows that copies data from your input in the textbox and other info
                    int n = dataTable.Rows.Add();
                    dataTable.Rows[n].Cells[0].Value = licenseTB.Text;
                    dataTable.Rows[n].Cells[1].Value = brandTB.Text;
                    dataTable.Rows[n].Cells[2].Value = colorTB.Text;
                    dataTable.Rows[n].Cells[3].Value = timeinTB.Text;
                    dataTable.Rows[n].Cells[4].Value = "N/A";
                    dataTable.Rows[n].Cells[5].Value = "N/A";
                    dataTable.Rows[n].Cells[6].Value = "N/A";

                    /// Empties the text box for fast vehicle information processing
                    licenseTB.Clear();
                    brandTB.Clear();
                    colorTB.Clear();
                    durationTB.Clear();
                    costTB.Clear();

                    /// Changes the color of the whole row to Green-Yellow
                    for (int j = 0; j <= 6; j++)
                    {
                        dataTable.Rows[n].Cells[j].Style.BackColor = Color.GreenYellow;
                    }
                }
                else
                    MessageBox.Show("Full Parking.", "Error");
            }   

        }

        private void updateBut_Click(object sender, EventArgs e) /// Vehicle Out Button
        {
            /// Obtain data from our time picker box
            DateTime timein = DateTime.Parse(timeinTB.Text);
            DateTime timeout = DateTime.Parse(timeoutTB.Text);
                
                /// Checks if there are entries present on the data table, else shows an error message
                if (dataTable.Rows.Count > 0)
                {
                    /// Checks if the parking lot is still vacant, else shows an error message
                    if (occupied > 0)
                    {
                        /// Increment number of available slots while decrementing the numerber of occupied slots
                        /// and then writes them to our "counter" labels
                        available = available + 1;
                        occupied = occupied - 1;

                        availableLabel.Text = available.ToString("D3");
                        occupiedLabel.Text = occupied.ToString("D3");

                        /// Obtain the parking duration of the vehicle
                        float duration = float.Parse((timeout - timein).TotalMinutes.ToString());
                        var span = System.TimeSpan.FromMinutes(duration);
                        var hour = ((int)span.TotalHours).ToString();
                        var Minute = span.Minutes.ToString();

                        /// Writes the number of hours and minutes parked in the duration text box
                        durationTB.Text = hour + "hr " + Minute + "min";

                        float numHours = duration / 60;
                        int price;

                        /// Computes for the cost based on the parking duration of the vehicle
                        ///     Follows the pricing:
                        ///     free - less than 15 minutes
                        ///     50php - first 3 hours
                        ///     20php - per succeding hour (after the 3 hours)
                        if (numHours > 0)
                        {
                            if (duration / 60 <= 0.25)
                            {
                                costTB.Text = "Rp" + 0;
                            }
                            else if (numHours <= 3 && numHours > 1000)
                            {
                                costTB.Text = "Rp" + 50;
                            }
                            else if (numHours > 3)
                            {
                                price = 50 + ((int)Math.Ceiling(numHours) - 3) * 20;
                                costTB.Text = "Rp" + price;
                            }

                        }
                        /// Increment total number of vehicles that parked 
                        numVehicles = numVehicles + 1;

                        /// Writes down the time of departure, parking duration, and cost on the data table.
                        dataTable.Rows[dataTable.CurrentRow.Index].Cells["timeoutCol"].Value = timeoutTB.Text;
                        dataTable.Rows[dataTable.CurrentRow.Index].Cells["durationCol"].Value = durationTB.Text;
                        dataTable.Rows[dataTable.CurrentRow.Index].Cells["costCol"].Value = costTB.Text;

                        /// Changes the color of the selected row to Red
                        for (int j = 0; j <= 6; j++)
                        {
                            dataTable.Rows[dataTable.CurrentRow.Index].Cells[j].Style.BackColor = Color.Red;
                        }

                        /// These information will be passed on to Form3 to display the digital receipt for the customer.
                        string rn = numVehicles.ToString("D4");
                        string lp = licenseTB.Text.ToString();
                        string ti = timeinTB.Text.ToString();
                        string to = timeoutTB.Text.ToString();
                        string d = durationTB.Text.ToString();
                        string c = costTB.Text.ToString();

                        /// Opens the receipt window (Form3)
                        Form3 frm = new Form3();
                        frm.values(rn.ToString(), lp.ToString(), ti.ToString(), to.ToString(), d.ToString(), c.ToString());
                        frm.Show();

                    }
                    
                }
                else
                {
                    MessageBox.Show("No entries currently available.", "Error");
                }
                    

        }

        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e) /// Cell click interaction
        {
            /// Obtaines the data contained in the data table and copies them in their corresponding textbox.
            if (e.RowIndex > -1)
            {
                DataGridViewRow Row = dataTable.Rows[e.RowIndex];

                licenseTB.Text = Row.Cells["licenseCol"].Value.ToString();
                brandTB.Text = Row.Cells["brandCol"].Value.ToString();
                colorTB.Text = Row.Cells["colorCol"].Value.ToString();
                timeinTB.Text = Row.Cells["timeinCol"].Value.ToString();
                durationTB.Text = Row.Cells["durationCol"].Value.ToString();
                costTB.Text = Row.Cells["costCol"].Value.ToString();

                /// Prevent error when selecting rows with empty/null cells
                if (Row.Cells["timeoutCol"].Value.ToString() != "N/A") {

                    timeoutTB.Text = Row.Cells["timeoutCol"].Value.ToString();
                } else
                {
                    timeoutTB.Text = null;
                }

            }
        }

        private void timeoutTB_Leave(object sender, EventArgs e) /// After selecting the Time Out
        {
            /// Same price computing program as the one found under the Vehicle Out button function 
            DateTime timein = DateTime.Parse(timeinTB.Text);
            DateTime timeout = DateTime.Parse(timeoutTB.Text);
            /// Obtain the parking duration of the vehicle
            float duration = float.Parse((timeout - timein).TotalMinutes.ToString());
            var span = System.TimeSpan.FromMinutes(duration);
            var hour = ((int)span.TotalHours).ToString();
            var Minute = span.Minutes.ToString();

            /// Writes the number of hours and minutes parked in the duration text box
            durationTB.Text = hour + "hr " + Minute + "min";

            float numHours = duration / 60;
            int price;

            /// Computes for the cost based on the parking duration of the vehicle
            ///     Follows the pricing:
            ///     free - less than 15 minutes
            ///     50php - first 3 hours
            ///     20php - per succeding hour (after the 3 hours)
            if (numHours > 0)
            {
                if (duration / 60 <= 0.25)
                {
                    costTB.Text = "Rp" + 0;
                }
                else if (numHours <= 3 && numHours > 0.25)
                {
                    costTB.Text = "Rp" + 1000;
                }
                else if (numHours > 3)
                {
                    price = 50 + ((int)Math.Ceiling(numHours) - 3) * 20;
                    costTB.Text = "Rp" + price;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e) /// Timer component used to obtain the current time
        {
            timeLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
            timeinTB.Text = DateTime.Now.ToString("h:mm:ss tt");
            

        }

        private void Form2_Load(object sender, EventArgs e) /// Timer immediately starts after Form2 is launched
        {
            timer1.Start();
        }

        private void deleteTB_Click(object sender, EventArgs e) /// Delete Button
        {
            DateTime intime = DateTime.Parse(timeinTB.Text);
            DateTime outtime = DateTime.Parse(timeoutTB.Text);

            /// Deletes the whole selected row if there is at least 1 entry in the data table
            if (dataTable.Rows.Count > 0)
            {
                float time = float.Parse((outtime - intime).TotalMinutes.ToString());

                /// Limits the deletion of rows to only vehicles that have not parked/paid
                /// The purpose for the delete button is to correct mistakes only, not to remove any rows the attendant wishes to
                if (time<=15)
                {
                    available = available + 1;
                    occupied = occupied - 1;
                    availableLabel.Text = available.ToString("D3");
                    occupiedLabel.Text = occupied.ToString("D3");

                    dataTable.Rows.RemoveAt(this.dataTable.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("Cannot remove this entry.", "Error");
                }
            }
            else
                MessageBox.Show("No entries currently available.", "Error");
        }

        private void logoutTB_Click(object sender, EventArgs e) /// Logout Button
        {
            /// Does two things:
            /// 1. Exports the information contained in the data table as .xlsx (recommended and safer) or .xls format
            /// 2. Clears all of the data stored in the data table and brings the user back to the login menu
            if (MessageBox.Show("Do you want to logout and save as an Excel spreadsheet?", "Confirm Logout",
               MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                
                /// Program to save the data table as .xlsx or .xls format
                saveFileDialog1.InitialDirectory = "C:";
                saveFileDialog1.Title = "Save as Excel File";
                saveFileDialog1.FileName = "";
                saveFileDialog1.Filter = "Excel Workbook|*.xlsx|Excel File (2003)|*.xls";

                if(saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    ExcelApp.Application.Workbooks.Add(Type.Missing);

                    ExcelApp.Columns.ColumnWidth = 15;
                    ExcelApp.Columns.AutoFit();
                    ExcelApp.Columns.Justify();

                    /// Storing the Header part of the Table (containing the license plate, brand, color, etc.)
                    for (int i = 1; i < dataTable.Columns.Count + 1; i++)
                    {
                        ExcelApp.Cells[1, i] = dataTable.Columns[i - 1].HeaderText;
                    }

                    /// Storing the Table Contents under the header (actual data from the user input)
                    for(int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        for(int j = 0; j < dataTable.Columns.Count; j++)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = dataTable.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                    ExcelApp.ActiveWorkbook.Saved = true;
                    ExcelApp.Quit();
                }
               
                /// Closes the dashboard window (Form2) after saving the file, and opens the login window (Form1)
                var Form1 = new Form1();
                Form1.Show();
                Visible = false;
                
            }
        }

        private void salesTB_Click(object sender, EventArgs e) /// Sales Button
        {
            int numRows = int.Parse(dataTable.RowCount.ToString());
            int total = 0;

            /// Displays two things:
            /// 1. Total Number of vehicles that parked
            /// 2. Total Sales in PHP
            /// Can be clicked anytime during the operations to view current status of the business
            for(int i = 0; i<numRows; i++)
            {
                if (dataTable.Rows[i].Cells["costCol"].Value.ToString() != "N/A")
                {
                    string val = dataTable.Rows[i].Cells["costCol"].Value.ToString();
                    total = total + int.Parse(val.Substring(1));
                }
            }

            MessageBox.Show("Total Number of Vehicles:  " + numVehicles + "\n" + "                        Total Sales:  " + "₱" + total.ToString() + "\n", "Current Sales Report");
          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void occupiedLabel_Click(object sender, EventArgs e)
        {

        }

        private void availableLabel_Click(object sender, EventArgs e)
        {
                    }

        private void availableLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
