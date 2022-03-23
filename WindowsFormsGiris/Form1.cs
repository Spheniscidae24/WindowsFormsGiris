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
            MessageBox.Show("Araba oluþturuldu.");
        }

        private void bGetir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Marka: " + _araba.Marka +
                "\n" + "Model: " + _araba.Model +
                "\n" + "Kapý Sayýsý: " + _araba.KapiSayisi + " kapý" +
                "\n" + "Beygir gücü: " + _araba.BeygirGucu + " hp" +
                "\n" + "0-100: " + _araba.SifirYuz + " sn" +
                "\n" + "Üretim tarihi: " + _araba.UretimTarihi.ToShortDateString() +
                "\n" + "Ýkinci el: " + (_araba.IkinciEl ? "Evet" : "Hayýr"));
        }
    }
}