namespace ParkingLotManagementSystem
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.vehicleinTB = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.deleteTB = new System.Windows.Forms.Button();
            this.logoutTB = new System.Windows.Forms.Button();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.licenseCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeinCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeoutCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.licenseTB = new System.Windows.Forms.TextBox();
            this.brandTB = new System.Windows.Forms.TextBox();
            this.colorTB = new System.Windows.Forms.TextBox();
            this.timeinTB = new System.Windows.Forms.DateTimePicker();
            this.timeoutTB = new System.Windows.Forms.DateTimePicker();
            this.durationTB = new System.Windows.Forms.TextBox();
            this.costTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updateBut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.occupiedLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.availableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleinTB
            // 
            this.vehicleinTB.BackColor = System.Drawing.Color.PaleGreen;
            this.vehicleinTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleinTB.Location = new System.Drawing.Point(195, 471);
            this.vehicleinTB.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleinTB.Name = "vehicleinTB";
            this.vehicleinTB.Size = new System.Drawing.Size(132, 41);
            this.vehicleinTB.TabIndex = 0;
            this.vehicleinTB.Text = "MASUK";
            this.vehicleinTB.UseVisualStyleBackColor = false;
            this.vehicleinTB.Click += new System.EventHandler(this.vehicleinTB_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(24, 22);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // deleteTB
            // 
            this.deleteTB.BackColor = System.Drawing.Color.Red;
            this.deleteTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTB.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteTB.Location = new System.Drawing.Point(351, 747);
            this.deleteTB.Margin = new System.Windows.Forms.Padding(4);
            this.deleteTB.Name = "deleteTB";
            this.deleteTB.Size = new System.Drawing.Size(132, 41);
            this.deleteTB.TabIndex = 3;
            this.deleteTB.Text = "HAPUS";
            this.deleteTB.UseVisualStyleBackColor = false;
            this.deleteTB.Click += new System.EventHandler(this.deleteTB_Click);
            // 
            // logoutTB
            // 
            this.logoutTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutTB.Location = new System.Drawing.Point(1267, 747);
            this.logoutTB.Margin = new System.Windows.Forms.Padding(4);
            this.logoutTB.Name = "logoutTB";
            this.logoutTB.Size = new System.Drawing.Size(132, 41);
            this.logoutTB.TabIndex = 4;
            this.logoutTB.Text = "LOG OUT";
            this.logoutTB.UseVisualStyleBackColor = true;
            this.logoutTB.Click += new System.EventHandler(this.logoutTB_Click);
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToResizeColumns = false;
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.licenseCol,
            this.brandCol,
            this.colorCol,
            this.timeinCol,
            this.timeoutCol,
            this.durationCol,
            this.costCol});
            this.dataTable.Location = new System.Drawing.Point(351, 270);
            this.dataTable.Margin = new System.Windows.Forms.Padding(4);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.Size = new System.Drawing.Size(1048, 470);
            this.dataTable.TabIndex = 6;
            this.dataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellClick);
            this.dataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellContentClick);
            // 
            // licenseCol
            // 
            this.licenseCol.FillWeight = 134.9172F;
            this.licenseCol.HeaderText = "LICENSE PLATE";
            this.licenseCol.MinimumWidth = 6;
            this.licenseCol.Name = "licenseCol";
            this.licenseCol.ReadOnly = true;
            this.licenseCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // brandCol
            // 
            this.brandCol.FillWeight = 104.0789F;
            this.brandCol.HeaderText = "BRAND";
            this.brandCol.MinimumWidth = 6;
            this.brandCol.Name = "brandCol";
            this.brandCol.ReadOnly = true;
            // 
            // colorCol
            // 
            this.colorCol.FillWeight = 104.0789F;
            this.colorCol.HeaderText = "COLOR";
            this.colorCol.MinimumWidth = 6;
            this.colorCol.Name = "colorCol";
            this.colorCol.ReadOnly = true;
            // 
            // timeinCol
            // 
            this.timeinCol.FillWeight = 104.0789F;
            this.timeinCol.HeaderText = "TIME IN";
            this.timeinCol.MinimumWidth = 6;
            this.timeinCol.Name = "timeinCol";
            this.timeinCol.ReadOnly = true;
            // 
            // timeoutCol
            // 
            this.timeoutCol.FillWeight = 104.0789F;
            this.timeoutCol.HeaderText = "TIME OUT";
            this.timeoutCol.MinimumWidth = 6;
            this.timeoutCol.Name = "timeoutCol";
            this.timeoutCol.ReadOnly = true;
            // 
            // durationCol
            // 
            this.durationCol.FillWeight = 104.0789F;
            this.durationCol.HeaderText = "DURATION";
            this.durationCol.MinimumWidth = 6;
            this.durationCol.Name = "durationCol";
            this.durationCol.ReadOnly = true;
            // 
            // costCol
            // 
            this.costCol.FillWeight = 104.0789F;
            this.costCol.HeaderText = "AMOUNT";
            this.costCol.MinimumWidth = 6;
            this.costCol.Name = "costCol";
            this.costCol.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "NO.KENDARAAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // licenseTB
            // 
            this.licenseTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.licenseTB.Location = new System.Drawing.Point(151, 273);
            this.licenseTB.Margin = new System.Windows.Forms.Padding(4);
            this.licenseTB.Name = "licenseTB";
            this.licenseTB.Size = new System.Drawing.Size(175, 22);
            this.licenseTB.TabIndex = 8;
            // 
            // brandTB
            // 
            this.brandTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.brandTB.Location = new System.Drawing.Point(152, 326);
            this.brandTB.Margin = new System.Windows.Forms.Padding(4);
            this.brandTB.Name = "brandTB";
            this.brandTB.Size = new System.Drawing.Size(173, 22);
            this.brandTB.TabIndex = 9;
            // 
            // colorTB
            // 
            this.colorTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.colorTB.Location = new System.Drawing.Point(151, 379);
            this.colorTB.Margin = new System.Windows.Forms.Padding(4);
            this.colorTB.Name = "colorTB";
            this.colorTB.Size = new System.Drawing.Size(175, 22);
            this.colorTB.TabIndex = 10;
            // 
            // timeinTB
            // 
            this.timeinTB.Enabled = false;
            this.timeinTB.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeinTB.Location = new System.Drawing.Point(195, 439);
            this.timeinTB.Margin = new System.Windows.Forms.Padding(4);
            this.timeinTB.Name = "timeinTB";
            this.timeinTB.Size = new System.Drawing.Size(131, 22);
            this.timeinTB.TabIndex = 11;
            this.timeinTB.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // timeoutTB
            // 
            this.timeoutTB.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeoutTB.Location = new System.Drawing.Point(195, 555);
            this.timeoutTB.Margin = new System.Windows.Forms.Padding(4);
            this.timeoutTB.Name = "timeoutTB";
            this.timeoutTB.Size = new System.Drawing.Size(131, 22);
            this.timeoutTB.TabIndex = 12;
            this.timeoutTB.Leave += new System.EventHandler(this.timeoutTB_Leave);
            // 
            // durationTB
            // 
            this.durationTB.Enabled = false;
            this.durationTB.Location = new System.Drawing.Point(195, 670);
            this.durationTB.Margin = new System.Windows.Forms.Padding(4);
            this.durationTB.Name = "durationTB";
            this.durationTB.ReadOnly = true;
            this.durationTB.Size = new System.Drawing.Size(131, 22);
            this.durationTB.TabIndex = 13;
            this.durationTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // costTB
            // 
            this.costTB.Enabled = false;
            this.costTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTB.Location = new System.Drawing.Point(195, 720);
            this.costTB.Margin = new System.Windows.Forms.Padding(4);
            this.costTB.Name = "costTB";
            this.costTB.ReadOnly = true;
            this.costTB.Size = new System.Drawing.Size(131, 23);
            this.costTB.TabIndex = 14;
            this.costTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 326);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "JENIS KENDARAAN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 383);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "WARNA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 444);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "WAKTU MASUK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 555);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "WAKTU KELUAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 673);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "DURASI";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 724);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "TOTAL BAYAR";
            // 
            // updateBut
            // 
            this.updateBut.BackColor = System.Drawing.Color.LightCoral;
            this.updateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBut.Location = new System.Drawing.Point(195, 591);
            this.updateBut.Margin = new System.Windows.Forms.Padding(4);
            this.updateBut.Name = "updateBut";
            this.updateBut.Size = new System.Drawing.Size(132, 41);
            this.updateBut.TabIndex = 22;
            this.updateBut.Text = "KELUAR";
            this.updateBut.UseVisualStyleBackColor = false;
            this.updateBut.Click += new System.EventHandler(this.updateBut_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(342, 98);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(235, 54);
            this.timeLabel.TabIndex = 24;
            this.timeLabel.Text = "hh:mm:ss";
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(859, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 31);
            this.label8.TabIndex = 25;
            this.label8.Text = "DITEMPATI";
            // 
            // occupiedLabel
            // 
            this.occupiedLabel.AutoSize = true;
            this.occupiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupiedLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.occupiedLabel.Location = new System.Drawing.Point(832, 98);
            this.occupiedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.occupiedLabel.Name = "occupiedLabel";
            this.occupiedLabel.Size = new System.Drawing.Size(219, 113);
            this.occupiedLabel.TabIndex = 26;
            this.occupiedLabel.Text = "000";
            this.occupiedLabel.Click += new System.EventHandler(this.occupiedLabel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1120, 52);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 31);
            this.label11.TabIndex = 27;
            this.label11.Text = "TERSEDIA";
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.availableLabel.Location = new System.Drawing.Point(1089, 98);
            this.availableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(219, 113);
            this.availableLabel.TabIndex = 28;
            this.availableLabel.Text = "100";
            this.availableLabel.Click += new System.EventHandler(this.availableLabel_Click_1);
            // 
            // Form2
            // 
            this.AcceptButton = this.vehicleinTB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1415, 818);
            this.Controls.Add(this.availableLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.occupiedLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.updateBut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costTB);
            this.Controls.Add(this.durationTB);
            this.Controls.Add(this.timeoutTB);
            this.Controls.Add(this.timeinTB);
            this.Controls.Add(this.colorTB);
            this.Controls.Add(this.brandTB);
            this.Controls.Add(this.licenseTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.logoutTB);
            this.Controls.Add(this.deleteTB);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.vehicleinTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APPS E-PARKING";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vehicleinTB;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button deleteTB;
        private System.Windows.Forms.Button logoutTB;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox licenseTB;
        private System.Windows.Forms.TextBox brandTB;
        private System.Windows.Forms.TextBox colorTB;
        private System.Windows.Forms.DateTimePicker timeinTB;
        private System.Windows.Forms.DateTimePicker timeoutTB;
        private System.Windows.Forms.TextBox durationTB;
        private System.Windows.Forms.TextBox costTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateBut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeinCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeoutCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn costCol;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label occupiedLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label availableLabel;
    }
}