namespace Apss-Parking
{
    partial class Form3
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
        this.label1 = new System.Windows.Forms.Label();
        this.label8 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.label6 = new System.Windows.Forms.Label();
        this.dateLabel = new System.Windows.Forms.Label();
        this.licenseLabel = new System.Windows.Forms.Label();
        this.timeinLabel = new System.Windows.Forms.Label();
        this.timeoutLabel = new System.Windows.Forms.Label();
        this.durationLabel = new System.Windows.Forms.Label();
        this.amountLabel = new System.Windows.Forms.Label();
        this.paidBut = new System.Windows.Forms.Button();
        this.receiptnoTB = new System.Windows.Forms.TextBox();
        this.timer1 = new System.Windows.Forms.Timer(this.components);
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(252, 11);
        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(129, 25);
        this.label1.TabIndex = 0;
        this.label1.Text = "Receipt No:";
        this.label1.Click += new System.EventHandler(this.label1_Click);
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label8.Location = new System.Drawing.Point(163, 87);
        this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(57, 20);
        this.label8.TabIndex = 7;
        this.label8.Text = "Date:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(88, 122);
        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(128, 20);
        this.label2.TabIndex = 8;
        this.label2.Text = "License Plate:";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label3.Location = new System.Drawing.Point(139, 196);
        this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(84, 20);
        this.label3.TabIndex = 9;
        this.label3.Text = "Time In:";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label4.Location = new System.Drawing.Point(124, 238);
        this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(96, 20);
        this.label4.TabIndex = 10;
        this.label4.Text = "Time Out:";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label5.Location = new System.Drawing.Point(148, 354);
        this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(74, 20);
        this.label5.TabIndex = 11;
        this.label5.Text = "Amout:";
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label6.Location = new System.Drawing.Point(131, 282);
        this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(91, 20);
        this.label6.TabIndex = 12;
        this.label6.Text = "Duration:";
        // 
        // dateLabel
        // 
        this.dateLabel.AutoSize = true;
        this.dateLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.dateLabel.Location = new System.Drawing.Point(231, 87);
        this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.dateLabel.Name = "dateLabel";
        this.dateLabel.Size = new System.Drawing.Size(114, 23);
        this.dateLabel.TabIndex = 13;
        this.dateLabel.Text = "data here";
        // 
        // licenseLabel
        // 
        this.licenseLabel.AutoSize = true;
        this.licenseLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.licenseLabel.Location = new System.Drawing.Point(231, 122);
        this.licenseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.licenseLabel.Name = "licenseLabel";
        this.licenseLabel.Size = new System.Drawing.Size(114, 23);
        this.licenseLabel.TabIndex = 14;
        this.licenseLabel.Text = "data here";
        this.licenseLabel.Click += new System.EventHandler(this.licenseLabel_Click);
        // 
        // timeinLabel
        // 
        this.timeinLabel.AutoSize = true;
        this.timeinLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.timeinLabel.Location = new System.Drawing.Point(231, 196);
        this.timeinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.timeinLabel.Name = "timeinLabel";
        this.timeinLabel.Size = new System.Drawing.Size(114, 23);
        this.timeinLabel.TabIndex = 15;
        this.timeinLabel.Text = "data here";
        // 
        // timeoutLabel
        // 
        this.timeoutLabel.AutoSize = true;
        this.timeoutLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.timeoutLabel.Location = new System.Drawing.Point(231, 238);
        this.timeoutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.timeoutLabel.Name = "timeoutLabel";
        this.timeoutLabel.Size = new System.Drawing.Size(114, 23);
        this.timeoutLabel.TabIndex = 16;
        this.timeoutLabel.Text = "data here";
        // 
        // durationLabel
        // 
        this.durationLabel.AutoSize = true;
        this.durationLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.durationLabel.Location = new System.Drawing.Point(231, 279);
        this.durationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.durationLabel.Name = "durationLabel";
        this.durationLabel.Size = new System.Drawing.Size(114, 23);
        this.durationLabel.TabIndex = 17;
        this.durationLabel.Text = "data here";
        // 
        // amountLabel
        // 
        this.amountLabel.AutoSize = true;
        this.amountLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.amountLabel.Location = new System.Drawing.Point(231, 352);
        this.amountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.amountLabel.Name = "amountLabel";
        this.amountLabel.Size = new System.Drawing.Size(114, 23);
        this.amountLabel.TabIndex = 18;
        this.amountLabel.Text = "data here";
        // 
        // paidBut
        // 
        this.paidBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.paidBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.paidBut.Location = new System.Drawing.Point(176, 459);
        this.paidBut.Margin = new System.Windows.Forms.Padding(4);
        this.paidBut.Name = "paidBut";
        this.paidBut.Size = new System.Drawing.Size(109, 34);
        this.paidBut.TabIndex = 19;
        this.paidBut.Text = "Paid";
        this.paidBut.UseVisualStyleBackColor = true;
        this.paidBut.Click += new System.EventHandler(this.paidBut_Click);
        // 
        // receiptnoTB
        // 
        this.receiptnoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.receiptnoTB.Location = new System.Drawing.Point(395, 9);
        this.receiptnoTB.Margin = new System.Windows.Forms.Padding(4);
        this.receiptnoTB.Name = "receiptnoTB";
        this.receiptnoTB.ReadOnly = true;
        this.receiptnoTB.Size = new System.Drawing.Size(52, 26);
        this.receiptnoTB.TabIndex = 20;
        this.receiptnoTB.Text = "0000";
        // 
        // Form3
        // 
        this.AcceptButton = this.paidBut;
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.CancelButton = this.paidBut;
        this.ClientSize = new System.Drawing.Size(464, 508);
        this.Controls.Add(this.receiptnoTB);
        this.Controls.Add(this.paidBut);
        this.Controls.Add(this.amountLabel);
        this.Controls.Add(this.durationLabel);
        this.Controls.Add(this.timeoutLabel);
        this.Controls.Add(this.timeinLabel);
        this.Controls.Add(this.licenseLabel);
        this.Controls.Add(this.dateLabel);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label8);
        this.Controls.Add(this.label1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Margin = new System.Windows.Forms.Padding(4);
        this.Name = "Form3";
        this.Text = "Receipt";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label dateLabel;
    private System.Windows.Forms.Label licenseLabel;
    private System.Windows.Forms.Label timeinLabel;
    private System.Windows.Forms.Label timeoutLabel;
    private System.Windows.Forms.Label durationLabel;
    private System.Windows.Forms.Label amountLabel;
    private System.Windows.Forms.Button paidBut;
    private System.Windows.Forms.TextBox receiptnoTB;
    private System.Windows.Forms.Timer timer1;
}
}