namespace WinFormsApp1
{
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void btKaydet_Click(object sender, EventArgs e)
        {
            if (cmbNereden.Text.ToString() != cmbNereye.Text.ToString() && cmbNereden.Text != null && cmbNereye.Text != null && txSaat.Text != null && txAdSoyad.Text != null && txTcNo.Text != null && txTelefon.Text != null)
            {
                lstListe.Items.Add($"Rota {cmbNereden.Text} - {cmbNereye.Text} Tarih: {dtTarih.Text} Saat:{txSaat.Text} Yolcu Bilgisi Ad Soyad: {txAdSoyad.Text} Tc No: {txTcNo.Text} Telefon: {txTelefon.Text}");
            }
            else
            {
                MessageBox.Show("İki Rota Aynı olamaz");
            }
        }

        private void btSifirla_Click(object sender, EventArgs e)
        {
            cmbNereden.Text = "";
            cmbNereye.Text = "";
            dtTarih.Value = DateTime.Now;
            txSaat.Text = "";
            txAdSoyad.Text = "";
            txTcNo.Text = "";
            txTelefon.Text = "";
        }
    }
}
