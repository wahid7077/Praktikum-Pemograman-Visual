namespace Parkir_Kendaraan
{
    public partial class Form2 : Form
    {
        double lm, lk, lamaParkir, lp, hp, hargaParkir, tb, kembalian;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LamaParkir.Enabled = false;
            HargaParkir.Enabled = false;
            Kembalian.Enabled = false;
            JenKendaraan.Items.Add("Mobil");
            JenKendaraan.Items.Add("Motor");
            JenKendaraan.SelectedIndex = 0;
        }

        void Bersih()
        {
            Nokendaraan.Clear();
            JamMasuk.Clear();
            JamKeluar.Clear();
            LamaParkir.Clear();
            HargaParkir.Clear();
            TotalBayar.Clear();
            Kembalian.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Process1_Click(object sender, EventArgs e)
        {
            {
                lk = double.Parse(JamKeluar.Text);
                lm = double.Parse(JamMasuk.Text);
                lamaParkir = lk - lm;
                LamaParkir.Text = lamaParkir + "";
            }
            {
                lp = double.Parse(LamaParkir.Text);
                hargaParkir = lp * 16;
                HargaParkir.Text = hargaParkir + "";
            }
            {
                total = double.Parse(TotalBayar.Text);
                kembalian = total - hargaParkir;
                Kembalian.Text = kembalian + "";
            }
        }

        private void JenKendaraan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bersih();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikasi ini dibuat dengan belajar");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string[] item = { tglBox
                              + "", Nokendaraan.Text, JamMasuk.Text, JamKeluar.Text, LamaParkir.Text, TotalBayar.Text, Kembalian.Text };
            ListViewItem obj = new ListViewItem(item);
            listView1.Items.Add(obj);
        }
    }
}