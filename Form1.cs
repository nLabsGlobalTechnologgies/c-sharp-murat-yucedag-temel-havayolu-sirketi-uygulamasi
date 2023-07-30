namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Butonlar üzerine gidip dogru butonu bulmaya çalýþýn");
            btnClickMe.BackColor = Color.DarkRed;
            btnClickMe.BackColor = Color.Coral;
        }

        private void btnClickMe_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
            this.BackColor = Color.DarkOrange;
        }

        private void btLeftTop_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Beni Buldun");
            this.BackColor = Color.DarkRed;
            btnClickMe.BackColor = Color.Coral;
        }

        private void btLeftBottom_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Kaybettin");
            this.BackColor = Color.DarkBlue;
            btnClickMe.BackColor = Color.Coral;
        }

        private void btRightTop_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Kaybettin");
            this.BackColor = Color.DarkGreen;
            btnClickMe.BackColor = Color.Coral;
        }

        private void btRightBottom_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Kaybettin");
            this.BackColor = Color.MediumPurple;
            btnClickMe.BackColor = Color.Coral;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2 frm = new frm2();
            frm.ShowDialog();
        }
    }
}