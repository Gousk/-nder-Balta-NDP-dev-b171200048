namespace FormOdev2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kişiselBilgilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxKisiselBilgiler = new System.Windows.Forms.GroupBox();
            this.buttonListele = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.comboBoxSemt = new System.Windows.Forms.ComboBox();
            this.radioButtonErkek = new System.Windows.Forms.RadioButton();
            this.radioButtonKadin = new System.Windows.Forms.RadioButton();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxTelNo = new System.Windows.Forms.TextBox();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxTCNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxKisiselBilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kişiselBilgilerToolStripMenuItem,
            this.siparişGörüntüleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kişiselBilgilerToolStripMenuItem
            // 
            this.kişiselBilgilerToolStripMenuItem.Name = "kişiselBilgilerToolStripMenuItem";
            this.kişiselBilgilerToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.kişiselBilgilerToolStripMenuItem.Text = "Kişisel Bilgiler";
            this.kişiselBilgilerToolStripMenuItem.Click += new System.EventHandler(this.kişiselBilgilerToolStripMenuItem_Click);
            // 
            // siparişGörüntüleToolStripMenuItem
            // 
            this.siparişGörüntüleToolStripMenuItem.Name = "siparişGörüntüleToolStripMenuItem";
            this.siparişGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.siparişGörüntüleToolStripMenuItem.Text = "Hakkında";
            this.siparişGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.siparişGörüntüleToolStripMenuItem_Click);
            // 
            // groupBoxKisiselBilgiler
            // 
            this.groupBoxKisiselBilgiler.Controls.Add(this.buttonListele);
            this.groupBoxKisiselBilgiler.Controls.Add(this.buttonTemizle);
            this.groupBoxKisiselBilgiler.Controls.Add(this.buttonKaydet);
            this.groupBoxKisiselBilgiler.Controls.Add(this.comboBoxSemt);
            this.groupBoxKisiselBilgiler.Controls.Add(this.radioButtonErkek);
            this.groupBoxKisiselBilgiler.Controls.Add(this.radioButtonKadin);
            this.groupBoxKisiselBilgiler.Controls.Add(this.textBoxAdres);
            this.groupBoxKisiselBilgiler.Controls.Add(this.textBoxTelNo);
            this.groupBoxKisiselBilgiler.Controls.Add(this.textBoxAdSoyad);
            this.groupBoxKisiselBilgiler.Controls.Add(this.textBoxTCNo);
            this.groupBoxKisiselBilgiler.Controls.Add(this.label6);
            this.groupBoxKisiselBilgiler.Controls.Add(this.label5);
            this.groupBoxKisiselBilgiler.Controls.Add(this.label4);
            this.groupBoxKisiselBilgiler.Controls.Add(this.label3);
            this.groupBoxKisiselBilgiler.Controls.Add(this.label2);
            this.groupBoxKisiselBilgiler.Controls.Add(this.label1);
            this.groupBoxKisiselBilgiler.Location = new System.Drawing.Point(0, 27);
            this.groupBoxKisiselBilgiler.Name = "groupBoxKisiselBilgiler";
            this.groupBoxKisiselBilgiler.Size = new System.Drawing.Size(516, 206);
            this.groupBoxKisiselBilgiler.TabIndex = 1;
            this.groupBoxKisiselBilgiler.TabStop = false;
            this.groupBoxKisiselBilgiler.Text = "Kişisel Bilgiler";
            this.groupBoxKisiselBilgiler.Enter += new System.EventHandler(this.groupBoxKisiselBilgiler_Enter);
            // 
            // buttonListele
            // 
            this.buttonListele.Location = new System.Drawing.Point(175, 141);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(75, 23);
            this.buttonListele.TabIndex = 15;
            this.buttonListele.Text = "Listele";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(94, 141);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(75, 23);
            this.buttonTemizle.TabIndex = 14;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(13, 141);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(75, 23);
            this.buttonKaydet.TabIndex = 13;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // comboBoxSemt
            // 
            this.comboBoxSemt.FormattingEnabled = true;
            this.comboBoxSemt.Items.AddRange(new object[] {
            "Darıca",
            "Çayırova\t",
            "Gebze\t",
            "Dilovası",
            "Körfez",
            "Derince",
            "İzmit",
            "Kandıra",
            "Kartepe",
            "Başiskele",
            "Gölcük",
            "Karamürsel"});
            this.comboBoxSemt.Location = new System.Drawing.Point(318, 143);
            this.comboBoxSemt.Name = "comboBoxSemt";
            this.comboBoxSemt.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSemt.TabIndex = 12;
            this.comboBoxSemt.Text = "İlçe Seçiniz...";
            this.comboBoxSemt.SelectedIndexChanged += new System.EventHandler(this.comboBoxSemt_SelectedIndexChanged);
            // 
            // radioButtonErkek
            // 
            this.radioButtonErkek.AutoSize = true;
            this.radioButtonErkek.Location = new System.Drawing.Point(151, 108);
            this.radioButtonErkek.Name = "radioButtonErkek";
            this.radioButtonErkek.Size = new System.Drawing.Size(53, 17);
            this.radioButtonErkek.TabIndex = 11;
            this.radioButtonErkek.TabStop = true;
            this.radioButtonErkek.Text = "Erkek";
            this.radioButtonErkek.UseVisualStyleBackColor = true;
            // 
            // radioButtonKadin
            // 
            this.radioButtonKadin.AutoSize = true;
            this.radioButtonKadin.Checked = true;
            this.radioButtonKadin.Location = new System.Drawing.Point(95, 108);
            this.radioButtonKadin.Name = "radioButtonKadin";
            this.radioButtonKadin.Size = new System.Drawing.Size(52, 17);
            this.radioButtonKadin.TabIndex = 10;
            this.radioButtonKadin.TabStop = true;
            this.radioButtonKadin.Text = "Kadın";
            this.radioButtonKadin.UseVisualStyleBackColor = true;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(318, 61);
            this.textBoxAdres.Multiline = true;
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(121, 64);
            this.textBoxAdres.TabIndex = 9;
            // 
            // textBoxTelNo
            // 
            this.textBoxTelNo.Location = new System.Drawing.Point(92, 61);
            this.textBoxTelNo.Name = "textBoxTelNo";
            this.textBoxTelNo.Size = new System.Drawing.Size(121, 20);
            this.textBoxTelNo.TabIndex = 8;
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(318, 20);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(121, 20);
            this.textBoxAdSoyad.TabIndex = 7;
            // 
            // textBoxTCNo
            // 
            this.textBoxTCNo.Location = new System.Drawing.Point(92, 20);
            this.textBoxTCNo.MaxLength = 11;
            this.textBoxTCNo.Name = "textBoxTCNo";
            this.textBoxTCNo.Size = new System.Drawing.Size(121, 20);
            this.textBoxTCNo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "İlçe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 199);
            this.Controls.Add(this.groupBoxKisiselBilgiler);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kişisel Bilgiler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxKisiselBilgiler.ResumeLayout(false);
            this.groupBoxKisiselBilgiler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kişiselBilgilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişGörüntüleToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxKisiselBilgiler;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.ComboBox comboBoxSemt;
        private System.Windows.Forms.RadioButton radioButtonErkek;
        private System.Windows.Forms.RadioButton radioButtonKadin;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxTelNo;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTCNo;
        public System.Windows.Forms.Button buttonKaydet;
    }
}

