namespace Apss-Parking
{
    partial class Form1
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        this.usernameTB = new System.Windows.Forms.TextBox();
        this.passwordTB = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.loginBut = new System.Windows.Forms.Button();
        this.label4 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // usernameTB
        // 
        this.usernameTB.Location = new System.Drawing.Point(193, 165);
        this.usernameTB.Margin = new System.Windows.Forms.Padding(4);
        this.usernameTB.Name = "usernameTB";
        this.usernameTB.Size = new System.Drawing.Size(140, 22);
        this.usernameTB.TabIndex = 0;
        this.usernameTB.TextChanged += new System.EventHandler(this.usernameTB_TextChanged);
        // 
        // passwordTB
        // 
        this.passwordTB.Location = new System.Drawing.Point(193, 218);
        this.passwordTB.Margin = new System.Windows.Forms.Padding(4);
        this.passwordTB.Name = "passwordTB";
        this.passwordTB.Size = new System.Drawing.Size(140, 22);
        this.passwordTB.TabIndex = 1;
        this.passwordTB.UseSystemPasswordChar = true;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(77, 169);
        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(84, 16);
        this.label2.TabIndex = 3;
        this.label2.Text = "USERNAME";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(78, 221);
        this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(86, 16);
        this.label3.TabIndex = 4;
        this.label3.Text = "PASSWORD";
        // 
        // loginBut
        // 
        this.loginBut.Location = new System.Drawing.Point(193, 283);
        this.loginBut.Margin = new System.Windows.Forms.Padding(4);
        this.loginBut.Name = "loginBut";
        this.loginBut.Size = new System.Drawing.Size(141, 28);
        this.loginBut.TabIndex = 5;
        this.loginBut.Text = "LOG IN";
        this.loginBut.UseVisualStyleBackColor = true;
        this.loginBut.Click += new System.EventHandler(this.loginBut_Click);
        // 
        // label4
        // 
        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label4.Location = new System.Drawing.Point(-114, 97);
        this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label4.MaximumSize = new System.Drawing.Size(708, 52);
        this.label4.MinimumSize = new System.Drawing.Size(708, 52);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(708, 52);
        this.label4.TabIndex = 6;
        this.label4.Text = "E-PARKING";
        this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // Form1
        // 
        this.AcceptButton = this.loginBut;
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.ControlLight;
        this.ClientSize = new System.Drawing.Size(433, 404);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.loginBut);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.passwordTB);
        this.Controls.Add(this.usernameTB);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Margin = new System.Windows.Forms.Padding(4);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Login Page";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox usernameTB;
    private System.Windows.Forms.TextBox passwordTB;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button loginBut;
    private System.Windows.Forms.Label label4;
}
}

