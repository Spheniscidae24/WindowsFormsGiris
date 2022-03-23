namespace WindowsFormsGiris
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudKapiSayisi = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSifirYuz = new System.Windows.Forms.TextBox();
            this.ddlArabaTuru = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBeygirGucu = new System.Windows.Forms.TextBox();
            this.dtpUretimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbIkinciEl = new System.Windows.Forms.CheckBox();
            this.bOlustur = new System.Windows.Forms.Button();
            this.bGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKapiSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(742, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araba";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka";
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(122, 150);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(245, 27);
            this.tbMarka.TabIndex = 2;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(122, 200);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(245, 27);
            this.tbModel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kapı Sayısı";
            // 
            // nudKapiSayisi
            // 
            this.nudKapiSayisi.Location = new System.Drawing.Point(122, 257);
            this.nudKapiSayisi.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudKapiSayisi.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudKapiSayisi.Name = "nudKapiSayisi";
            this.nudKapiSayisi.Size = new System.Drawing.Size(245, 27);
            this.nudKapiSayisi.TabIndex = 6;
            this.nudKapiSayisi.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Beygir Gücü";
            // 
            // tbSifirYuz
            // 
            this.tbSifirYuz.Location = new System.Drawing.Point(478, 204);
            this.tbSifirYuz.Name = "tbSifirYuz";
            this.tbSifirYuz.Size = new System.Drawing.Size(245, 27);
            this.tbSifirYuz.TabIndex = 7;
            // 
            // ddlArabaTuru
            // 
            this.ddlArabaTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlArabaTuru.FormattingEnabled = true;
            this.ddlArabaTuru.Items.AddRange(new object[] {
            "Hatchback",
            "Sedan",
            "Sport",
            "Station Wagon"});
            this.ddlArabaTuru.Location = new System.Drawing.Point(478, 150);
            this.ddlArabaTuru.Name = "ddlArabaTuru";
            this.ddlArabaTuru.Size = new System.Drawing.Size(245, 28);
            this.ddlArabaTuru.Sorted = true;
            this.ddlArabaTuru.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(419, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(410, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "0-100";
            // 
            // tbBeygirGucu
            // 
            this.tbBeygirGucu.Location = new System.Drawing.Point(122, 307);
            this.tbBeygirGucu.Name = "tbBeygirGucu";
            this.tbBeygirGucu.Size = new System.Drawing.Size(245, 27);
            this.tbBeygirGucu.TabIndex = 7;
            // 
            // dtpUretimTarihi
            // 
            this.dtpUretimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUretimTarihi.Location = new System.Drawing.Point(478, 258);
            this.dtpUretimTarihi.Name = "dtpUretimTarihi";
            this.dtpUretimTarihi.Size = new System.Drawing.Size(250, 27);
            this.dtpUretimTarihi.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(410, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Üretim";
            // 
            // cbIkinciEl
            // 
            this.cbIkinciEl.AutoSize = true;
            this.cbIkinciEl.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbIkinciEl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbIkinciEl.Location = new System.Drawing.Point(410, 308);
            this.cbIkinciEl.Name = "cbIkinciEl";
            this.cbIkinciEl.Size = new System.Drawing.Size(90, 27);
            this.cbIkinciEl.TabIndex = 11;
            this.cbIkinciEl.Text = "İkinci El";
            this.cbIkinciEl.UseVisualStyleBackColor = true;
            // 
            // bOlustur
            // 
            this.bOlustur.Location = new System.Drawing.Point(639, 467);
            this.bOlustur.Name = "bOlustur";
            this.bOlustur.Size = new System.Drawing.Size(94, 29);
            this.bOlustur.TabIndex = 12;
            this.bOlustur.Text = "Oluştur";
            this.bOlustur.UseVisualStyleBackColor = true;
            this.bOlustur.Click += new System.EventHandler(this.bOlustur_Click);
            // 
            // bGetir
            // 
            this.bGetir.Location = new System.Drawing.Point(539, 467);
            this.bGetir.Name = "bGetir";
            this.bGetir.Size = new System.Drawing.Size(94, 29);
            this.bGetir.TabIndex = 13;
            this.bGetir.Text = "Getir";
            this.bGetir.UseVisualStyleBackColor = true;
            this.bGetir.Click += new System.EventHandler(this.bGetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.bGetir);
            this.Controls.Add(this.bOlustur);
            this.Controls.Add(this.cbIkinciEl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpUretimTarihi);
            this.Controls.Add(this.ddlArabaTuru);
            this.Controls.Add(this.tbBeygirGucu);
            this.Controls.Add(this.tbSifirYuz);
            this.Controls.Add(this.nudKapiSayisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arabalar";
            ((System.ComponentModel.ISupportInitialize)(this.nudKapiSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbMarka;
        private TextBox tbModel;
        private Label label3;
        private Label label4;
        private NumericUpDown nudKapiSayisi;
        private Label label5;
        private TextBox tbSifirYuz;
        private ComboBox ddlArabaTuru;
        private Label label6;
        private Label label7;
        private TextBox tbBeygirGucu;
        private DateTimePicker dtpUretimTarihi;
        private Label label8;
        private CheckBox cbIkinciEl;
        private Button bOlustur;
        private Button bGetir;
    }
}