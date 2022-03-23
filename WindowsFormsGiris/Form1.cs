namespace WindowsFormsGiris
{
    public partial class Form1 : Form
    {
        Araba _araba;
        public Form1()
        {
            InitializeComponent();
        }

        private void bOlustur_Click(object sender, EventArgs e)
        {
            _araba = new Araba();
            _araba.Marka = tbMarka.Text;
            _araba.Model = tbModel.Text;
            //araba.KapiSayisi = (byte)nudKapiSayisi.Value;   // casting
            _araba.KapiSayisi = Convert.ToByte(nudKapiSayisi.Value);
            _araba.BeygirGucu = short.Parse(tbBeygirGucu.Text);
            _araba.SifirYuz = Convert.ToDouble(tbSifirYuz.Text);
            _araba.UretimTarihi = dtpUretimTarihi.Value;
            _araba.IkinciEl = cbIkinciEl.Checked;
            _araba.ArabaTuru = (ArabaTuru)ddlArabaTuru.SelectedIndex;
            MessageBox.Show("Araba olu�turuldu.");
        }

        private void bGetir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Marka: " + _araba.Marka +
                "\n" + "Model: " + _araba.Model +
                "\n" + "Kap� Say�s�: " + _araba.KapiSayisi + " kap�" +
                "\n" + "Beygir g�c�: " + _araba.BeygirGucu + " hp" +
                "\n" + "0-100: " + _araba.SifirYuz + " sn" +
                "\n" + "�retim tarihi: " + _araba.UretimTarihi.ToShortDateString() +
                "\n" + "�kinci el: " + (_araba.IkinciEl ? "Evet" : "Hay�r"));
        }
    }
}